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
    public partial class SponsorsPage : Page
    {
        public SponsorsPage()
        {
            InitializeComponent();
            sponsorsList.ItemsSource = DataAccess.GetSponsors();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            SendRequestSponsorWindow sendRequestSponsor = new SendRequestSponsorWindow((sender as Button).DataContext as Sponsor);
            sendRequestSponsor.Show();

        }
    }
}
