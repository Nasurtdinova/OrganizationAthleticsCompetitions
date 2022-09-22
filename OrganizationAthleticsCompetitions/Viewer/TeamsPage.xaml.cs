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
    public partial class TeamsPage : Page
    {
        public TeamsPage()
        {
            InitializeComponent();
            lvTeams.ItemsSource = DataAccess.GetTeams();
        }

        private void lvTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var team = (sender as ListView).SelectedItem as Team;
            NavigationService.Navigate(new SportsmansInCommandPage(team));
        }
    }
}
