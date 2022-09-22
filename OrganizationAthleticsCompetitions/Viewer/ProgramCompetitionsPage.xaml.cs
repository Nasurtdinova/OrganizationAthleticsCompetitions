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
    public partial class ProgramCompetitionsPage : Page
    {
        public ProgramCompetitionsPage(Competition com)
        {
            InitializeComponent();
            if (com.DateStart > DateTime.Now)
                columnResult.Width = 0;
            else
                columnRequest.Width = 0;
            if (CurrentUser.user == null)
                columnRequest.Width = 0;
            lvProgramsCompetition.ItemsSource = DataAccess.GetProgramsInCompetition(com);
        }

        private void btnRequest_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as ProgramCompetition;
            if (a.CountAttendees == a.MaxCountAttendees)
                MessageBox.Show("Мест нет!");
            else
                Manager.MainFrame.NavigationService.Navigate(new RequestPage(a));
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as ProgramCompetition;
            Manager.MainFrame.NavigationService.Navigate(new ResultProgramCompetitionsPage(a));
        }
    }
}
