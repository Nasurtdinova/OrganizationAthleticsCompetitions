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
            lvRequests.ItemsSource = DataAccess.GetSponsorTeams().Where(a => a.Sponsor.IdUser == CurrentUser.user.Id && a.IdStatus == 1);
        }

        private void btnNoAccept_Click(object sender, RoutedEventArgs e)
        {
            var selected = (sender as ListView).SelectedItem as SponsorTeam;
            selected.IdStatus = 2;
            Connection.connection.SaveChanges();
            lvRequests.ItemsSource = DataAccess.GetSponsorTeams().Where(a => a.Sponsor.IdUser == CurrentUser.user.Id && a.IdStatus == 1);
            MaterialMessageBox.Show("Заявка отклонена!");
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            var selected = (sender as ListView).SelectedItem as SponsorTeam;
            selected.IdStatus = 3;
            Connection.connection.SaveChanges();
            lvRequests.ItemsSource = DataAccess.GetSponsorTeams().Where(a => a.Sponsor.IdUser == CurrentUser.user.Id && a.IdStatus == 1);
            MaterialMessageBox.Show("Заявка принята!");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
