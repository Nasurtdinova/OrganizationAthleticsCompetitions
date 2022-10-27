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
using System.Windows.Shapes;

namespace OrganizationAthleticsCompetitions
{
    public partial class AddEditProgramCompetition : Window
    {
        public ProgramCompetition CurrentProgramCompetition = new ProgramCompetition();
        public AddEditProgramCompetition(ProgramCompetition prog)
        {
            InitializeComponent();
            if (prog != null)
                CurrentProgramCompetition = prog;

            tpTime.SelectedTime = new DateTime(CurrentProgramCompetition.TimeStart.Ticks);
            DataContext = CurrentProgramCompetition;
            dpDate.DisplayDateStart = DateTime.Now;
            comboTypeCompetition.ItemsSource = DataAccess.GetTypesCompetitions();
            comboTypeProgram.ItemsSource = DataAccess.GetTypesProgram();
            Title = CurrentProgramCompetition.Id == 0 ? "Добавление программы" : "Редактирование программы";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.SaveProgramCompetition(CurrentProgramCompetition);
            MaterialMessageBox.Show("Информация сохранена");
            Close();
        }
    }
}
