using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
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
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();

            this.Background = MainPage.background;
        }

        private void Violett_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.LightBlue;

            MainPage.background = Brushes.LightBlue;
            MainPage.color = Brushes.Violet;

            Levels.background = Brushes.LightBlue;
            Levels.color = Brushes.Violet;

            ResultWindow.background = Brushes.LightBlue;
            ResultWindow.color = Brushes.Violet;

            MessageBox.Show("Настройки применены!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Levels());
        }

        private void Lavanda_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Lavender;

            MainPage.background = Brushes.Lavender;
            MainPage.color = Brushes.Pink;

            Levels.background = Brushes.Lavender;
            Levels.color = Brushes.Pink;

            ResultWindow.background = Brushes.Lavender;
            ResultWindow.color = Brushes.Pink;

            MessageBox.Show("Настройки применены!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Levels());
        }

        private void Wheat_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Wheat;

            MainPage.background = Brushes.Wheat;
            MainPage.color = Brushes.BlueViolet;

            Levels.background = Brushes.Wheat;
            Levels.color = Brushes.BlueViolet;

            ResultWindow.background = Brushes.Wheat;
            ResultWindow.color = Brushes.BlueViolet;

            MessageBox.Show("Настройки применены!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Levels());
        }

        private void White_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.White;

            MainPage.background = Brushes.White;
            MainPage.color = Brushes.LightBlue;

            Levels.background = Brushes.White;
            Levels.color = Brushes.LightBlue;

            ResultWindow.background = Brushes.White;
            ResultWindow.color = Brushes.LightBlue;

            MessageBox.Show("Настройки применены!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Levels());
        }
    }
}