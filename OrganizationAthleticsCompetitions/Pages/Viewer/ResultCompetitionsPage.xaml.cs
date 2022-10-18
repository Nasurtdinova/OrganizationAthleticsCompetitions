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
    public partial class ResultCompetitionsPage : Page
    {
        public ResultCompetitionsPage()
        {
            InitializeComponent();
            comboCompetitions.ItemsSource = DataAccess.GetCompetitions();           
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void comboCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Competition;
            if (a != null)
                dgRrogramsCompetitions.ItemsSource = DataAccess.GetProgramsInCompetition(a);
        }

        private void dgRrogramsCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as DataGrid).SelectedItem as ProgramCompetition;
            if (a != null)
                dgResulsPrograms.ItemsSource = DataAccess.GetResultsInProgramCompetition(a);
        }
    }
}
