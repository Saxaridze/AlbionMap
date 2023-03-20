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
        TestBDEntities context;
        public FormResurces(TestBDEntities context1, MainLocation mainLocation)
        {
            InitializeComponent();

            this.context = context1;
            this.DataContext = mainLocation;            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string filter = TxtNameLoc.Text;
            List<LocationAndResource> mainloc = context.LocationAndResources.ToList();
            mainloc = mainloc.Where(x => x.MainLocation.Name.ToLower().Contains(filter.ToLower())).ToList();
            DataResurces.ItemsSource = mainloc;

            if (TxtEnchantment.Text == "")
            {
                TxtEnchantment.Text = "NULL";
                TxtProc.Visibility = Visibility.Collapsed;
            }
            else
            {
                TxtProc.Visibility = Visibility.Visible;
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
