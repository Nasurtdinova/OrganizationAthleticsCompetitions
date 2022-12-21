using BespokeFusion;
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
    public partial class RequestsSponsorPage : Page
    {
        public RequestsSponsorPage()
        {
            InitializeComponent();          
            NoDatas();
        }

        public void NoDatas()
        {
            lvRequests.ItemsSource = DataAccess.GetSponsorTeams().Where(a => a.Sponsor.IdUser == CurrentUser.user.Id && a.IdStatus == 1);
            if (lvRequests.Items.Count == 0)
                tbNoName.Text = "У вас нет новых заявок!";
            else
                tbNoName.Text = " ";
        }

        private void btnNoAccept_Click(object sender, RoutedEventArgs e)
        {
            var selected = (sender as Button).DataContext as SponsorTeam;
            selected.IdStatus = 2;
            selected.DateOfChange = DateTime.Now;
            Connection.connection.SaveChanges();
            NoDatas();
            MaterialMessageBox.Show("Заявка отклонена!");
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            var selected = (sender as Button).DataContext as SponsorTeam;
            selected.IdStatus = 3;
            selected.DateOfChange = DateTime.Now;
            Connection.connection.SaveChanges();
            NoDatas();
            MaterialMessageBox.Show("Заявка принята!");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnTeam_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeamSponsorsPage());
        }

        private void lvRequests_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = (sender as ListView).SelectedItem as SponsorTeam;
            NavigationService.Navigate(new SportsmansInCommandPage(selected.Team));
        }
    }
}
