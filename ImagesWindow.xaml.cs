﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
    /// Логика взаимодействия для ImagesWindow.xaml
    /// </summary>
    public partial class ImagesWindow : Window
    {
        private const int imagesPerRow = 4;
        public string ImgUri { get; private set; }

        public ImagesWindow()
        {
            InitializeComponent();
            ShowImages();
        }

        private string[] GetImages()
        {
            var files = Directory.GetFiles("../../Image");
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Remove(0, 5);
            }
            return files;
        }

        private void ShowImages()
        {
            var files = GetImages();
            var column = new StackPanel
            {
                Orientation = Orientation.Vertical,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            for (int i = 0; i <= files.Length / imagesPerRow; i++)
            {
                var row = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                for (int j = i * imagesPerRow; j < (i * imagesPerRow) + imagesPerRow; j++)
                {
                    if (j >= files.Length)
                    {
                        break;
                    }
                    var image = new Image
                    {
                        Source = new BitmapImage(new Uri(files[j], UriKind.Relative)),
                        Height = 70,
                        Tag = files[j],
                        Cursor = Cursors.Hand
                    };
                    image.MouseLeftButtonDown += Image_MouseLeftButtonDown;
                    row.Children.Add(image);
                }
                column.Children.Add(row);
            }
            gridImages.Children.Add(column);
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ImgUri = (sender as Image).Tag.ToString();
            DialogResult = true;
            Close();
        }
    }
}