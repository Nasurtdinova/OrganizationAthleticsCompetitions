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
    public partial class OurSponsorsPage : Page
    {
        public OurSponsorsPage()
        {
            InitializeComponent();
            var list = new List<SponsorTeam>();
            foreach (var i in DataAccess.GetTeamsInTreaner(CurrentUser.trainer).Select(a => a.Team))
            {
                foreach (var j in DataAccess.GetSponsorTeams().Where(a => a.Team == i && a.IdStatus == 3))             
                    list.Add(j);
            }

            sponsorsList.ItemsSource = list;
            NoDatas();
        }

        public void NoDatas()
        {          
            if (sponsorsList.Items.Count == 0)
                tbNoName.Text = "У вас нет спонсоров!";
            else
                tbNoName.Text = " ";
        }

        private void btnSponsors_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SponsorsPage());
        }

        private void btnNotifies_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NotifyPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
