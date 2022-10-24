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
    public partial class AddEditCompetitionWindow : Window
    {
        public Competition CurrentCompetition = new Competition();
        public AddEditCompetitionWindow(Competition compet)
        {
            InitializeComponent();
            if (compet != null)
                CurrentCompetition = compet;
            Title = CurrentCompetition.Id == 0 ? "Добавление соревнования" : "Редактирование соревнования";
            DataContext = CurrentCompetition;
            comboCategory.ItemsSource = DataAccess.GetCategoryCompetitions();
            comboCity.ItemsSource = DataAccess.GetCities();
            comboVenue.ItemsSource = DataAccess.GetVenues();
            dgProgramsCompetitions.ItemsSource = DataAccess.GetProgramsInCompetition(CurrentCompetition);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.SaveCompetition(CurrentCompetition);
        }

        private void btnAddProgram_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentCompetition.Id != 0)
            {
                AddEditProgramCompetition add = new AddEditProgramCompetition(null);
                add.Show();
                add.Closed += (s, eventarg) =>
                {
                    dgProgramsCompetitions.ItemsSource = DataAccess.GetProgramsInCompetition(CurrentCompetition);
                };
            }
            else
                MaterialMessageBox.ShowError("Вы еще не сохранили соревнование!");
        }

        private void comboCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboVenue.ItemsSource = DataAccess.GetVenues().Where(a => a.City == comboCity.SelectedItem as City);
        }

        private void comboVenue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboCity.ItemsSource = DataAccess.GetCities().Where(a => a.Venue == comboVenue.SelectedItem as Venue);
        }

        private void btnEditProgram_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as ProgramCompetition;
            AddEditProgramCompetition edit = new AddEditProgramCompetition(a);
            edit.Show();
            edit.Closed += (s, eventarg) =>
            {
                dgProgramsCompetitions.ItemsSource = DataAccess.GetProgramsInCompetition(CurrentCompetition);
            };
        }
    }
}
