using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace OrganizationAthleticsCompetitions
{
    public partial class ReportPage : System.Windows.Controls.Page
    {
        public Competition SelectCompetition { get; set; }
        public TypeCompetition SelectTypeCompetition { get; set; }
        public ReportPage()
        {
            InitializeComponent();
            comboCompetitions.ItemsSource = DataAccess.GetCompetitions();
            comboTypeCompetitions.ItemsSource = DataAccess.GetTypesCompetitions();
        }

        public static void ExportExcel(Competition com, TypeCompetition type)
        {
            var allTypePrograms = new List<TypeProgram>();
            foreach (var i in DataAccess.GetProgramsCompetition().Where(a => a.Competition == com && a.TypeCompetition == type))
            {
                allTypePrograms.Add(i.TypeProgram);
            } 

            Excel.Application application = new Excel.Application();
            application.SheetsInNewWorkbook = allTypePrograms.Distinct().Count();

            Workbook workbook = application.Workbooks.Add(Type.Missing);

            int startRowIndex = 1;

            for (int i = 0; i < allTypePrograms.Distinct().Count(); i++)
            {
                Worksheet worksheet = application.Worksheets.Item[i + 1];
                worksheet.Name = allTypePrograms[i].Name;
                worksheet.Cells[1][startRowIndex] = "Соревнование";
                worksheet.Cells[2][startRowIndex] = com.Name;
                worksheet.Cells[1][startRowIndex+1] = "Тип программы";
                worksheet.Cells[2][startRowIndex+1] = type.Name;
                worksheet.Cells[1][startRowIndex + 2] = "Формат результатов";
                worksheet.Cells[2][startRowIndex + 2] = type.FormatResult.Name;
                startRowIndex = 5;

                worksheet.Cells[1][startRowIndex] = "ФИО";
                worksheet.Cells[2][startRowIndex] = "Результат";
                worksheet.Cells[3][startRowIndex] = "Место";
                startRowIndex++;
                ProgramCompetition prog = DataAccess.GetProgramsCompetition().Where(a => a.Competition == com && a.TypeCompetition == type && a.TypeProgram == allTypePrograms[i]).FirstOrDefault();
                var results = DataAccess.GetResultsInProgramCompetition(prog);
                foreach (var result in results)
                {
                    worksheet.Cells[1][startRowIndex] = result.Request.Sportsman.FullName;
                    worksheet.Cells[2][startRowIndex] = result.Result;
                    worksheet.Cells[3][startRowIndex] = result.Rank;
 
                    startRowIndex++;
                }
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
                startRowIndex = 1;
            }
            application.Visible = true;
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            ExportExcel(SelectCompetition, SelectTypeCompetition);
        }

        private void comboCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectCompetition = (sender as ComboBox).SelectedItem as Competition;
            List<TypeCompetition> list = new List<TypeCompetition>();
            foreach(var i in DataAccess.GetProgramsCompetition().Where(a => a.Competition == SelectCompetition))
            {
                list.Add(i.TypeCompetition);
            }
            comboTypeCompetitions.ItemsSource = list.Distinct();
        }

        private void comboTypeCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectTypeCompetition = (sender as ComboBox).SelectedItem as TypeCompetition;
        }
    }
}
