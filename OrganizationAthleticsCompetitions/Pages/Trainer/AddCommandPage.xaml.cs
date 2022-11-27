using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OrganizationAthleticsCompetitions.DataBase;
using BespokeFusion;
using System.ComponentModel.DataAnnotations;

namespace OrganizationAthleticsCompetitions
{
    public partial class AddCommandPage : Page
    {
        public Team CurrentCommand = new Team();
        public AddCommandPage(Team selectedCommand)
        {
            InitializeComponent();
            if (selectedCommand != null)
            {
                CurrentCommand = selectedCommand;
                lvSportsmans.ItemsSource = DataAccess.GetSportsmansInTeam(selectedCommand);
                tabResults.Visibility = Visibility.Visible;
                lvResults.ItemsSource = DataAccess.GetResultsCompetition().Where(a => a.Request.Sportsman.Team == CurrentCommand);
            }

            DataContext = CurrentCommand;
            comboCities.ItemsSource = DataAccess.GetCities();
        }

        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;
                imgCom.Source = new BitmapImage(new Uri(path));
                CurrentCommand.Image = File.ReadAllBytes(path);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var sportsmans = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(CurrentCommand);

            if (!Validator.TryValidateObject(CurrentCommand, context, sportsmans, true))
                foreach (var error in sportsmans)
                    MaterialMessageBox.ShowError(error.ErrorMessage);
            else
            {
                DataAccess.SaveTeam(CurrentCommand);
                MaterialMessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new MyCommandPage());
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnAddSportsman_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentCommand.Id == 0)
                MaterialMessageBox.ShowError("Вы еще не добавили команду!");
            else
                NavigationService.Navigate(new SelectSportsmanWindow(CurrentCommand));
        }

        private void btnEditSportsman_Click(object sender, RoutedEventArgs e)
        {
            var i = (sender as Button).DataContext as Sportsman;
            AddEditSportsmanWindow add = new AddEditSportsmanWindow(i, CurrentCommand);
            add.Show();
            add.Closed += (s, eventarg) =>
            {
                lvSportsmans.ItemsSource = DataAccess.GetSportsmansInTeam(CurrentCommand);
            };
        }

        private void btnRemoveSportsman_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить спортсмена?", "Предупреждение", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                var i = (sender as Button).DataContext as Sportsman;
                i.IsDeleted = true;
                Connection.connection.SaveChanges();
                MaterialMessageBox.Show("Спортсмен успешно удален!");
            }
        }
    }
}
