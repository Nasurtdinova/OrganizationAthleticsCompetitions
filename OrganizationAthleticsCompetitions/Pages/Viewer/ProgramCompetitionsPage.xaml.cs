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
    public partial class ProgramCompetitionsPage : Page
    {
        public List<ProgramCompetition> ListCompetitions = new List<ProgramCompetition>();
        public Competition CurrentCompetition = new Competition();
        public ProgramCompetitionsPage(Competition com)
        {
            InitializeComponent();
            if (com.DateStart > DateTime.Now)
                columnResult.Width = 0;
            else
                columnSendRequest.Width = 0;

            if (CurrentUser.user == null)
                columnSendRequest.Width = 0;
            
            else if (CurrentUser.user.Role.Name == "Администратор")
            {
                columnSendRequest.Width = 0;
                columnRequests.Width = 120;
            }
            CurrentCompetition = com;
            lvProgramsCompetition.ItemsSource = DataAccess.GetProgramsInCompetition(com);
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as ProgramCompetition;
            NavigationService.Navigate(new ResultProgramCompetitionsPage(a));
        }

        private void btnRequests_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as ProgramCompetition;
            NavigationService.Navigate(new AdminRequestsPage(DataAccess.GetRequestsForProgramCompetition(a)));
        }

        private void btnSendRequest_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as ProgramCompetition;
            if (a.CountAttendees == a.MaxCountAttendees)
                MaterialMessageBox.ShowError("Мест нет!");
            else
            {
                RequestPage request = new RequestPage(a);
                request.Show();
                request.Closed += (s, eventarg) =>
                {
                    lvProgramsCompetition.ItemsSource = DataAccess.GetProgramsInCompetition(CurrentCompetition);
                };
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
