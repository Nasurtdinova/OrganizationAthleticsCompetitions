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
    public partial class SelectSportsmanWindow : Page
    {
        public Team CurrentCommand = new Team();
        public SelectSportsmanWindow(Team team)
        {
            InitializeComponent();
            CurrentCommand = team;
            comboSportsmans.ItemsSource = DataAccess.GetSportsmans();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditSportsmanPage(null,CurrentCommand));
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            var a = comboSportsmans.SelectedItem as Sportsman;
            a.Team = CurrentCommand;
            Connection.connection.SaveChanges();
            NavigationService.Navigate(new AddCommandPage(CurrentCommand));
        }
    }
}
