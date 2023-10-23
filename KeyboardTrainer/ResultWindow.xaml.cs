﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

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

            timeTxt.Text += MainPage.time.ToString(@"mm\:ss");
            speedTxt.Text += MainPage.typingSpeed.ToString() + " зн./сек.";
            keyboardTxt.Text += Levels.countLetters.ToString();
            targetTxt.Text += MainPage.target.ToString() + "%";
        }
    }
}