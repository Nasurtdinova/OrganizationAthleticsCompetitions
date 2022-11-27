using BespokeFusion;
using OrganizationAthleticsCompetitions.DataBase;
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

namespace OrganizationAthleticsCompetitions
{
    public partial class AddResultWindow : Window
    {
        public ProgramCompetition ProgCompet = new ProgramCompetition();
        public AddResultWindow(ProgramCompetition pr)
        {
            InitializeComponent();
            ProgCompet = pr;
            formatResult.Text = pr.TypeCompetition.FormatResult.Name;
            typeCompetition.Text = pr.TypeCompetition.Name;
            typeProgram.Text = pr.TypeProgram.Name;
            competitionName.Text = pr.Competition.Name;
            List<Sportsman> list = DataAccess.GetRequestsForProgramCompetition(pr).Select(a => a.Sportsman).ToList();
            foreach (var i in DataAccess.GetResultsInProgramCompetition(pr))
                list.Remove(i.Request.Sportsman);
            cbSportsman.ItemsSource = list;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (DataAccess.GetResultsInProgramCompetition(ProgCompet).Where(a => a.Request.Sportsman == cbSportsman.SelectedItem as Sportsman).Count() == 0)
            {
                if (String.IsNullOrEmpty(tbResult.Text) && cbSportsman.SelectedItem == null)
                    MaterialMessageBox.ShowError("Заполните данные!","Предупреждение!");
                else
                {
                    ResultCompetition res = new ResultCompetition()
                    {
                        Request = DataAccess.GetRequestSportsmanProgram((cbSportsman.SelectedItem as Sportsman).Id, ProgCompet.Id),
                        Result = Convert.ToDouble(tbResult.Text)
                    };
                    DataAccess.AddResult(res, ProgCompet);                  
                    Close();
                }
            }
            else
            {
                MaterialMessageBox.ShowError("Вы уже добавили результат этого спортсмена!");
            }
        }
    }
}
