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

namespace AlbionMap
{
    /// <summary>
    /// Логика взаимодействия для FormResurces.xaml
    /// </summary>
    public partial class FormResurces : Window
    {
        DataAlbionMapEntities context;
        List<MainLocation> mainLocations;

        public FormResurces(DataAlbionMapEntities context1, MainLocation mainLocation)
        {
            this.InitializeComponent();
            context = new DataAlbionMapEntities();
            this.context = context1;
            this.DataContext = mainLocation;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainLocations = context.MainLocations.ToList();
            if (TxtEnchantment.Text == "")
            {
                TxtEnchantment.Text = "NULL";
                TxtProc.Visibility = Visibility.Collapsed;
            }
            else
            {
                TxtProc.Visibility = Visibility.Visible;
            }

            if (TxtTypeRegeon.Text == "Безопасный регион - сражения запрещены")
            {
                Uri uri = new Uri("C:/Users/Home/Desktop/AlbionMap/Image/TypeRegion/Safe region.png", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                ImageRegion.Source = imgSource;
            }
            else if (TxtTypeRegeon.Text == "Желтый регион")
            {
                Uri uri = new Uri("C:/Users/Home/Desktop/AlbionMap/Image/TypeRegion/Yellow region.png", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                ImageRegion.Source = imgSource;
            }
            else if (TxtTypeRegeon.Text == "Красный регион")
            {
                Uri uri = new Uri("C:/Users/Home/Desktop/AlbionMap/Image/TypeRegion/Red Region.png", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                ImageRegion.Source = imgSource;
            }
            else if (TxtTypeRegeon.Text == "Черный регион")
            {
                Uri uri = new Uri("C:/Users/Home/Desktop/AlbionMap/Image/TypeRegion/Black Region.png", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                ImageRegion.Source = imgSource;
            }

            if (TxtNameLoc.Text == "Thetford")
            {
                Uri uri = new Uri("C:/Users/Home/Desktop/AlbionMap/Image/IconLoc/Thetford_1.jpg", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                ImageLoc.Source = imgSource;
            }
        }
    }
}
