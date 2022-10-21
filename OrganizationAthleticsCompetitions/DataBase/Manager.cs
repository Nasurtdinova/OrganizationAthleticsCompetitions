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
        public static Label RoleNameLabel { get; set; }

        public static StackPanel Authorization { get; set; }
        public static StackPanel Exit { get; set; }

        public static ListViewItem Sportsmans { get; set; }

        public static ListViewItem Trainers { get; set; }

        public static ListViewItem CommandsTrainer { get; set; }
        public static ListViewItem Commands { get; set; }

        public static ListViewItem Competitions { get; set; }

        public static ListViewItem ResultCompetitions { get; set; }

        public static StackPanel EditProfile { get; set; }

        public static void UpdatePanel()
        {
            if (CurrentUser.user != null)
            {
                if (CurrentUser.user.IdRole == 1)
                {
                    //RoleNameLabel.Content = "Админ";
                    CommandsTrainer.Visibility = System.Windows.Visibility.Collapsed;
                    Commands.Visibility = System.Windows.Visibility.Visible;
                    Trainers.Visibility = System.Windows.Visibility.Visible;
                    CommandsTrainer.Visibility = System.Windows.Visibility.Collapsed;
                }
                else if (CurrentUser.user.IdRole == 2)
                {
                    //RoleNameLabel.Content = "Тренер";
                    Commands.Visibility = System.Windows.Visibility.Collapsed;
                    CommandsTrainer.Visibility = System.Windows.Visibility.Visible;
                    EditProfile.Visibility = System.Windows.Visibility.Visible;
                    Trainers.Visibility = System.Windows.Visibility.Collapsed;
                }
                Authorization.Visibility = System.Windows.Visibility.Collapsed;
                Exit.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                //RoleNameLabel.Content = "Зритель";
                CommandsTrainer.Visibility = System.Windows.Visibility.Collapsed;
                Authorization.Visibility = System.Windows.Visibility.Visible;
                Exit.Visibility = System.Windows.Visibility.Collapsed;
                EditProfile.Visibility = System.Windows.Visibility.Collapsed;
                Trainers.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
    }
}
