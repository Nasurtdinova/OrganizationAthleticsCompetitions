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
    public partial class AddResultPage : Page
    {
        public ProgramCompetition ProgCompet;
        public AddResultPage(ProgramCompetition pr)
        {
            InitializeComponent();
            ProgCompet = pr;
            cbSportsman.ItemsSource = DataAccess.GetSportsmans();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ResultCompetition res = new ResultCompetition()
            {
                Request = DataAccess.GetRequestSportsmanProgram((cbSportsman.SelectedItem as Sportsman).Id, ProgCompet.Id),
                Result = Convert.ToDouble(tbResult.Text)
            };
            DataAccess.AddResult(res);
            List<ResultCompetition> list = DataAccess.GetResultsInProgramCompetition(ProgCompet).OrderBy(a => a.Result).ToList();
            int count = 1;
            for (int i = 0; i< list.Count(); i++)
            {
                list[i].Rank = count;
                if (count == 1)
                    list[i].Score = 10;
                else if (count == 2)
                    list[i].Score = 7;
                else if (count == 3)
                    list[i].Score = 5;
                else
                    list[i].Score = 2;
                Connection.connection.SaveChanges();
                count++;
            }
            DataAccess.UpdateScoreTeam();
        }
    }
}
