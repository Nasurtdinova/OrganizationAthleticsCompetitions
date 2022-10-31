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
using BespokeFusion;
using OrganizationAthleticsCompetitions.DataBase;

namespace OrganizationAthleticsCompetitions
{
    public partial class SportsmansInCommandPage : Page
    {
        public SportsmansInCommandPage(Team team)
        {
            InitializeComponent();
            lvSportsmansInTeam.ItemsSource = DataAccess.GetSportsmansInTeam(team);
            lvTrainersInTeam.ItemsSource = DataAccess.GetTrainersInTeam(team);
            if (CurrentUser.user != null && CurrentUser.user.IdRole == 1)
                removeTrainer.Width = 250;
        }

        private void btnRemoveTrainer_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as Trainer_Team;
            a.IsActive = false;
            Connection.connection.SaveChanges();
            MaterialMessageBox.Show("Тренерство прекращено!");
        }
    }
}
