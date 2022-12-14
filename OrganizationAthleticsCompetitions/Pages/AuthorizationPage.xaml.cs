using BespokeFusion;
using Microsoft.Win32;
using OrganizationAthleticsCompetitions.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public partial class AuthorizationPage : Page
    {
        public User RegistredSponsor = new User();
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (DataAccess.IsCorrectUser(tbLogin.Text, tbPassword.Password))
            {
                Manager.UpdatePanel();
                NavigationService.Navigate(new MainPage());
            }
            else
                MaterialMessageBox.Show("Incorrect login or password");
        }

        private void editImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == true)
            {
                string path = file.FileName;
                //RegistredSponsor.Image = File.ReadAllBytes(path);
                imgTSponsor.Source = new BitmapImage(new Uri(path));
            }
        }

        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            if (DataAccess.GetUsers().Where(a => a.Login == tbLogin.Text).Count() == 0)
            {
                if (passwordRegistr.Password == confirmPassword.Password)
                {
                    User user = new User()
                    {
                        FullName = tbFullName.Text,
                        DayOfBirth = dpDayOfBirth.SelectedDate,
                        Login = tbLogin.Text,
                        Password = passwordRegistr.Password,
                        IdRole = 2
                    };
                    var sportsmans = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                    var context = new ValidationContext(user);

                    if (!Validator.TryValidateObject(user, context, sportsmans, true))
                        foreach (var error in sportsmans)
                            MaterialMessageBox.ShowError(error.ErrorMessage);
                    else
                    {
                        //DataAccess.SaveTrainer(RegistredSponsor, user);
                        MaterialMessageBox.Show("Информация сохранена!");
                    }
                }
                else
                    MaterialMessageBox.ShowError("Пароли не совпадают!");
            }
            else
                MaterialMessageBox.ShowError("Такой логин уже существует!");
        }
    }
}
