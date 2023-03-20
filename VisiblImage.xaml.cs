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
    /// Логика взаимодействия для VisiblImage.xaml
    /// </summary>
    public partial class VisiblImage : Window
    {
        TestBDEntities context;

        public VisiblImage()
        {
            InitializeComponent();
            context = new TestBDEntities();
            ShowTable();
        }

        public void ShowTable()
        {
            List<TypeOfWood> listClient = context.TypeOfWoods.ToList();

            DataImage.ItemsSource = listClient.ToList();
        }

        private void BtnResurces_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
