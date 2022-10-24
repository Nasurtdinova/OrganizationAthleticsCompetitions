﻿using Microsoft.Win32;
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
            DataAccess.SaveTeam(CurrentCommand);
            MaterialMessageBox.Show("Информация сохранена");
            NavigationService.Navigate(new MyCommandPage());
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
            AddEditSportsmanPage add = new AddEditSportsmanPage(i, CurrentCommand);
            add.Show();
            add.Closed += (s, eventarg) =>
            {
                lvSportsmans.ItemsSource = DataAccess.GetSportsmansInTeam(CurrentCommand);
            };
        }
    }
}
