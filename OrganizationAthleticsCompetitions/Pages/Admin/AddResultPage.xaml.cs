using BespokeFusion;
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
    public partial class AddResultPage : Window
    {
        public ProgramCompetition ProgCompet = new ProgramCompetition();
        public AddResultPage(ProgramCompetition pr)
        {
            InitializeComponent();
            ProgCompet = pr;
            formatResult.Text = pr.TypeCompetition.FormatResult.Name;
            typeCompetition.Text = pr.TypeCompetition.Name;
            typeProgram.Text = pr.TypeProgram.Name;
            competitionName.Text = pr.Competition.Name;
            cbSportsman.ItemsSource = DataAccess.GetRequestsForProgramCompetition(pr).Select(a=>a.Sportsman);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (DataAccess.GetResultsInProgramCompetition(ProgCompet).Where(a => a.Request.Sportsman == cbSportsman.SelectedItem as Sportsman).Count() == 0)
            {
                if (String.IsNullOrEmpty(tbResult.Text) && cbSportsman.SelectedItem == null)
                    MaterialMessageBox.ShowError("Заполните данные!","Предупреждение!");
                else
                {
                    ResultCompetition res = new ResultCompetition()
                    {
                        Request = DataAccess.GetRequestSportsmanProgram((cbSportsman.SelectedItem as Sportsman).Id, ProgCompet.Id),
                        Result = Convert.ToDouble(tbResult.Text)
                    };
                    DataAccess.AddResult(res);
                    List<ResultCompetition> list = DataAccess.GetResultsInProgramCompetition(ProgCompet).OrderBy(a => a.Result).ToList();
                    List<ResultCompetition> listMetr = DataAccess.GetResultsInProgramCompetition(ProgCompet).OrderByDescending(a => a.Result).ToList();
                    int count = 1;
                    if (res.Request.ProgramCompetition.TypeCompetition.FormatResult.Name == "Метры и сантиметры")
                    {
                        for (int i = 0; i < listMetr.Count(); i++)
                        {
                            listMetr[i].Rank = count;
                            if (count == 1)
                                listMetr[i].Score = 10;
                            else if (count == 2)
                                listMetr[i].Score = 7;
                            else if (count == 3)
                                listMetr[i].Score = 5;
                            else
                                listMetr[i].Score = 2;
                            Connection.connection.SaveChanges();
                            count++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < list.Count(); i++)
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
                    }
                    Close();
                }
            }
            else
            {
                MaterialMessageBox.ShowError("Вы уже добавили результат этого спортсмена!");
            }
        }
    }
}
