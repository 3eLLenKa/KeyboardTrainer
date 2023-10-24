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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow window = new MainWindow();
        public MainWindow()
        {
            InitializeComponent();

            FileInfo first = new FileInfo(@"D:\first_lvl.txt");
            FileInfo second = new FileInfo(@"D:\second_lvl.txt");
            FileInfo third = new FileInfo(@"D:\third_lvl.txt");

            if (!first.Exists) { File.WriteAllText(@"D:\first_lvl.txt", "вввооо ввово оввоо вовов оовов\r\nво ов вовво овово вово вов ово\r\nво овов аааооо ааоао оааоо ово\r\nаоаоа ооаоа ва оо аоаао оаоаоа\r\nвао ава вова авао оао лллааала\r\nаллаа лалал аалал вал ла лалла\r\nалала вол лов алла вал ава ввв"); }
            if (!second.Exists) { File.WriteAllText(@"D:\second_lvl.txt", "фффддд ффдфд дффдд фдфдф ддфд\r\nдва фдффд дфдфд вдова вода дв\r\nвдова ыыыддд ыыдыд дыыдд ыдыд\r\nвывод два ыдыыд дыдыд вывод"); }
            if (!third.Exists) { File.WriteAllText(@"D:\third_lvl.txt", "мммттт ммтмт тммтт мтмтм тт\r\nтот мтммт тмтмт мадам дым т\r\nтом иииттт иитит тиитт итит\r\nмолитва идти итиит титит\r\nили вид вдали ьььиии\r\n ььиьи иььии ьиьиь ииьиь\r\nводить ьиььи иьиьи мать мыт\r\nвдоль мммььь ммьмь ьм\r\nььмьм мол даль ьммьь мьмьмм\r\nмьммь ьмьмь отдать отдавать\r\nвидать мимо мммиии иимим ми\r\nавить мыло имими ммими доло"); }

            mainFrame.Navigate(new Levels());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}