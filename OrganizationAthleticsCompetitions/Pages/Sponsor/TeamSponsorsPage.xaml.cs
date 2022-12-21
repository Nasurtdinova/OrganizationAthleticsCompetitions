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
    public partial class TeamSponsorsPage : Page
    {
        public TeamSponsorsPage()
        {
            InitializeComponent();            
            NoDatas();
        }

        public void NoDatas()
        {
            lvTeams.ItemsSource = DataAccess.GetSponsorTeams().Where(a => a.IdStatus == 3 && a.Sponsor.User == CurrentUser.user);
            if (lvTeams.Items.Count == 0)
                tbNoName.Text = "У вас нет еще команд для сонсирования!";
            else
                tbNoName.Text = " ";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnCansel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно прервать спонсирование этой команды?", "Предупреждение", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var selected = (sender as Button).DataContext as SponsorTeam;
                selected.IdStatus = 4;
                Connection.connection.SaveChanges();
                NoDatas();
            }
        }

        private void lvTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = (sender as ListView).SelectedItem as SponsorTeam;
            NavigationService.Navigate(new SportsmansInCommandPage(selected.Team));
        }
    }
}
