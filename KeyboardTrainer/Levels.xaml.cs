using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

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
            countRows = File.ReadAllLines("C:\\KeyboardTrainer\\first_lvl.txt").Length;
            countLetters = File.ReadAllText("C:\\KeyboardTrainer\\first_lvl.txt").Length;

            StreamReader reader = new StreamReader("C:\\KeyboardTrainer\\first_lvl.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            countRows = File.ReadAllLines(@"C:\KeyboardTrainer\second_lvl.txt").Length;
            countLetters = File.ReadAllText(@"C:\KeyboardTrainer\second_lvl.txt").Length;

            StreamReader reader = new StreamReader(@"C:\KeyboardTrainer\second_lvl.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            countRows = File.ReadAllLines(@"C:\KeyboardTrainer\third_lvl.txt").Length;
            countLetters = File.ReadAllText(@"C:\KeyboardTrainer\third_lvl.txt").Length;

            StreamReader reader = new StreamReader(@"C:\KeyboardTrainer\third_lvl.txt");

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