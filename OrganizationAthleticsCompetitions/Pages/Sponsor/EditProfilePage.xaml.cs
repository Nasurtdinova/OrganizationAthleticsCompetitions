using BespokeFusion;
using Microsoft.Win32;
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
    /// <summary>
    /// Логика взаимодействия для EditProfilePage.xaml
    /// </summary>
    public partial class EditProfilePage : Page
    {
        public EditProfilePage()
        {
            InitializeComponent();
            DataContext = DataAccess.GetSponsors().Where(a => a.User == CurrentUser.user).FirstOrDefault();
        }

        private void btnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser.user.Login = tbPhone.Text;
            CurrentUser.user.FullName = tbFullName.Text;
            Connection.connection.SaveChanges();
            MaterialMessageBox.Show("Информация сохранена");
        }

        private void btnEditPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;
                imgTrainer.Source = new BitmapImage(new Uri(path));
                DataAccess.GetSponsors().Where(a => a.User == CurrentUser.user).FirstOrDefault().Image = File.ReadAllBytes(path);
            }
        }
    }
}
