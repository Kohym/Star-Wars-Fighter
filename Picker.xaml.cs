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
    /// Interakční logika pro Picker.xaml
    /// </summary>
    public partial class Picker : Window
    {
        Class1 pick = new Class1();
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

        private async void Window_Loaded(object sender, EventArgs e)
        {
            var sound1 = new MediaPlayer();
            var sound2 = new MediaPlayer();
            hid.Source = new BitmapImage(new Uri(@"Imgs\blck.png", UriKind.Relative));
            await Task.Delay(7000);
            MessageBox.Show("You enter the command center.");
            var sound1file = new Uri($@"mp3/door.mp3", UriKind.Relative);
            sound1.Open(sound1file);
            sound1.Play();
            hid.Source= new BitmapImage(new Uri(@"Imgs\center.png", UriKind.Relative));
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
            hid.Visibility= Visibility.Hidden; hid.Visibility=Visibility.Hidden;
        }
    }
}