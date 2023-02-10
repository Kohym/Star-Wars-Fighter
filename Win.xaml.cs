using System;
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
        public Win()
        {
            InitializeComponent();
            var sound1 = new MediaPlayer();
            var sound1file = new Uri($@"mp3/Pwin.mp3", UriKind.Relative);
            sound1.Open(sound1file);
            sound1.Play();
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
    }
}
