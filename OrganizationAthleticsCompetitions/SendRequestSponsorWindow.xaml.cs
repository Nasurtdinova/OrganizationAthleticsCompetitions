using BespokeFusion;
using OrganizationAthleticsCompetitions.DataBase;
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
    public partial class SendRequestSponsorWindow : Window
    {
        public Sponsor SelectedSponsor = new Sponsor();
        public SendRequestSponsorWindow(Sponsor spon)
        {
            InitializeComponent();
            SelectedSponsor = spon;
            comboTeam.ItemsSource = DataAccess.GetTeamsInTreaner(CurrentUser.trainer);
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            var a = DataAccess.GetSponsorTeams().Where(b => b.Team == comboTeam.SelectedItem as Team && b.Sponsor == SelectedSponsor).FirstOrDefault();
            if (a != null && a.IdStatus == 1)
                MaterialMessageBox.ShowError("Вы уже отправляли заявку!Ожидайте!");
            else if (a != null && a.IdStatus == 3)
                MaterialMessageBox.ShowError("Это уже спонсор этой команды!");
            else
            {
                SponsorTeam sponTeam = new SponsorTeam()
                {
                    Sponsor = SelectedSponsor,
                    Team = comboTeam.SelectedItem as Team,
                    IdStatus = 1
                };
                DataAccess.SaveSponsorTeam(sponTeam);
                MaterialMessageBox.Show("Ваша заявка отправлена!");
            }
        }
    }
}
