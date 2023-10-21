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

namespace KeyboardTrainer
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static List<string> text = new List<string>();

        private int current = 0;
        private int currentRow = 0;

        private char[] cyrillicChars = { 'ф', 'и', 'с', 'в', 'у', 'а', 'п', 'р', 'ш', 'о', 'л', 'д', 'ь', 'т', 'щ', 'з', 'й', 'к', 'ы', 'е', 'г', 'м', 'ц', 'ч', 'н', 'я' };
        public MainPage()
        {
            InitializeComponent();

            textBox1.Text = text[currentRow];
            textBox1.Focus();
        }

        private void textBox1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int index = (int)e.Key - (int)Key.A;
            char cyrillicChar = ' ';

            if (index >= 0 && index < cyrillicChars.Length)
            {
                cyrillicChar = cyrillicChars[index];
            }

            if (cyrillicChar == textBox1.Text[current])
            {
                if (current == textBox1.Text.Length - 1)
                {
                    currentRow += 1;

                    if (currentRow == Levels.countRows)
                    {
                        textBox1.Text = "Игра пройдена!";
                        MessageBox.Show("Игра пройдена!");

                        text.Clear();

                        currentRow = 0;
                        current = 0;

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

                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = current + 1;
                textBox1.SelectionBrush = Brushes.Black;

                current += 1;
            }
            else return;
        }

        private void Buttons_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Button button = (Button)this.FindName(e.Key.ToString());

            if (button != null)
            {
                button.Background = Brushes.Red;
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