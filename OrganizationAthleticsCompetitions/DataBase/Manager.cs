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

        public static Button Sportsmans { get; set; }

        public static Button CommandsTrainer { get; set; }
        public static Button Commands { get; set; }

        public static Button Competitions { get; set; }

        public static Button ResultCompetitions { get; set; }

        public static StackPanel EditProfile { get; set; }

        public static void UpdatePanel()
        {
            if (CurrentUser.user != null)
            {
                if (CurrentUser.user.IdRole == 1)
                {
                    RoleNameLabel.Content = "Админ";
                    CommandsTrainer.Visibility = System.Windows.Visibility.Collapsed;
                    Commands.Visibility = System.Windows.Visibility.Visible;
                }
                else if (CurrentUser.user.IdRole == 2)
                {
                    RoleNameLabel.Content = "Тренер";
                    Commands.Visibility = System.Windows.Visibility.Collapsed;
                    CommandsTrainer.Visibility = System.Windows.Visibility.Visible;
                    EditProfile.Visibility = System.Windows.Visibility.Visible;
                }
                Authorization.Visibility = System.Windows.Visibility.Collapsed;
                Exit.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                RoleNameLabel.Content = "Зритель";
                Authorization.Visibility = System.Windows.Visibility.Visible;
                Exit.Visibility = System.Windows.Visibility.Collapsed;
                EditProfile.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
    }
}
