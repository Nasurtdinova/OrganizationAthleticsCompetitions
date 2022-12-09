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
    public partial class NotifyPage : Page
    {
        public NotifyPage()
        {
            InitializeComponent();
            lvNotifiies.ItemsSource = DataAccess.GetSponsorTeams().Where(a=>a.Trainer == CurrentUser.trainer);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as ListView).SelectedItem as SponsorTeam;
            Connection.connection.SponsorTeam.Remove(a);
            Connection.connection.SaveChanges();
        }
    }
}
