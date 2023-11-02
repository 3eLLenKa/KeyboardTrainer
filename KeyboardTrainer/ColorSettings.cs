using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media;

namespace KeyboardTrainer
{
    internal class ColorSettings
    {
        public static void SetViolettTheme()
        {
            MainPage.background = Brushes.LightBlue;
            MainPage.color = Brushes.Violet;

            Levels.background = Brushes.LightBlue;
            Levels.color = Brushes.Violet;

            ResultWindow.background = Brushes.LightBlue;
            ResultWindow.color = Brushes.Violet;

            File.WriteAllText(@"C:\KeyboardTrainer\settings.txt", "violett_theme");
        }

        public static void SetLavandaTheme()
        {
            MainPage.background = Brushes.Lavender;
            MainPage.color = Brushes.Pink;

            Levels.background = Brushes.Lavender;
            Levels.color = Brushes.Pink;

            ResultWindow.background = Brushes.Lavender;
            ResultWindow.color = Brushes.Pink;

            File.WriteAllText(@"C:\KeyboardTrainer\settings.txt", "lavanda_theme");
        }

        public static void SetWheatTheme()
        {
            MainPage.background = Brushes.Wheat;
            MainPage.color = Brushes.BlueViolet;

            Levels.background = Brushes.Wheat;
            Levels.color = Brushes.BlueViolet;

            ResultWindow.background = Brushes.Wheat;
            ResultWindow.color = Brushes.BlueViolet;

            File.WriteAllText(@"C:\KeyboardTrainer\settings.txt", "wheat_theme");
        }

        public static void SetWhiteTheme()
        {
            MainPage.background = Brushes.White;
            MainPage.color = Brushes.LightBlue;

            Levels.background = Brushes.White;
            Levels.color = Brushes.LightBlue;

            ResultWindow.background = Brushes.White;
            ResultWindow.color = Brushes.LightBlue;

            File.WriteAllText(@"C:\KeyboardTrainer\settings.txt", "white_theme");
        }
    }
}
