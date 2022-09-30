using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OrganizationAthleticsCompetitions
{
    public class Manager
    {
        public static Frame MainFrame { get; set; }
        public static Menu MainMenu { get; set; }

        public static Label RoleNameLabel { get; set; }

        public static ListViewItem Authorization { get; set; }
        public static StackPanel Exit { get; set; }

        public static Button SportsmansTrainer { get; set; }
        public static Button Sportsmans { get; set; }

        public static Button CommandsTrainer { get; set; }
        public static Button Commands { get; set; }

        public static Button CompetitionsAdmin { get; set; }
        public static Button Competitions { get; set; }

        public static Button ResultCompetitionsAdmin { get; set; }
        public static Button ResultCompetitions { get; set; }

        public static StackPanel EditProfile { get; set; }

        public static void DoAdmin()
        {
            VisibleCollapsedAuthReg();
            RoleNameLabel.Content = "Админ";

            Sportsmans.Visibility = System.Windows.Visibility.Visible;
            Commands.Visibility = System.Windows.Visibility.Visible;
            Competitions.Visibility = System.Windows.Visibility.Collapsed;
            ResultCompetitions.Visibility = System.Windows.Visibility.Collapsed;

            EditProfile.Visibility = System.Windows.Visibility.Collapsed;

            //SportsmansTrainer.Visibility = System.Windows.Visibility.Collapsed;
            CommandsTrainer.Visibility = System.Windows.Visibility.Collapsed;

            CompetitionsAdmin.Visibility = System.Windows.Visibility.Visible;       
            ResultCompetitionsAdmin.Visibility = System.Windows.Visibility.Visible;

        }

        public static void DoViewer()
        {
            VisibleCollapsedAuthReg();
            RoleNameLabel.Content = "Зритель";

            Sportsmans.Visibility = System.Windows.Visibility.Visible;
            Commands.Visibility = System.Windows.Visibility.Visible;
            Competitions.Visibility = System.Windows.Visibility.Visible;
            ResultCompetitions.Visibility = System.Windows.Visibility.Visible;

            EditProfile.Visibility = System.Windows.Visibility.Collapsed;

            //SportsmansTrainer.Visibility = System.Windows.Visibility.Collapsed;
            CommandsTrainer.Visibility = System.Windows.Visibility.Collapsed;

            CompetitionsAdmin.Visibility = System.Windows.Visibility.Collapsed;
            ResultCompetitionsAdmin.Visibility = System.Windows.Visibility.Collapsed;
        }

        public static void DoTrainer()
        {
            VisibleCollapsedAuthReg();
            RoleNameLabel.Content = "Тренер";

            Sportsmans.Visibility = System.Windows.Visibility.Visible;
            Commands.Visibility = System.Windows.Visibility.Collapsed;
            Competitions.Visibility = System.Windows.Visibility.Visible;
            ResultCompetitions.Visibility = System.Windows.Visibility.Visible;
            EditProfile.Visibility = System.Windows.Visibility.Visible;

            CommandsTrainer.Visibility = System.Windows.Visibility.Visible;
            CompetitionsAdmin.Visibility = System.Windows.Visibility.Collapsed;
            ResultCompetitionsAdmin.Visibility = System.Windows.Visibility.Collapsed;
        }

        public static void VisibleCollapsedAuthReg()
        {
            if (CurrentUser.user != null)
            {
                Authorization.Visibility = System.Windows.Visibility.Collapsed;
                Exit.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                Authorization.Visibility = System.Windows.Visibility.Visible;
                Exit.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
    }
}
