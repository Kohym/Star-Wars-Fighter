using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using Ta_Boss_věc;

namespace Ta_Boss_věc
{
    /// <summary>
    /// Interaction logic for Picker.xaml
    /// </summary>
    public partial class Picker : Window
    {
        Class1 pick = new Class1();
        Class2 pick2 = new Class2();
        public Picker()
        {
            InitializeComponent();
            falcon.Source = new BitmapImage(new Uri(@"Imgs/F.png", UriKind.Relative));
            X.Source = new BitmapImage(new Uri(@"Imgs/X.png", UriKind.Relative));
            Y.Source = new BitmapImage(new Uri(@"Imgs/Y.png", UriKind.Relative));

        }
        private void OpenWindow(object sender, RoutedEventArgs e)
        {

            if (pick.select != 0)
            {
                MainWindow objMainWindow = new MainWindow();
                this.Visibility = Visibility.Hidden;
                objMainWindow.Show();
            }
            else
            {
                MessageBox.Show("Pick a fighter please!");
            }
        }
        #region UI
        #region UI IMG
        SolidColorBrush myBrush = new SolidColorBrush(Colors.White);
        SolidColorBrush myBrush2 = new SolidColorBrush(Colors.Black);
        private void falcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pick.select = 1;
            falcon_text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            X_text.Foreground = myBrush;
            Y_text.Foreground = myBrush;
            falcon.Source = new BitmapImage(new Uri(@"Imgs\FY.png", UriKind.Relative));
            X.Source = new BitmapImage(new Uri(@"Imgs\X.png", UriKind.Relative));
            Y.Source = new BitmapImage(new Uri(@"Imgs\Y.png", UriKind.Relative));
            F1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            X1.Background = myBrush2;
            Y1.Background= myBrush2;
            F2.Foreground = myBrush2;
            X2.Foreground = myBrush;
            Y2.Foreground = myBrush;
        }
        private void falcon_text_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pick.select = 1;
            falcon_text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            X_text.Foreground = myBrush;
            Y_text.Foreground = myBrush;
            falcon.Source = new BitmapImage(new Uri(@"Imgs\FY.png", UriKind.Relative));
            X.Source = new BitmapImage(new Uri(@"Imgs\X.png", UriKind.Relative));
            Y.Source = new BitmapImage(new Uri(@"Imgs\Y.png", UriKind.Relative));
            F1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            X1.Background = myBrush2;
            Y1.Background = myBrush2;
            F2.Foreground = myBrush2;
            X2.Foreground = myBrush;
            Y2.Foreground = myBrush;
        }

        private void X_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pick.select = 2;
            X_text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            falcon_text.Foreground = myBrush;
            Y_text.Foreground = myBrush;
            falcon.Source = new BitmapImage(new Uri(@"Imgs\F.png", UriKind.Relative));
            X.Source = new BitmapImage(new Uri(@"Imgs\XY.png", UriKind.Relative));
            Y.Source = new BitmapImage(new Uri(@"Imgs\Y.png", UriKind.Relative));
            F1.Background = myBrush2;
            X1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            Y1.Background = myBrush2;
            F2.Foreground = myBrush;
            X2.Foreground = myBrush2;
            Y2.Foreground = myBrush;
        }
        private void X_text_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pick.select = 2;
            X_text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            falcon_text.Foreground = myBrush;
            Y_text.Foreground = myBrush;
            falcon.Source = new BitmapImage(new Uri(@"Imgs/FY.png", UriKind.Relative));
            X.Source = new BitmapImage(new Uri(@"Imgs/XY.png", UriKind.Relative));
            Y.Source = new BitmapImage(new Uri(@"Imgs/Y.png", UriKind.Relative));
            F1.Background = myBrush2;
            X1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            Y1.Background = myBrush2;
            F2.Foreground = myBrush;
            X2.Foreground = myBrush2;
            Y2.Foreground = myBrush;
        }

        private void Y_MouseDown(object sender, MouseButtonEventArgs e)
        { 
            pick.select = 3;
            Y_text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            falcon_text.Foreground = myBrush;
            X_text.Foreground = myBrush;
            falcon.Source = new BitmapImage(new Uri(@"Imgs/F.png", UriKind.Relative));
            X.Source = new BitmapImage(new Uri(@"Imgs/X.png", UriKind.Relative));
            Y.Source = new BitmapImage(new Uri(@"Imgs/YY.png", UriKind.Relative));
            F1.Background = myBrush2;
            X1.Background = myBrush2;
            Y1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            F2.Foreground = myBrush;
            X2.Foreground = myBrush;
            Y2.Foreground = myBrush2;
        }
        private void Y_text_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            pick.select = 3;
            Y_text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            falcon_text.Foreground = myBrush;
            X_text.Foreground = myBrush;
            falcon.Source = new BitmapImage(new Uri(@"Imgs/F.png", UriKind.Relative));
            X.Source = new BitmapImage(new Uri(@"Imgs/X.png", UriKind.Relative));
            Y.Source = new BitmapImage(new Uri(@"Imgs/YY.png", UriKind.Relative));
            F1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            F1.Background = myBrush2;
            X1.Background = myBrush2;
            Y1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            F2.Foreground = myBrush;
            X2.Foreground = myBrush;
            Y2.Foreground = myBrush2;
        }
        #endregion UI IMG
        #region UI TEXT
        DispatcherTimer fTimer = new DispatcherTimer();
        DispatcherTimer xTimer = new DispatcherTimer();
        DispatcherTimer yTimer = new DispatcherTimer();
        private void falcon_MouseEnter(object sender, MouseEventArgs e)
        {
            fTimer.Interval = TimeSpan.FromSeconds(1);
            fTimer.Start();
            fTimer.Tick += (sender, args) =>
            { fTimer.Stop(); popupFalcon.IsOpen = true; };
        }

        private void falcon_MouseLeave(object sender, MouseEventArgs e)
        {
            fTimer.Stop();
            popupFalcon.IsOpen= false;
        }
        private void X_MouseEnter(object sender, MouseEventArgs e)
        {
            xTimer.Interval = TimeSpan.FromSeconds(1);
            xTimer.Start();
            xTimer.Tick += (sender, args) =>
            { xTimer.Stop(); popupX.IsOpen = true; };
        }

        private void X_MouseLeave(object sender, MouseEventArgs e)
        {
            xTimer.Stop();
            popupX.IsOpen = false;
        }
        private void Y_MouseEnter(object sender, MouseEventArgs e)
        {
            yTimer.Interval = TimeSpan.FromSeconds(1);
            yTimer.Start();
            yTimer.Tick += (sender, args) =>
            { yTimer.Stop(); popupY.IsOpen = true; };
        }

        private void Y_MouseLeave(object sender, MouseEventArgs e)
        {
            yTimer.Stop();
            popupY.IsOpen = false;
        }
        #endregion UI TEXT

        #endregion UI
        #region cutscene
        private async void Window_Loaded(object sender, EventArgs e)
        {
            hid.Visibility = Visibility.Collapsed;
            if (Class3.ins?.scene == null)
            {
                hid.Visibility = Visibility.Visible;
                var sound1 = new MediaPlayer();
                var sound2 = new MediaPlayer();
                hid.Source = new BitmapImage(new Uri(@"Imgs\blck.png", UriKind.Relative));
                await Task.Delay(7000);
                MessageBox.Show("You enter the command center.");
                var sound1file = new Uri($@"mp3/door.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                hid.Source = new BitmapImage(new Uri(@"Imgs\center.png", UriKind.Relative));
                var sound2file = new Uri($@"mp3/talk.mp3", UriKind.Relative);
                sound2.Open(sound2file);
                sound2.Play();
                await Task.Delay(900);
                MessageBox.Show("You approach your station and log in.");
                sound1file = new Uri($@"mp3/walk.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                await Task.Delay(5000);
                sound1file = new Uri($@"mp3/log.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                await Task.Delay(2000);
                sound1.Stop();
                sound2.Stop();
                hid.Visibility = Visibility.Collapsed;
            }
            #endregion cutscene
        #region default
            else
            {
                M1.BorderThickness = new Thickness(0);
                M2.BorderThickness = new Thickness(0);
                M3.BorderThickness = new Thickness(0);
                M4.BorderThickness = new Thickness(0);
                M5.BorderThickness = new Thickness(0);
                M1.Background = myBrush2;
                M2.Background = myBrush2;
                M3.Background = myBrush2;
                M4.Background = myBrush2;
                M5.Background = myBrush2;
                MD1.Visibility = Visibility.Collapsed;
                MD2.Visibility = Visibility.Collapsed;
                MD3.Visibility = Visibility.Collapsed;
                MD4.Visibility = Visibility.Collapsed;
                MD5.Visibility = Visibility.Collapsed;
                next.Visibility = Visibility.Collapsed;
                pick2.mission = 0;
                falcon.Source = new BitmapImage(new Uri(@"Imgs/F.png", UriKind.Relative));
                X.Source = new BitmapImage(new Uri(@"Imgs/X.png", UriKind.Relative));
                Y.Source = new BitmapImage(new Uri(@"Imgs/Y.png", UriKind.Relative));
                pick.select = 0;
                falcon_text.Foreground = myBrush;
                X_text.Foreground = myBrush;
                Y_text.Foreground = myBrush;
                F1.Background = myBrush2;
                X1.Background = myBrush2;
                Y1.Background = myBrush2;
                F2.Foreground = myBrush;
                X2.Foreground = myBrush;
                Y2.Foreground = myBrush;

            }
        }
        #endregion default
        #region UI2
        private void M1_Click(object sender, RoutedEventArgs e)
        {
            pick2.mission = 1;
            M1.BorderThickness = new Thickness(0);
            M2.BorderThickness = new Thickness(0);
            M3.BorderThickness = new Thickness(0);
            M4.BorderThickness = new Thickness(0);
            M5.BorderThickness = new Thickness(0);
            M1.Background = myBrush2;
            M2.Background = myBrush2;
            M3.Background = myBrush2;
            M4.Background = myBrush2;
            M5.Background = myBrush2;
            MD1.Visibility = Visibility.Collapsed;
            MD2.Visibility = Visibility.Collapsed;
            MD3.Visibility = Visibility.Collapsed;
            MD4.Visibility = Visibility.Collapsed;
            MD5.Visibility = Visibility.Collapsed;
            M1.BorderThickness = new Thickness(5);
            MD1.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Visible;
        }

        private void M2_Click(object sender, RoutedEventArgs e)
        {
            pick2.mission = 2;
            M1.BorderThickness = new Thickness(0);
            M2.BorderThickness = new Thickness(0);
            M3.BorderThickness = new Thickness(0);
            M4.BorderThickness = new Thickness(0);
            M5.BorderThickness = new Thickness(0);
            M1.Background = myBrush2;
            M2.Background = myBrush2;
            M3.Background = myBrush2;
            M4.Background = myBrush2;
            M5.Background = myBrush2;
            MD1.Visibility = Visibility.Collapsed;
            MD2.Visibility = Visibility.Collapsed;
            MD3.Visibility = Visibility.Collapsed;
            MD4.Visibility = Visibility.Collapsed;
            MD5.Visibility = Visibility.Collapsed;
            M2.BorderThickness = new Thickness(5);
            MD2.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Visible;
        }

        private void M3_Click(object sender, RoutedEventArgs e)
        {
            pick2.mission = 3;
            M1.BorderThickness = new Thickness(0);
            M2.BorderThickness = new Thickness(0);
            M3.BorderThickness = new Thickness(0);
            M4.BorderThickness = new Thickness(0);
            M5.BorderThickness = new Thickness(0);
            M1.Background = myBrush2;
            M2.Background = myBrush2;
            M3.Background = myBrush2;
            M4.Background = myBrush2;
            M5.Background = myBrush2;
            MD1.Visibility = Visibility.Collapsed;
            MD2.Visibility = Visibility.Collapsed;
            MD3.Visibility = Visibility.Collapsed;
            MD4.Visibility = Visibility.Collapsed;
            MD5.Visibility = Visibility.Collapsed;
            M3.BorderThickness = new Thickness(5);
            MD3.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Visible;
        }

        private void M4_Click(object sender, RoutedEventArgs e)
        {
            pick2.mission = 4;
            M1.BorderThickness = new Thickness(0);
            M2.BorderThickness = new Thickness(0);
            M3.BorderThickness = new Thickness(0);
            M4.BorderThickness = new Thickness(0);
            M5.BorderThickness = new Thickness(0);
            M1.Background = myBrush2;
            M2.Background = myBrush2;
            M3.Background = myBrush2;
            M4.Background = myBrush2;
            M5.Background = myBrush2;
            MD1.Visibility = Visibility.Collapsed;
            MD2.Visibility = Visibility.Collapsed;
            MD3.Visibility = Visibility.Collapsed;
            MD4.Visibility = Visibility.Collapsed;
            MD5.Visibility = Visibility.Collapsed;
            M4.BorderThickness = new Thickness(5);
            MD4.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Visible;
        }

        private void M5_Click(object sender, RoutedEventArgs e)
        {
            pick2.mission = 5;
            M1.BorderThickness = new Thickness(0);
            M2.BorderThickness = new Thickness(0);
            M3.BorderThickness = new Thickness(0);
            M4.BorderThickness = new Thickness(0);
            M5.BorderThickness = new Thickness(0);
            M1.Background = myBrush2;
            M2.Background = myBrush2;
            M3.Background = myBrush2;
            M4.Background = myBrush2;
            M5.Background = myBrush2;
            MD1.Visibility= Visibility.Collapsed;
            MD2.Visibility = Visibility.Collapsed;
            MD3.Visibility = Visibility.Collapsed;
            MD4.Visibility = Visibility.Collapsed;
            MD5.Visibility = Visibility.Collapsed;
            M5.BorderThickness = new Thickness(5);
            MD5.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Visible;
        }
        #endregion UI2
        private void next_Click(object sender, RoutedEventArgs e)
        {
            hid.Visibility = Visibility.Collapsed;
            sss.Visibility = Visibility.Collapsed;
            M.Visibility= Visibility.Collapsed;
            M1.Visibility= Visibility.Collapsed;
            M2.Visibility= Visibility.Collapsed;
            M3.Visibility= Visibility.Collapsed;
            M4.Visibility= Visibility.Collapsed;
            M5.Visibility= Visibility.Collapsed;
            MD.Visibility= Visibility.Collapsed;
            MD1.Visibility= Visibility.Collapsed;
            MD2.Visibility= Visibility.Collapsed;
            MD3.Visibility= Visibility.Collapsed;
            MD4.Visibility= Visibility.Collapsed;
            MD5.Visibility= Visibility.Collapsed;
            next.Visibility= Visibility.Collapsed;
            dos.Visibility = Visibility.Collapsed;
            var sound1 = new MediaPlayer();
            var sound1file = new Uri($@"mp3/log.mp3", UriKind.Relative);
            sound1.Open(sound1file);
            sound1.Play();
            pick_fighter.Visibility = Visibility.Visible;
            falcon.Visibility = Visibility.Visible;
            X.Visibility = Visibility.Visible;
            Y.Visibility = Visibility.Visible;
            falcon_text.Visibility = Visibility.Visible;
            X_text.Visibility = Visibility.Visible;
            Y_text.Visibility = Visibility.Visible;
            GO.Visibility = Visibility.Visible;
            back.Visibility = Visibility.Visible;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            hid.Visibility = Visibility.Collapsed;
            sss.Visibility = Visibility.Visible;
            M.Visibility = Visibility.Visible;
            M1.Visibility = Visibility.Visible;
            M2.Visibility = Visibility.Visible;
            M3.Visibility = Visibility.Visible;
            M4.Visibility = Visibility.Visible;
            M5.Visibility = Visibility.Visible;
            MD.Visibility = Visibility.Visible;
            MD1.Visibility = Visibility.Collapsed;
            MD2.Visibility = Visibility.Collapsed;
            MD3.Visibility = Visibility.Collapsed;
            MD4.Visibility = Visibility.Collapsed;
            MD5.Visibility = Visibility.Collapsed;
            next.Visibility = Visibility.Collapsed;
            E1.Visibility = Visibility.Collapsed;
            E2.Visibility = Visibility.Collapsed;
            E3.Visibility = Visibility.Collapsed;
            E4.Visibility = Visibility.Collapsed;
            EP1.Visibility = Visibility.Collapsed;
            EP2.Visibility = Visibility.Collapsed;
            EP3.Visibility = Visibility.Collapsed;
            EP4.Visibility = Visibility.Collapsed;
            ED1.Visibility = Visibility.Collapsed;
            ED2.Visibility = Visibility.Collapsed;
            ED3.Visibility = Visibility.Collapsed;
            ED4.Visibility = Visibility.Collapsed;
            var sound1 = new MediaPlayer();
            var sound1file = new Uri($@"mp3/log.mp3", UriKind.Relative);
            sound1.Open(sound1file);
            sound1.Play();
            pick_fighter.Visibility = Visibility.Collapsed;
            falcon.Visibility = Visibility.Collapsed;
            X.Visibility = Visibility.Collapsed;
            Y.Visibility = Visibility.Collapsed;
            falcon_text.Visibility = Visibility.Collapsed;
            X_text.Visibility = Visibility.Collapsed;
            Y_text.Visibility = Visibility.Collapsed;
            GO.Visibility = Visibility.Collapsed;
            back.Visibility = Visibility.Collapsed;
            dos.Visibility = Visibility.Visible;
            egg.Visibility = Visibility.Collapsed;
        }
        private void dos_Click(object sender, RoutedEventArgs e)
        {
            hid.Visibility = Visibility.Collapsed;
            sss.Visibility = Visibility.Collapsed;
            M.Visibility = Visibility.Collapsed;
            M1.Visibility = Visibility.Collapsed;
            M2.Visibility = Visibility.Collapsed;
            M3.Visibility = Visibility.Collapsed;
            M4.Visibility = Visibility.Collapsed;
            M5.Visibility = Visibility.Collapsed;
            MD.Visibility = Visibility.Collapsed;
            MD1.Visibility = Visibility.Collapsed;
            MD2.Visibility = Visibility.Collapsed;
            MD3.Visibility = Visibility.Collapsed;
            MD4.Visibility = Visibility.Collapsed;
            MD5.Visibility = Visibility.Collapsed;
            next.Visibility = Visibility.Collapsed;
            dos.Visibility = Visibility.Collapsed;
            E1.Visibility = Visibility.Visible;
            E2.Visibility = Visibility.Visible;
            E3.Visibility = Visibility.Visible;
            E4.Visibility = Visibility.Visible;
            EP1.Visibility = Visibility.Visible;
            EP2.Visibility = Visibility.Visible;
            EP3.Visibility = Visibility.Visible;
            EP4.Visibility = Visibility.Visible;
            ED1.Visibility = Visibility.Visible;
            ED2.Visibility = Visibility.Visible;
            ED3.Visibility = Visibility.Visible;
            ED4.Visibility = Visibility.Visible;
            egg.Visibility = Visibility.Visible;
            back.Visibility = Visibility.Visible;
            E1.Content = "TIE Fighter";
            E2.Content = "TIE Interceptor";
            E3.Content = "TIE Bomber";
            EP1.Source = new BitmapImage(new Uri(@"Imgs\TIE_Fighter.png", UriKind.Relative));
            EP2.Source = new BitmapImage(new Uri(@"Imgs\TIE_Interceptor.png", UriKind.Relative));
            EP3.Source = new BitmapImage(new Uri(@"Imgs\TIE_Bomber.png", UriKind.Relative));
            ED1.Text = "DMG: 20\nHP: 40\n AG: 10";
            ED2.Text = "DMG: 30\nHP: 40\n AG: 30";
            ED3.Text = "DMG: 10\nHP: 70\n AG: 5";
        }

        private void egg_Click(object sender, RoutedEventArgs e)
        {
            E1.Content = "TIE Defender";
            E2.Content = "TIE Advanced";
            E3.Content = "Comms array";
            EP1.Source = new BitmapImage(new Uri(@"Imgs\TIE_Defender.png", UriKind.Relative));
            EP2.Source = new BitmapImage(new Uri(@"Imgs\Vader_TIE.png", UriKind.Relative));
            EP3.Source = new BitmapImage(new Uri(@"Imgs\Death_Star.png", UriKind.Relative));
            ED1.Text = "DMG: 35\nHP: 100\n AG: 50";
            ED2.Text = "DMG: 45\nHP: 70\n AG: 50";
            ED3.Text = "DMG: 50\nHP: 200\n AG: 0";
            E4.Visibility = Visibility.Collapsed;
            EP4.Visibility = Visibility.Collapsed;
            ED4.Visibility = Visibility.Collapsed;
            egg.Visibility = Visibility.Collapsed;
        }
    }
}