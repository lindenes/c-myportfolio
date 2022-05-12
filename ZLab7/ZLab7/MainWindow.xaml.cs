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

namespace ZLab7
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

        private void PucToRight(object sender, RoutedEventArgs e)
        {
           Flag.Viewport = new Rect(0.75,0.75,0.25,0.25);
        }

        private void ChangeName(object sender, RoutedEventArgs e)
        {
            string CName = Convert.ToString(CountryName.Content);
            if(CName == "Флаг России")
            {
                CountryName.Content = "Флаг Британии";
            }
            else
            {
                CountryName.Content = "Флаг России";
            }
            
        }

        private void ColorChange(object sender, RoutedEventArgs e)
        {

            RecForm2.Fill = new SolidColorBrush(Color.FromRgb(0, 111, 111));
        }

        private void Mozaika(object sender, RoutedEventArgs e)
        {
            Flag.TileMode = TileMode.Tile;

        }

        private void ChangeFlagAndName(object sender, RoutedEventArgs e)
        {
            string CName = Convert.ToString(CountryName.Content);
            if (CName == "Флаг России")
            {
                Flag.ImageSource = new BitmapImage(new Uri("Resources/flags_PNG14579.png", UriKind.Relative));
                CountryName.Content = "Флаг Британии";
            }
            else
            {
                Flag.ImageSource = new BitmapImage(new Uri("Resources/Rf.jpg", UriKind.Relative));
                CountryName.Content = "Флаг России";
            }
            
        }
    }
}
