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
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (DataAccess.IsCorrectUser(tbLogin.Text, tbPassword.Password) == 1)
            {
                Manager.UpdatePanel();
            }
            else if (DataAccess.IsCorrectUser(tbLogin.Text, tbPassword.Password) == 2)
            {
                Manager.UpdatePanel();
            }
            else
            {
                MessageBox.Show("Incorrect login or password");
            }
        }
    }
}
