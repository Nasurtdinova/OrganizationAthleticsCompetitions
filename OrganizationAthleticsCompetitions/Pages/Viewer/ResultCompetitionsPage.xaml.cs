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
            if (CurrentUser.user != null && CurrentUser.user.IdRole == 1)
                removeColumn.Width = 150;
            comboCompetitions.ItemsSource = DataAccess.GetCompetitions().Where(a=>a.DateStart <= DateTime.Now);           
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void comboCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Competition;
            if (a != null)
                dgRrogramsCompetitions.ItemsSource = DataAccess.GetProgramsInCompetition(a).Where(b=>b.Date <= DateTime.Now);
        }

        private void dgRrogramsCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as DataGrid).SelectedItem as ProgramCompetition;
            if (a != null)
            {
                if (CurrentUser.user != null && CurrentUser.user.IdRole == 1)
                    btnAddResult.Visibility = Visibility.Visible;
                dgResulsPrograms.ItemsSource = DataAccess.GetResultsInProgramCompetition(a);
            }
        }

        private void btnRemoveResult_Click(object sender, RoutedEventArgs e)
        {
            var res = (sender as Button).DataContext as ResultCompetition;
            if (MessageBox.Show("Вы точно хотите удалить результат?", "Предупреждение", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                res.IsDeleted = true;
                Connection.connection.SaveChanges();
            }
        }

        private void btnAddResult_Click(object sender, RoutedEventArgs e)
        {            
            AddResultPage add = new AddResultPage(dgRrogramsCompetitions.SelectedItem as ProgramCompetition);
            add.Show();
            add.Closed += (s, eventarg) =>
            {
                dgResulsPrograms.ItemsSource = DataAccess.GetResultsInProgramCompetition(dgRrogramsCompetitions.SelectedItem as ProgramCompetition);
            };
        }
    }
}
