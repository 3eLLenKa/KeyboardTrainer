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
        }

        public static int countRows;
        public static int countLetters;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            countRows = File.ReadAllLines("C:\\Users\\alexk\\OneDrive\\Рабочий стол\\first.txt").Length;
            countLetters = File.ReadAllText("C:\\Users\\alexk\\OneDrive\\Рабочий стол\\first.txt").Length;

            StreamReader reader = new StreamReader("C:\\Users\\alexk\\OneDrive\\Рабочий стол\\first.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            countRows = File.ReadAllLines(@"C:\Users\alexk\OneDrive\Рабочий стол\second.txt").Length;
            countLetters = File.ReadAllText(@"C:\Users\alexk\OneDrive\Рабочий стол\second.txt").Length;

            StreamReader reader = new StreamReader(@"C:\Users\alexk\OneDrive\Рабочий стол\second.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            countRows = File.ReadAllLines(@"C:\Users\alexk\OneDrive\Рабочий стол\third.txt").Length;
            countLetters = File.ReadAllText(@"C:\Users\alexk\OneDrive\Рабочий стол\third.txt").Length;

            StreamReader reader = new StreamReader(@"C:\Users\alexk\OneDrive\Рабочий стол\third.txt");

            for (int i = 0; i < countRows; i++)
            {
                MainPage.text.Add(reader.ReadLine());
            }

            reader.Close();

            NavigationService.Navigate(new MainPage());
        }
    }
}