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
    /// <summary>
    /// Логика взаимодействия для MyCommandPage.xaml
    /// </summary>
    public partial class MyCommandPage : Page
    {
        public MyCommandPage()
        {
            InitializeComponent();
            lvMyCommands.ItemsSource = DataAccess.GetTeamsInTreaner(CurrentUser.trainer);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var i = (sender as Button).DataContext as Trainer_Team;
            Manager.MainFrame.NavigationService.Navigate(new AddCommandPage(i.Team));
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите удалить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                DataAccess.RemoveTeam(((sender as Button).DataContext as Trainer_Team).IdTeam);
                lvMyCommands.ItemsSource = DataAccess.GetTeamsInTreaner(CurrentUser.trainer);
                MessageBox.Show("Данные удалены");
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.NavigationService.Navigate(new AddCommandPage(null));
        }
    }
}
