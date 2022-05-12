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

namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                InfoWindow taskWindow = new InfoWindow();
                taskWindow.Show();

            }
        }



        private void Create(object sender, RoutedEventArgs e)
        {
            try
            {
                string selected = ListBox1.SelectedItem.ToString();
                DirectoryInfo dirInfo = new DirectoryInfo(selected);

                FileName taskWindow = new FileName();
                taskWindow.selected = selected;

                taskWindow.Show();
            }
            catch
            {
                string selected = ListBox2.SelectedItem.ToString();
                DirectoryInfo dirInfo = new DirectoryInfo(selected);

                FileName taskWindow = new FileName();
                taskWindow.selected = selected;

                taskWindow.Show();
            }
           
       
            
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
           

            try
            {
                string selected = ListBox1.SelectedItem.ToString();
                DirectoryInfo dirInfo = new DirectoryInfo(selected);
                dirInfo.Delete(true);
            }
            catch(NullReferenceException)
            {
                string selected = ListBox2.SelectedItem.ToString();
                DirectoryInfo dirInfo = new DirectoryInfo(selected);
                dirInfo.Delete(true);
            }
            
        }

        private void CopyTo(object sender, RoutedEventArgs e)
        {
            string selected = ListBox1.SelectedItem.ToString();    
            string path = "Test2";
            FileInfo dirInfo = new FileInfo(path);
            dirInfo.CopyTo(selected, true);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            string firstDirName = "Test";
            string secondDirName = "Test2";
            string[] dirs = Directory.GetDirectories(firstDirName);
            string[] dirs2 = Directory.GetDirectories(secondDirName);
            string[] files = Directory.GetFiles(firstDirName);
            string[] files2 = Directory.GetFiles(secondDirName);
            for (int i = 0; i < dirs.Length; i++)
            {

                ListBox1.Items.Add(dirs[i]);

            }
            for (int v = 0; v < files.Length; v++)
            {
                ListBox1.Items.Add(files[v]);
            }
            for (int i = 0; i < dirs2.Length; i++)
            {
                ListBox2.Items.Add(dirs2[i]);

            }
            for (int v = 0; v < files2.Length; v++)
            {
                ListBox2.Items.Add(files2[v]);
            }
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            try
            {
                string selected = ListBox1.SelectedItem.ToString();
                DirectoryInfo dirInfo = new DirectoryInfo(selected);
                
                label1.Content = dirInfo.FullName;
                TextBoxFileInfo.Text = $"Название каталога: {dirInfo.Name} Полное название каталога: {dirInfo.FullName} Время создания каталога: {dirInfo.CreationTime} Корневой каталог: {dirInfo.Root}";
            }
            catch
            {
                string selected = ListBox2.SelectedItem.ToString();
                DirectoryInfo dirInfo = new DirectoryInfo(selected);
                label2.Content = dirInfo.FullName;
                TextBoxFileInfo.Text = $"Название каталога: {dirInfo.Name} Полное название каталога: {dirInfo.FullName} Время создания каталога: {dirInfo.CreationTime} Корневой каталог: {dirInfo.Root}";
            }

        }

        private void Open(object sender, RoutedEventArgs e)
        {
            try
            {
                string selected = ListBox1.SelectedItem.ToString();
               
                string[] dirs = Directory.GetDirectories(selected);
                ListBox1.Items.Clear();
                for (int i = 0; i < dirs.Length; i++)
                {

                    ListBox1.Items.Add(dirs[i]);

                }
            }
            catch
            {
                string selected = ListBox2.SelectedItem.ToString();
                string[] dirs = Directory.GetDirectories(selected);
                ListBox2.Items.Clear();
                for (int i = 0; i < dirs.Length; i++)
                {

                    ListBox2.Items.Add(dirs[i]);

                }
            }
        }
    }
}
