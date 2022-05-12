using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab4
{
    /// <summary>
    /// Логика взаимодействия для FileName.xaml
    /// </summary>
    public partial class FileName : Window
    {
        public string selected { get; set; }
        public string selected2 { get; set; }

        public FileName()
        {
            InitializeComponent();
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string fileName = textBoxFileName.Text;
            MainWindow MainWindow = new MainWindow();
            string fullpath = $@"{selected}\{fileName}";
          //  string fullpath2 = fileName + selected2;
            DirectoryInfo dirInfo = new DirectoryInfo(fullpath);
            dirInfo.Create();
            this.Close();
        }
        
    }
}
