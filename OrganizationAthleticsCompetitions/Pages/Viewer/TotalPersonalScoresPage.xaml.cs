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
    public partial class TotalPersonalScoresPage : Page
    {
        public TotalPersonalScoresPage()
        {
            InitializeComponent();
            lvTotalScore.ItemsSource = DataAccess.GetTeams();
        }

        private void radioPersonal_Click(object sender, RoutedEventArgs e)
        {
            lvPersonalScore.Visibility = Visibility.Visible;
            lvTotalScore.Visibility = Visibility.Collapsed;
            lvPersonalScore.ItemsSource = DataAccess.GetSportsmans();
        }

        private void radioTotal_Click(object sender, RoutedEventArgs e)
        {
            lvPersonalScore.Visibility = Visibility.Collapsed;
            lvTotalScore.Visibility = Visibility.Visible;
            lvTotalScore.ItemsSource = DataAccess.GetTeams();
        }
    }
}
