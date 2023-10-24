using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Timers;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KeyboardTrainer
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static List<string> text = new List<string>();
        public static TimeSpan time;

        public static double target;
        public static double typingSpeed = 0.0;

        public static SolidColorBrush color = Brushes.Violet;
        public static SolidColorBrush background = Brushes.LightBlue;

        private Stopwatch typingTimer = new Stopwatch();

        private Timer timer = new Timer(1000);

        private int typedCharacters = 0;
        private int current = 0;
        private int currentRow = 0;
        private int seconds = 0;

        private double countCorrect = 0.0;
        private double countClicks = 0.0;

        private char[] cyrillicChars = { 'ф', 'и', 'с', 'в', 'у', 'а', 'п', 'р', 'ш', 'о', 'л', 'д', 'ь', 'т', 'щ', 'з', 'й', 'к', 'ы', 'е', 'г', 'м', 'ц', 'ч', 'н', 'я' };
        public MainPage()
        {
            InitializeComponent();
            ChangeStyle();

            MainWindow.window.Title = "Тренировка";

            progressBar.Maximum = Levels.countLetters > 1 ? Levels.countLetters - (2 * Levels.countRows - 2) : Levels.countLetters;

            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            textBox1.Text = text[currentRow];
            textBox1.Focus();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            seconds++;
            time = TimeSpan.FromSeconds(seconds);
            Dispatcher.Invoke(() => timerTxtBlock.Text = "Время: " + time.ToString(@"mm\:ss"));
        }

        private void ChangeStyle()
        {
            this.Background = background;
            this.progressBar.Background = background;
            this.progressBar.Foreground = color;
        }

        private void textBox1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int index = (int)e.Key - (int)Key.A;
            char cyrillicChar = ' ';

            countClicks++;

            if (current == 0)
            {
                typingTimer.Start();
            }

            if (e.Key == Key.Escape)
            {
                var result = MessageBox.Show("Вы точно хотите выйти?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    timer.Stop();
                    text.Clear();

                    currentRow = 0;
                    current = 0;

                    typingTimer.Stop();

                    NavigationService.GoBack();
                }
                else return;
            }

            if (index >= 0 && index < cyrillicChars.Length)
            {
                cyrillicChar = cyrillicChars[index];
            }

            if (cyrillicChar == textBox1.Text[current])
            {
                countCorrect++;
                typedCharacters++;


                if (current == textBox1.Text.Length - 1)
                {
                    currentRow += 1;

                    if (currentRow == Levels.countRows)
                    {
                        timer.Stop();
                        textBox1.Text = "Игра пройдена!";

                        text.Clear();

                        progressBar.Value++; //костыль
                        currentRow = 0;
                        current = 0;

                        typingTimer.Stop();
                        double elapsedTimeInSeconds = typingTimer.Elapsed.TotalSeconds;

                        if (elapsedTimeInSeconds > 0)
                        {
                            typingSpeed = Math.Round(typedCharacters / elapsedTimeInSeconds);
                        }

                        target = Math.Round((double)countCorrect / countClicks * 100);

                        MainWindow.window.Title = "Клавиатурный тренажер";

                        ResultWindow resultWindow = new ResultWindow();
                        resultWindow.ShowDialog();

                        NavigationService.Navigate(new Levels());

                    }
                    else
                    {
                        textBox1.SelectionLength = current + 1;
                        textBox1.Text = text[currentRow];

                        current = 0;
                        return;
                    }
                }

                progressBar.Value++;
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = current + 1;
                textBox1.SelectionBrush = Brushes.Black;

                current += 1;
            }
        }

        private void Buttons_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Button button = (Button)this.FindName(e.Key.ToString());

            if (button != null)
            {
                button.Background = color;
            }
        }

        private void Buttons_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            Button button = (Button)this.FindName(e.Key.ToString());

            if (button != null)
            {
                button.Background = Brushes.AliceBlue;
            }
        }
    }
}