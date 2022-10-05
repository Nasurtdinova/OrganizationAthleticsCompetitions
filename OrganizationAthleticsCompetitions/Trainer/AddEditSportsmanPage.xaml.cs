using Microsoft.Win32;
using OrganizationAthleticsCompetitions.DataBase;
using System;
using System.Collections.Generic;
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
    public partial class AddEditSportsmanPage : Page
    {
        public Sportsman CurrentSportsman { get; set; }
        public AddEditSportsmanPage(Sportsman sports)
        {
            InitializeComponent();

            if (sports != null)
            {
                CurrentSportsman = sports;
            }
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
                CurrentUser.trainer.Image = File.ReadAllBytes(path);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentSportsman.Id == 0)
                AddEditSportsman.AddingSportsman = CurrentSportsman;
            else
                AddEditSportsman.EditingSportsman = CurrentSportsman;
        }
    }
}
