using BespokeFusion;
using Microsoft.Win32;
using OrganizationAthleticsCompetitions.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
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
    public partial class AddEditSportsmanWindow : Window
    {
        public Sportsman CurrentSportsman = new Sportsman();
        public AddEditSportsmanWindow(Sportsman sports, Team team)
        {
            InitializeComponent();

            if (sports != null)
                CurrentSportsman = sports;

            Title = CurrentSportsman.Id != 0 ? "Редактирование спортсмена" : "Добавление спортсмена в команду";

            comboCity.ItemsSource = DataAccess.GetCities();
            comboCategory.ItemsSource = DataAccess.GetCategorySportsmans();
            comboGender.ItemsSource = DataAccess.GetGenders();
            DataContext = CurrentSportsman;
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;
                imgSportsman.Source = new BitmapImage(new Uri(path));
                CurrentSportsman.Image = File.ReadAllBytes(path);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var sportsmans = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(CurrentSportsman);

            if (!Validator.TryValidateObject(CurrentSportsman, context, sportsmans, true))
                foreach (var error in sportsmans)
                    MaterialMessageBox.ShowError(error.ErrorMessage);
            else
            {
                DataAccess.SaveSportsman(CurrentSportsman);
                MaterialMessageBox.Show("Информация сохранена!");
                Close();
            }
        }
    }
}
