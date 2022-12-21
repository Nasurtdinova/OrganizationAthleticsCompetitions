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
            NoDatas();
        }

        public void NoDatas()
        { 
            lvNotifiies.ItemsSource = DataAccess.GetSponsorTeams().Where(a=>a.Trainer == CurrentUser.trainer);
            if (lvNotifiies.Items.Count == 0)
                tbNoName.Text = "У вас нет уведомлений!";
            else
                tbNoName.Text = " ";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите отменить заявку?", "Предупреждение", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var a = (sender as Button).DataContext as SponsorTeam;
                Connection.connection.SponsorTeam.Remove(a);
                Connection.connection.SaveChanges();
                NoDatas();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
