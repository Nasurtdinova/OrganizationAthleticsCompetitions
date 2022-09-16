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

    public partial class RequestPage : Page
    {
        public RequestPage(ProgramCompetition prog)
        {
            InitializeComponent();
            comboSportsman.ItemsSource = DataAccess.GetSportmansInGenderAndTrainer(prog.Gender);
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
