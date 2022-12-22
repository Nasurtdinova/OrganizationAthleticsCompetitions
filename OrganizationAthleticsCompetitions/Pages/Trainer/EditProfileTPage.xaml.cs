using BespokeFusion;
using Microsoft.Win32;
using OrganizationAthleticsCompetitions.DataBase;
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
    public partial class EditProfileTPage : Page
    {
        public EditProfileTPage()
        {
            InitializeComponent();           
            DataContext = CurrentUser.trainer;
        }

        private void btnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            if (DataAccess.GetUsers().Where(a => a.Login == tbPhone.Text).Count() == 0)
            {
                CurrentUser.trainer.User.Login = tbPhone.Text;
                CurrentUser.trainer.User.FullName = tbFullName.Text;
                Connection.connection.SaveChanges();
                MaterialMessageBox.Show("Информация сохранена");
            }
            else
            {
                MaterialMessageBox.ShowError("Такой логин уже существует!");
            }
        }

        private void btnEditPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;
                imgTrainer.Source = new BitmapImage(new Uri(path));
                CurrentUser.trainer.Image = File.ReadAllBytes(path);
            }
        }
    }
}
