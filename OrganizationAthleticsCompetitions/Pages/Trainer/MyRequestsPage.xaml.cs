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
    public partial class MyRequestsPage : Page
    {
        public MyRequestsPage()
        {
            InitializeComponent();
            
            dgRequests.ItemsSource = GetList();
        }
        
        public List<Request> GetList()
        {
            List<Request> list = new List<Request>();
            foreach (var i in DataAccess.GetTeamsInTreaner(CurrentUser.trainer))
            {
                foreach (var j in DataAccess.GetRequests().Where(a => a.Sportsman.IdTeam == i.IdTeam && a.ProgramCompetition.Date > DateTime.Now))
                    list.Add(j);
            }
            return list;
        }

        private void btnRevoke_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as Request;
            Connection.connection.Request.Remove(a);
            Connection.connection.SaveChanges();
            MaterialMessageBox.Show("Участие отменено!","Уведомление!");
            dgRequests.ItemsSource = GetList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
