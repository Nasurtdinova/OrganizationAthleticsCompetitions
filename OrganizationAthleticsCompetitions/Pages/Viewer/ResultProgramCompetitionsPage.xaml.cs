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
using OrganizationAthleticsCompetitions.DataBase;

namespace OrganizationAthleticsCompetitions
{
    public partial class ResultProgramCompetitionsPage : Page
    {
        public ProgramCompetition ProgramCompetition { get; set; }
        public ResultProgramCompetitionsPage(ProgramCompetition prCom)
        {
            InitializeComponent();
            if (CurrentUser.user != null && CurrentUser.user.IdRole == 1)
                btnAddResult.Visibility = Visibility.Visible;
            ProgramCompetition = prCom;
            program.Text = ProgramCompetition.ProgramCompet;
            format.Text = $"Формат: {ProgramCompetition.TypeCompetition.FormatResult.Name}";
            lvResultProgramCompetitinon.ItemsSource = DataAccess.GetResultsInProgramCompetition(prCom).OrderBy(a=>a.Rank);
        }

        private void btnAddResult_Click(object sender, RoutedEventArgs e)
        {
            AddResultWindow add = new AddResultWindow(ProgramCompetition);
            add.Show();
            add.Closed += (s, eventarg) =>
            {
                lvResultProgramCompetitinon.ItemsSource = DataAccess.GetResultsInProgramCompetition(ProgramCompetition).OrderBy(a => a.Rank);
            };
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void lvResultProgramCompetitinon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var res = (sender as ListView).SelectedItem as ResultCompetition;
            if (CurrentUser.user != null && CurrentUser.user.IdRole == 1)
            {
                if (MessageBox.Show("Вы точно хотите удалить результат?", "Предупреждение", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
                {
                    res.IsDeleted = true;
                    Connection.connection.SaveChanges();
                    lvResultProgramCompetitinon.ItemsSource = DataAccess.GetResultsInProgramCompetition(ProgramCompetition).OrderBy(a => a.Rank);
                }
            }
        }
    }
}
