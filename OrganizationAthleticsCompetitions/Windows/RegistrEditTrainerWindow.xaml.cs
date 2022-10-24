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
using System.Windows.Shapes;

namespace OrganizationAthleticsCompetitions
{
    /// <summary>
    /// Логика взаимодействия для RegistrEditTrainerWindow.xaml
    /// </summary>
    public partial class RegistrEditTrainerWindow : Window
    {
        public Trainer CurrentTrainer = new Trainer();

        public RegistrEditTrainerWindow(Trainer trainer)
        {
            InitializeComponent();
            if (trainer != null)
            {
                CurrentTrainer = trainer;
                password.Password = CurrentTrainer.User.Password;
                confirmPassword.Password = CurrentTrainer.User.Password;
            }
            Title = CurrentTrainer.Id == 0 ? "Добавление тренера" : "Редактирование тренера";
            DataContext = CurrentTrainer;
        }

        private void editImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == true)
            {
                string path = file.FileName;
                CurrentTrainer.Image = File.ReadAllBytes(path);
                imgTrainer.Source = new BitmapImage(new Uri(path));
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (password.Password == confirmPassword.Password)
            {
                User user = new User()
                {
                    FullName = tbFullName.Text,
                    DayOfBirth = dpDayOfBirth.SelectedDate,
                    Login = tbLogin.Text,
                    Password = password.Password,
                    IdRole = 2
                };
                DataAccess.SaveTrainer(CurrentTrainer, user);
                MaterialMessageBox.Show("Информация сохранена!");
                Close();
            }
            else
                MaterialMessageBox.ShowError("Пароли не совпадают!");
        }
    }
}
