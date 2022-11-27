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
    public partial class TrainersPage : Page
    {
        public TrainersPage()
        {
            InitializeComponent();
            trainersList.ItemsSource = DataAccess.GetTrainers();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnRegistrTrainer_Click(object sender, RoutedEventArgs e)
        {
            RegistrEditTrainerWindow edit = new RegistrEditTrainerWindow(null);
            edit.Show();
            edit.Closed += (s, eventarg) =>
            {
                trainersList.ItemsSource = DataAccess.GetTrainers();
            };
        }

        private void trainersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RegistrEditTrainerWindow edit = new RegistrEditTrainerWindow((sender as ListView).SelectedItem as Trainer);
            edit.Show();
            edit.Closed += (s, eventarg) =>
            {
                trainersList.ItemsSource = DataAccess.GetTrainers();
            };
        }
    }
}
