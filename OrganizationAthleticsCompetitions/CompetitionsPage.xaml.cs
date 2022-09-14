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
    /// <summary>
    /// Логика взаимодействия для CompetitionsPage.xaml
    /// </summary>
    public partial class CompetitionsPage : Page
    {
        public CompetitionsPage()
        {
            InitializeComponent();
            dgCompetitions.ItemsSource = DataAccess.GetCompetitions();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void checkMonth_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProgram_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as Competition;
            if (a != null)
            {
                Manager.MainFrame.NavigationService.Navigate(new ProgramCompetitionsPage(a));
            }
        }

        private void comboCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
