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
using System.Data;
using System.IO;
using Microsoft.Win32;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
namespace lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public class Db
        {
            public string name { get; set; }
            public string Code { get; set; }
            public string NumHouse { get; set; }
            public string Data { get; set; }
            public string Days { get; set; }
            public string riba1 { get; set; }
            public string riba2 { get; set; }
            public string riba3 { get; set; }
            public string riba4 { get; set; }
        }
        public class Db2
        {
            public string name { get; set; }
            public string Code { get; set; }
            public string NumHouse { get; set; }
            public string Data { get; set; }
            public string Days { get; set; }
            public double Ves { get; set; }
        }
        public class Db3
        {
            public string code { get; set; }
            public string family { get; set; }
            public string name { get; set; }
            public string fathername { get; set; }
            public string club { get; set; }
        }
        public class Db4
        {
  
            public string family { get; set; }
            public string name { get; set; }
            public string fathername { get; set; }
            public string club { get; set; }
        }
        public class Db5
        {
            public string name { get; set; }
            public string Code { get; set; }
            public string NumHouse { get; set; }
            public string Data { get; set; }
            public string Days { get; set; }
            public string Riba { get; set; }
        }

        public MainWindow()
        {

            InitializeComponent();
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            if (excelApp == null)
            {

                return;
            }

            Workbook excelBook = excelApp.Workbooks.Open(@"D:\developing\c# шарага\lab2\lab2\DB1.xlsx");
            _Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range excelRange = excelSheet.UsedRange;


            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;
            List<Db> parts = new List<Db>();
            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= 1; j++)
                {



                    parts.Add(new Db
                    {
                        name = (string)(excelRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Code = (string)(excelRange.Cells[i, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        NumHouse = (string)(excelRange.Cells[i, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Data = (string)(excelRange.Cells[i, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Days = (string)(excelRange.Cells[i, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba1 = (string)(excelRange.Cells[i, j + 5] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba2 = (string)(excelRange.Cells[i, j + 6] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba3 = (string)(excelRange.Cells[i, j + 7] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba4 = (string)(excelRange.Cells[i, j + 8] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()

                    });

                }


            }
            DataGrid.ItemsSource = parts;


        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            if (excelApp == null)
            {
               
                return;
            }

            Workbook excelBook = excelApp.Workbooks.Open(@"D:\developing\c# шарага\lab2\lab2\DB1.xlsx");
            _Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range excelRange = excelSheet.UsedRange;

           
            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;
            List<Db> parts = new List<Db>();
            List<Db2> parts2 = new List<Db2>();
            for (int i = 1; i <= rows; i++)
            {                
                
                for (int j = 1; j <= 1; j++)
                {

                    
                    
                    parts.Add(new Db { 
                        name = (string)(excelRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Code = (string)(excelRange.Cells[i, j+1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        NumHouse = (string)(excelRange.Cells[i, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Data = (string)(excelRange.Cells[i, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Days = (string)(excelRange.Cells[i, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba1 = (string)(excelRange.Cells[i, j + 5] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba2 = (string)(excelRange.Cells[i, j + 6] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba3 = (string)(excelRange.Cells[i, j + 7] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba4 = (string)(excelRange.Cells[i, j + 8] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()

                    } );

                }

                
            }
            string familia = TextBoxer.Text;
            int index = parts.FindIndex(a => a.name.Contains(familia));
            for (int i = 1; i <= 1; i++)
            {

                for (int j = 1; j <= 1; j++)
                {

                    double Vesa = (double)(excelRange.Cells[index + 1, j + 5] as Microsoft.Office.Interop.Excel.Range).Value2;
                    double Vesa2 = (double)(excelRange.Cells[index + 1, j + 6] as Microsoft.Office.Interop.Excel.Range).Value2;
                    double Vesa3 = (double)(excelRange.Cells[index + 1, j + 7] as Microsoft.Office.Interop.Excel.Range).Value2;
                    double Vesa4 = (double)(excelRange.Cells[index + 1, j + 8] as Microsoft.Office.Interop.Excel.Range).Value2;

                    parts2.Add(new Db2
                    {
                        name = (string)(excelRange.Cells[index+1, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Code = (string)(excelRange.Cells[index+1, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        NumHouse = (string)(excelRange.Cells[index+1, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Data = (string)(excelRange.Cells[index+1, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Days = (string)(excelRange.Cells[index+1, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Ves = Vesa+Vesa2+Vesa3+Vesa4,
                

                    });

                }


            }

            DataGrid.ItemsSource = parts2;

          

            //after reading, relaase the excel project
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            Console.ReadLine();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            if (excelApp == null)
            {

                return;
            }

            Workbook excelBook = excelApp.Workbooks.Open(@"D:\developing\c# шарага\lab2\lab2\DB3.xlsx");
            _Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range excelRange = excelSheet.UsedRange;


            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;
            List<Db3> parts = new List<Db3>();
            List<Db4> little = new List<Db4>();
            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= 1; j++)
                {

                    parts.Add(new Db3
                    {
                        code = (string)(excelRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        family = (string)(excelRange.Cells[i, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        name = (string)(excelRange.Cells[i, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        fathername = (string)(excelRange.Cells[i, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        club = (string)(excelRange.Cells[i, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()
                    });

                }
  

            }
            string familia = TextBoxer.Text;
            int index = parts.FindIndex(a => a.family.Contains(familia));

                for (int j = 1; j <= 1; j++)
                {

                    little.Add(new Db4
                    {
  
                        family = (string)(excelRange.Cells[index + 1, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        name = (string)(excelRange.Cells[index + 1, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        fathername = (string)(excelRange.Cells[index + 1, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        club = (string)(excelRange.Cells[index + 1, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()
                    });



                }



         
            DataGrid.ItemsSource = little;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            if (excelApp == null)
            {

                return;
            }

            Workbook excelBook = excelApp.Workbooks.Open(@"D:\developing\c# шарага\lab2\lab2\DB1.xlsx");
            _Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range excelRange = excelSheet.UsedRange;


            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;
            List<Db> parts = new List<Db>();
            List<Db5> parts2 = new List<Db5>();
            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= 1; j++)
                {



                    parts.Add(new Db
                    {
                        name = (string)(excelRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Code = (string)(excelRange.Cells[i, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        NumHouse = (string)(excelRange.Cells[i, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Data = (string)(excelRange.Cells[i, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        Days = (string)(excelRange.Cells[i, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba1 = (string)(excelRange.Cells[i, j + 5] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba2 = (string)(excelRange.Cells[i, j + 6] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba3 = (string)(excelRange.Cells[i, j + 7] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                        riba4 = (string)(excelRange.Cells[i, j + 8] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()

                    });

                }


            }
            string riba = TextBoxer.Text;
            if(riba == "Форель")
            {
                for (int i = 1; i <= rows; i++)
                {

                    for (int j = 1; j <= 1; j++)
                    {



                        parts2.Add(new Db5
                        {
                            name = (string)(excelRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Code = (string)(excelRange.Cells[i, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            NumHouse = (string)(excelRange.Cells[i, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Data = (string)(excelRange.Cells[i, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Days = (string)(excelRange.Cells[i, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Riba = (string)(excelRange.Cells[i, j + 5] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),


                        });

                    }


                }
            }
            if (riba == "Толстолобик")
            {
                for (int i = 1; i <= rows; i++)
                {

                    for (int j = 1; j <= 1; j++)
                    {



                        parts2.Add(new Db5
                        {
                            name = (string)(excelRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Code = (string)(excelRange.Cells[i, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            NumHouse = (string)(excelRange.Cells[i, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Data = (string)(excelRange.Cells[i, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Days = (string)(excelRange.Cells[i, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Riba = (string)(excelRange.Cells[i, j + 6] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),


                        });

                    }


                }
            }
            if (riba == "Карп")
            {
                for (int i = 1; i <= rows; i++)
                {

                    for (int j = 1; j <= 1; j++)
                    {



                        parts2.Add(new Db5
                        {
                            name = (string)(excelRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Code = (string)(excelRange.Cells[i, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            NumHouse = (string)(excelRange.Cells[i, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Data = (string)(excelRange.Cells[i, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Days = (string)(excelRange.Cells[i, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Riba = (string)(excelRange.Cells[i, j + 7] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),


                        });

                    }


                }
            }
            if (riba == "Карась")
            {
                for (int i = 1; i <= rows; i++)
                {

                    for (int j = 1; j <= 1; j++)
                    {



                        parts2.Add(new Db5
                        {
                            name = (string)(excelRange.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Code = (string)(excelRange.Cells[i, j + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            NumHouse = (string)(excelRange.Cells[i, j + 2] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Data = (string)(excelRange.Cells[i, j + 3] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Days = (string)(excelRange.Cells[i, j + 4] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),
                            Riba = (string)(excelRange.Cells[i, j + 8] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(),


                        });

                    }


                }
            }


            DataGrid.ItemsSource = parts2;
        }
    }
}
