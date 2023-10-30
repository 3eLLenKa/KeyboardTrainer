using System;
using System.Windows;
using System.Windows.Media;

namespace KeyboardTrainer
{
    /// <summary>
    /// Логика взаимодействия для ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public ResultWindow()
        {
            InitializeComponent();
            ChangeStyle();

            timeTxt.Text += MainPage.time.ToString(@"mm\:ss");
            speedTxt.Text += MainPage.typingSpeed.ToString() + " зн./сек.";
            keyboardTxt.Text += Levels.countLetters.ToString();
            targetTxt.Text += MainPage.target.ToString() + "%";
        }

        public static SolidColorBrush color = Brushes.Violet;
        public static SolidColorBrush background = Brushes.LightBlue;

        private void ChangeStyle()
        {
            border1.Background = color;
            this.Background = background;
        }
    }
}