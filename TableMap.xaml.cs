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

namespace AlbionMap
{
    /// <summary>
    /// Логика взаимодействия для TableMap.xaml
    /// </summary>
    public partial class TableMap : Page
    {
        DataAlbionMapEntities context;
        List<MainLocation> mainLocations;
        string currentLetter = "";

        public TableMap()
        {
            InitializeComponent();
            context = new DataAlbionMapEntities();
            ShowLetters();
            ShowTable();
        }
        public void ShowTable()
        {
            mainLocations = context.MainLocations.ToList();
            if (currentLetter.Count() == 1)
            {
                mainLocations = mainLocations.Where(x => x.Name.Contains(currentLetter)).ToList();
            }
            if (TxtNameLoc.Text != "")
            {
                mainLocations = mainLocations.Where(x => x.Name.Contains(TxtNameLoc.Text)).ToList();
            }
            DataTableMap.ItemsSource = mainLocations;
        }
        public void ShowLetters()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                TextBlock letter = new TextBlock
                {
                    Text = i.ToString(),
                    FontWeight = FontWeights.Black,
                    Foreground = Brushes.Black,
                    FontSize = 24,
                    Margin = new Thickness(15, 0, 0, 0)
                };
                letter.MouseLeftButtonDown += TextBlock_MouseLeftButtonDown;
                StackLetters.Children.Add(letter);
            }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var label = (TextBlock)sender;
            currentLetter = label.Text;
            foreach (TextBlock letter in StackLetters.Children)
            {
                letter.Foreground = Brushes.Black;
            }
            label.Foreground = Brushes.Gold;
            ShowTable();
        }
        private void TxtNameLoc_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowTable();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void BtnResurces_Click(object sender, RoutedEventArgs e)
        {
            Button f1 = sender as Button;
            var f2 = f1.DataContext as MainLocation;
            var f3 = new FormResurces(context, f2);
            f3.ShowDialog();
            ShowTable();
        }
    }
}
