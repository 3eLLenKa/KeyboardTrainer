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
using System.Windows.Shapes;

namespace KeyboardTrainer
{
    /// <summary>
    /// Логика взаимодействия для Levels.xaml
    /// </summary>
    public partial class Levels : Page
    {
        //public static string? temp;
        public Levels()
        {
            InitializeComponent();
        }

        public static int countRows = File.ReadAllLines("C:\\Users\\alexk\\OneDrive\\Рабочий стол\\first.txt").Length;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader("C:\\Users\\alexk\\OneDrive\\Рабочий стол\\first.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\alexk\OneDrive\Рабочий стол\second.txt");

            for (int i = 0; i < 7; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\alexk\OneDrive\Рабочий стол\third.txt");

            for (int i = 0; i < 7; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }
    }
}