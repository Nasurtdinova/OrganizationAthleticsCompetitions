using BespokeFusion;
using OrganizationAthleticsCompetitions.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public AddEditProgramCompetition(ProgramCompetition prog,Competition competition)
        {
            InitializeComponent();
            if (prog != null)
            {
                CurrentProgramCompetition = prog;
                comboGender.Visibility = Visibility.Collapsed;
                tbGender.Visibility = Visibility.Collapsed;
            }
            CurrentProgramCompetition.Competition = competition;
            tpTime.SelectedTime = new DateTime(CurrentProgramCompetition.TimeStart.Ticks);
            DataContext = CurrentProgramCompetition;
            dpDate.DisplayDateStart = competition.DateStart;
            dpDate.DisplayDateEnd = competition.DateEnd;
            comboTypeCompetition.ItemsSource = DataAccess.GetTypesCompetitions();
            comboTypeProgram.ItemsSource = DataAccess.GetTypesProgram();
            comboGender.ItemsSource = DataAccess.GetGenders();
            Title = CurrentProgramCompetition.Id == 0 ? "Добавление программы" : "Редактирование программы";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (tpTime.SelectedTime != null)
                CurrentProgramCompetition.TimeStart = new TimeSpan(tpTime.SelectedTime.Value.Ticks);
            
            var programs = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(CurrentProgramCompetition);

            if (!Validator.TryValidateObject(CurrentProgramCompetition, context, programs, true))
                foreach (var error in programs)
                    MaterialMessageBox.ShowError(error.ErrorMessage);
            else
            {
                if (CurrentProgramCompetition.Id == 0)
                {
                    if (DataAccess.GetProgramsInCompetition(CurrentProgramCompetition.Competition).Where(a => a.TypeProgram == comboTypeProgram.SelectedItem as TypeProgram && a.TypeCompetition == comboTypeCompetition.SelectedItem as TypeCompetition && a.Gender1 == comboGender.SelectedItem as Gender).Count() == 0)
                    {
                        DataAccess.SaveProgramCompetition(CurrentProgramCompetition);
                        MaterialMessageBox.Show("Информация сохранена");
                        Close();
                    }
                    else
                        MaterialMessageBox.Show("Вы уже добавили такую программу в это соревнование!");
                }
                else
                {
                    DataAccess.SaveProgramCompetition(CurrentProgramCompetition);
                    MaterialMessageBox.Show("Информация сохранена");
                    Close();
                }

            }
        }
    }
}
