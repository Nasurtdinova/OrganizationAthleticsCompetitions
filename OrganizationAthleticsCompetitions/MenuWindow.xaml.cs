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
using System.Windows.Shapes;

namespace OrganizationAthleticsCompetitions
{
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();

            Manager.Sportsmans = ItemSportsmans;
            Manager.CommandsTrainer = ItemMyCommand;
            Manager.Commands = ItemCommand;
            Manager.ResultCompetitions = ItemResult;
            Manager.Trainers = ItemTrainers;
            Manager.Authorization = login;
            Manager.Exit = exit;
            Manager.EditProfile = profile;
            Manager.Sponsors = ItemSponsors;
            Manager.Requests = ItemRequests;
            Manager.PartipicationTrainer = ItemPartipication;
            Manager.RoleNameLabel = lbRoleName;

            GridMain.Navigate(new MainPage());
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            GridMain.Margin = new Thickness(210, 60, 0, 0);
            textOrganiz.Margin = new Thickness(280, 0, 0, 0);
            lbRoleName.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            GridMain.Margin = new Thickness(70, 60, 0, 0);
            textOrganiz.Margin = new Thickness(100, 0, 0, 0);
            lbRoleName.Visibility = Visibility.Collapsed;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    GridMain.Navigate(new MainPage());
                    break;
                case "ItemSportsmans":
                    GridMain.Navigate(new SportsmansPage());
                    break;
                case "ItemTrainers":
                    GridMain.Navigate(new TrainersPage());
                    break;
                case "ItemCommand":
                    GridMain.Navigate(new TeamsPage());
                    break;
                case "ItemMyCommand":
                    GridMain.Navigate(new MyCommandPage());
                    break;
                case "ItemCompetition":
                    GridMain.Navigate(new CompetitionsPage());
                    break;
                case "ItemPartipication":
                    GridMain.Navigate(new MyRequestsPage());
                    break;
                case "ItemResult":
                    GridMain.Navigate(new ResultCompetitionsPage());
                    break;
                case "ItemSponsors":
                    GridMain.Navigate(new SponsorsPage());
                    break;
                case "ItemRequests":
                    GridMain.Navigate(new RequestsSponsorPage());
                    break;
                case "ItemScore":
                    GridMain.Navigate(new TotalPersonalScoresPage());
                    break;
                case "ItemReports":
                    GridMain.Navigate(new ReportPage());
                    break;
                default:
                    break;
            }
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Navigate(new AuthorizationPage());
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Navigate(new EditProfileTPage());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser.user = null;
            Manager.UpdatePanel();
            GridMain.Navigate(new AuthorizationPage());
        }
    }
}
