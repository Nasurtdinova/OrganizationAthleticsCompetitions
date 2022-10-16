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
using OrganizationAthleticsCompetitions.DataBase;

namespace OrganizationAthleticsCompetitions
{
    public partial class CompetitionsPage : Page
    {
        public static List<Competition> infoPastCompet { get; set; }
        public static List<Competition> infoFutureCompet { get; set; }

        public CompetitionsPage()
        {
            InitializeComponent();
            var city = DataAccess.GetCities();
            city.Insert(0, new City { Name = "Все" });
            comboCity.ItemsSource = city;
            comboCity.SelectedIndex = 0;

            dgFutureCompetitions.ItemsSource = DataAccess.GetCompetitions().Where(a=>a.DateStart>DateTime.Now);
            dgPastCompetitions.ItemsSource = DataAccess.GetCompetitions().Where(a => a.DateStart <= DateTime.Now);
        }

        private void UpdateCompetitions()
        {
            infoPastCompet = DataAccess.GetCompetitions().Where(a => a.DateStart <= DateTime.Now).ToList();
            infoFutureCompet = DataAccess.GetCompetitions().Where(a => a.DateStart > DateTime.Now).ToList();

            if (checkMonth.IsChecked == true)
            {
                infoPastCompet = infoPastCompet.Where(a => a.DateStart.Value.Month == DateTime.Today.Month).ToList();
                infoFutureCompet = infoFutureCompet.Where(a => a.DateStart.Value.Month == DateTime.Today.Month).ToList();
            }

            if (comboCity.SelectedIndex > 0)
            {
                infoPastCompet = infoPastCompet.Where(p => p.Venue.IdCity == (comboCity.SelectedItem as City).Id).ToList();
                infoFutureCompet = infoFutureCompet.Where(p => p.Venue.IdCity == (comboCity.SelectedItem as City).Id).ToList();
            }

            infoPastCompet = infoPastCompet.Where(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            infoFutureCompet = infoFutureCompet.Where(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();

            dgPastCompetitions.ItemsSource = infoPastCompet;
            dgFutureCompetitions.ItemsSource = infoFutureCompet;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCompetitions();
        }

        private void checkMonth_Click(object sender, RoutedEventArgs e)
        {
            UpdateCompetitions();
        }

        private void btnProgram_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as Competition;
            if (a != null)
                NavigationService.Navigate(new ProgramCompetitionsPage(a));
        }

        private void comboCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCompetitions();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as Competition;
            if (a != null)
                NavigationService.Navigate(new ProgramCompetitionsPage(a));
        }
    }
}
