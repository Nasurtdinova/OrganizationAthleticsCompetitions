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
using System.Windows.Shapes;

namespace OrganizationAthleticsCompetitions
{
    public partial class AddEditCompetitionWindow : Window
    {
        public Competition CurrentCompetition = new Competition();
        public AddEditCompetitionWindow(Competition compet)
        {
            InitializeComponent();
            if (compet != null)
                CurrentCompetition = compet;
            Title = CurrentCompetition.Id == 0 ? "Добавление соревнования" : "Редактирование соревнования";
            DataContext = CurrentCompetition;
            comboCategory.ItemsSource = DataAccess.GetCategoryCompetitions();
            comboCity.ItemsSource = DataAccess.GetCities();
            comboVenue.ItemsSource = DataAccess.GetVenues();
            dgProgramsCompetitions.ItemsSource = DataAccess.GetProgramsInCompetition(CurrentCompetition);
        }
    }
}
