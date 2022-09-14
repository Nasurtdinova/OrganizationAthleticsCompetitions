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
using System.Windows.Threading;

namespace OrganizationAthleticsCompetitions
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        double panelWidth;
        bool hidden;

        public MainWindow()
        {
            InitializeComponent();

            Manager.MainFrame = mainFrame;

            Manager.SportsmansTrainer = sportsmanTrainer;
            Manager.Sportsmans = sportsman;

            Manager.CommandsTrainer = commandTrainer;
            Manager.Commands = command;

            Manager.CompetitionsAdmin = competitionAdmin;
            Manager.Competitions = competition;

            Manager.ResultCompetitionsAdmin = resultCompetitionAdmin;
            Manager.ResultCompetitions = resultCompetition;

            Manager.Authorization = login;
            Manager.Exit = exit;

            Manager.RoleNameLabel = lbRoleName;
            Manager.EditProfile = editProfile;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(1);
            timer.Tick += Timer_Tick;

            panelWidth = sidePanel.Width;

            mainFrame.Navigate(new AuthorizationPage());
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                mainIcon.Visibility = Visibility.Visible;
                sidePanel.Width += 1;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                    lbRoleName.Visibility = Visibility.Visible;
                    mainFrame.Margin = new Thickness(210, 50, 0, 0);
                    panelHeader.Margin = new Thickness(210, 0, 0, 0);
                }
            }
            else
            {
                mainIcon.Visibility = Visibility.Hidden;
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 45)
                {
                    timer.Stop();
                    hidden = true;
                    lbRoleName.Visibility = Visibility.Collapsed;
                    mainFrame.Margin = new Thickness(40, 50, 0, 0);
                    panelHeader.Margin = new Thickness(40, 0, 0, 0);
                }
            }
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AuthorizationPage());
        }

        private void sportsman_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }

        private void competition_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new CompetitionsPage());
        }

        private void competitionAdmin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void command_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new TeamsPage());
        }

        private void resultCompetition_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resultCompetitionAdmin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sportsmanTrainer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void commandTrainer_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new MyCommandPage());
        }
    }
}
