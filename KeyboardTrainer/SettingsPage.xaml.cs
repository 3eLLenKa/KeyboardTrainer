using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

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
            ColorSettings.SetViolettTheme();

            MessageBox.Show("Настройки применены!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Levels());
        }

        private void Lavanda_Click(object sender, RoutedEventArgs e)
        {
            ColorSettings.SetLavandaTheme();

            MessageBox.Show("Настройки применены!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Levels());
        }

        private void Wheat_Click(object sender, RoutedEventArgs e)
        {
            ColorSettings.SetWheatTheme();

            MessageBox.Show("Настройки применены!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Levels());
        }

        private void White_Click(object sender, RoutedEventArgs e)
        {
            ColorSettings.SetWhiteTheme();

            MessageBox.Show("Настройки применены!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Levels());
        }
    }
}