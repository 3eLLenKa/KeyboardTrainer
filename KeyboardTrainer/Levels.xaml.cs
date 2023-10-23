﻿using System;
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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace KeyboardTrainer
{
    /// <summary>
    /// Логика взаимодействия для Levels.xaml
    /// </summary>
    public partial class Levels : Page
    {
        public Levels()
        {
            InitializeComponent();
            ChangeStyle();
        }

        public static int countRows;
        public static int countLetters;

        public static SolidColorBrush color = Brushes.Violet;
        public static SolidColorBrush background = Brushes.LightBlue;

        private void ChangeStyle()
        {
            first.Background = color;
            second.Background = color;
            third.Background = color;

            this.Background = background;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            countRows = File.ReadAllLines("D:\\first_lvl.txt").Length;
            countLetters = File.ReadAllText("D:\\first_lvl.txt").Length;

            StreamReader reader = new StreamReader("D:\\first_lvl.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            countRows = File.ReadAllLines(@"D:\second_lvl.txt").Length;
            countLetters = File.ReadAllText(@"D:\second_lvl.txt").Length;

            StreamReader reader = new StreamReader(@"D:\second_lvl.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            countRows = File.ReadAllLines(@"D:\third_lvl.txt").Length;
            countLetters = File.ReadAllText(@"D:\third_lvl.txt").Length;

            StreamReader reader = new StreamReader(@"D:\third_lvl.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsPage());
        }
    }
}