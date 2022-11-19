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
    public partial class MyCommandPage : Page
    {
        public MyCommandPage()
        {
            InitializeComponent();
            lvMyCommands.ItemsSource = DataAccess.GetTeamsInTreaner(CurrentUser.trainer);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var i = (sender as Button).DataContext as Trainer_Team;
            NavigationService.Navigate(new AddCommandPage(i.Team));
        }

        private void btnRemoveTrainer_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите прекратить тренерство?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var a = (sender as Button).DataContext as Trainer_Team;
                a.IsActive = false;
                Connection.connection.SaveChanges();
                MaterialMessageBox.Show("Тренерство прекращено!");
                lvMyCommands.ItemsSource = DataAccess.GetTeamsInTreaner(CurrentUser.trainer);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCommandPage(null));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
