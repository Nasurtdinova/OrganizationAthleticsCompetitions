using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BespokeFusion;
using OrganizationAthleticsCompetitions.DataBase;

namespace OrganizationAthleticsCompetitions
{

    public partial class RequestPage : Window
    {
        ProgramCompetition CurrentProgram = new ProgramCompetition();
        TimeSpan timeStart = new TimeSpan();

        public RequestPage(ProgramCompetition prog)
        {
            InitializeComponent();
            CurrentProgram = prog;

            if (CurrentProgram.CountAttendees == 0)
                timeStart = CurrentProgram.TimeStart;
            else
                timeStart = new TimeSpan(0, 5, 0) + DataAccess.GetRequestsForProgramCompetition(CurrentProgram).Last().StartTime;
            
            tbStartTime.Text = timeStart.ToString();
            comboSportsman.ItemsSource = DataAccess.GetSportmansInGenderAndTrainer(prog.Gender);
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (DataAccess.GetRequests().Where(a => a.IdSportsman == (comboSportsman.SelectedItem as Sportsman).Id && a.IdProgramCompetition == CurrentProgram.Id).FirstOrDefault() == null)
            {
                Request req = new Request()
                {
                    IdProgramCompetition = CurrentProgram.Id,
                    IdSportsman = (comboSportsman.SelectedItem as Sportsman).Id,
                    StartTime = timeStart
                };

                DataAccess.AddRequest(req);
                MaterialMessageBox.Show("Информация сохранена");
                Close();
            }
            else
                MaterialMessageBox.Show("Вы уже отправили заявку на этого спортсмена!", "Уведомление!");
        }
    }
}
