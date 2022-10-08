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
            if (CurrentUser.trainer.Image == null)
                imgTrainer.Source = new BitmapImage(new Uri("C:/Users/nasur/Source/Repos/Final_Project_ASP_MVC_Clone/RunningCompetitionWPF/Icons/PhotoProfile.png"));
            else
            {
                var stream = new MemoryStream(CurrentUser.trainer.Image);
                stream.Seek(0, SeekOrigin.Begin);
                var image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = stream;
                image.EndInit();
                imgTrainer.Source = image;
            }
            DataContext = CurrentUser.trainer;
        }

        private void btnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser.trainer.User.Login = tbPhone.Text;
            CurrentUser.trainer.User.FullName = tbFullName.Text;
            Connection.connection.SaveChanges();
            MessageBox.Show("Информация сохранена");
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
