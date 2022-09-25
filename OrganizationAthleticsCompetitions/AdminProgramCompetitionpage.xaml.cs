﻿using OrganizationAthleticsCompetitions.DataBase;
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

    public partial class AdminProgramCompetitionpage : Page
    {
        public AdminProgramCompetitionpage()
        {
            InitializeComponent();
            lvProgramsCompetition.ItemsSource = DataAccess.GetProgramsCompetition().Where(a => a.Competition.DateStart <= DateTime.Now);
        }

        private void btnAddResult_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as ProgramCompetition;
            Manager.MainFrame.NavigationService.Navigate(new AddResultPage(a));
        }
    }
}