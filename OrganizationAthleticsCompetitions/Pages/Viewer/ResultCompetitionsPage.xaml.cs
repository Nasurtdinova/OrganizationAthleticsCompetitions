using ExcelDataReader;
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
using ExcelDataReader;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace OrganizationAthleticsCompetitions
{
    public partial class ResultCompetitionsPage : Page
    {
        public static IExcelDataReader edr;

        public ResultCompetitionsPage()
        {
            InitializeComponent();
            if (CurrentUser.user != null && CurrentUser.user.IdRole == 1)
                removeColumn.Width = 60;
            comboCompetitions.ItemsSource = DataAccess.GetCompetitions().Where(a=>a.DateStart <= DateTime.Now);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void comboCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Competition;
            if (a != null)
                dgRrogramsCompetitions.ItemsSource = DataAccess.GetProgramsInCompetition(a).Where(b=>b.Date <= DateTime.Now);
        }

        private void dgRrogramsCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as DataGrid).SelectedItem as ProgramCompetition;
            if (a != null)
            {
                if (CurrentUser.user != null && CurrentUser.user.IdRole == 1)
                    btnAddResult.Visibility = Visibility.Visible;
                dgResulsPrograms.ItemsSource = DataAccess.GetResultsInProgramCompetition(a).OrderBy(b=>b.Rank);
            }
        }

        private void btnRemoveResult_Click(object sender, RoutedEventArgs e)
        {
            var res = (sender as Button).DataContext as ResultCompetition;
            if (MessageBox.Show("Вы точно хотите удалить результат?", "Предупреждение", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                res.IsDeleted = true;
                Connection.connection.SaveChanges();
                dgResulsPrograms.ItemsSource = DataAccess.GetResultsInProgramCompetition(dgRrogramsCompetitions.SelectedItem as ProgramCompetition).OrderBy(b => b.Rank);
            }
        }

        private void btnAddResult_Click(object sender, RoutedEventArgs e)
        {            
            AddResultPage add = new AddResultPage(dgRrogramsCompetitions.SelectedItem as ProgramCompetition);
            add.Show();
            add.Closed += (s, eventarg) =>
            {
                dgResulsPrograms.ItemsSource = DataAccess.GetResultsInProgramCompetition(dgRrogramsCompetitions.SelectedItem as ProgramCompetition).OrderBy(b => b.Rank);
            };
        }

        private void btnLoadExcel_Click(object sender, RoutedEventArgs e)
        {
            if (dgRrogramsCompetitions.SelectedItem != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "EXCEL Files (*.xlsx)|*.xlsx|EXCEL Files 2013 (*.xls)|*.xls|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() != true)
                    return;
                ReadFile(openFileDialog.FileName);
                dgResulsPrograms.ItemsSource = DataAccess.GetResultsInProgramCompetition(dgRrogramsCompetitions.SelectedItem as ProgramCompetition).OrderBy(b => b.Rank);
            }
        }

        public void ReadFile(string fileNames)
        {
            var extension = fileNames.Substring(fileNames.LastIndexOf('.'));
            FileStream stream = File.Open(fileNames, FileMode.Open, FileAccess.Read);
            if (extension == ".xlsx")
                edr = ExcelReaderFactory.CreateOpenXmlReader(stream);
            else if (extension == ".xls")
                edr = ExcelReaderFactory.CreateBinaryReader(stream);
            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true }
            };
            DataSet dataSet = edr.AsDataSet(conf);
            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ResultCompetition res = new ResultCompetition()
                    {
                        Request = DataAccess.GetRequestSportsmanProgram((dr[0] as Sportsman).Id, (dgRrogramsCompetitions.SelectedItem as ProgramCompetition).Id),
                        Result = Convert.ToDouble(dr[1])
                    };
                    DataAccess.AddResult(res, dgRrogramsCompetitions.SelectedItem as ProgramCompetition);
                }
            }
            edr.Close();
        }
    }
}
