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

namespace Ta_Boss_věc
{
    /// <summary>
    /// Interakční logika pro Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        Class3 helpus;
        public Win()
        {
            InitializeComponent();
            this.helpus = new Class3();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            End.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        SolidColorBrush myBrush = new SolidColorBrush(Colors.White);
        private void End_MouseLeave(object sender, MouseEventArgs e)
        {
            End.Foreground = myBrush;
        }

        private void menu_MouseEnter(object sender, MouseEventArgs e)
        {
            menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
        }

        private void menu_MouseLeave(object sender, MouseEventArgs e)
        {
            menu.Foreground = myBrush;
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            helpus.scene = 1;
            Picker objMainWindow = new Picker();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var sound3 = new MediaPlayer();
            var sound3file = new Uri($@"mp3/Pwin.mp3", UriKind.Relative);
            sound3.Open(sound3file);
            sound3.Play();
        }
    }
}
