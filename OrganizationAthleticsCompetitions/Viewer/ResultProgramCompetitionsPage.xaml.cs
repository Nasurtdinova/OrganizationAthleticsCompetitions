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
            lvResultProgramCompetitinon.ItemsSource = DataAccess.GetResultsInProgramCompetition(prCom);
        }

        private void btnAddResult_Click(object sender, RoutedEventArgs e)
        {
            (new AddResultPage(ProgramCompetition)).Show();
        }
    }
}
