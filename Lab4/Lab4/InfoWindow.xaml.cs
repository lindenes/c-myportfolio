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
    /// Логика взаимодействия для InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
            string Text = @"D:\developing\c# шарага\Lab4\Lab4\bin\Debug\netcoreapp3.1\ReadMe.txt";
            StreamReader file = new StreamReader(Text);
            InfoBox.Text = file.ReadToEnd();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
