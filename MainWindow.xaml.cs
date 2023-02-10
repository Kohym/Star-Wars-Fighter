using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using Ta_Boss_věc;

namespace Ta_Boss_věc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int action;
        int DMG;
        int HP;
        int EDMG;
        double AG;
        string sndP;
        string sndE;
        #region Class creation
        EnemyClass Falcon = new EnemyClass();
        EnemyClass X = new EnemyClass();
        EnemyClass Y = new EnemyClass();
        EnemyClass TIE = new EnemyClass();
        EnemyClass Interceptor = new EnemyClass();
        EnemyClass Bomber = new EnemyClass();
        EnemyClass Destroyer = new EnemyClass();
        EnemyClass Vader = new EnemyClass();
        public static Random RandomGen = new Random();
        #endregion Class creation
        public MainWindow()
        {
            #region stats
            Falcon.NAME = "Milenium Falcon"; Falcon.DMG = 30; Falcon.HP =160; Falcon.DOGE = 5; Falcon.FILENAME = "Milenium_Falcon";
            X.NAME = "X-Wing"; X.DMG = 35; X.HP= 100; X.DOGE= 50; X.FILENAME = "X-Wing";
            Y.NAME = "Y-Wing"; Y.DMG = 70; Y.HP= 70; Y.DOGE= 10; Y.FILENAME = "Y-Wing";
            TIE.NAME = "TIE Fighter"; TIE.DMG = 20; TIE.HP = 40; TIE.DOGE = 20; TIE.FILENAME = "TIE_Fighter";
            Interceptor.NAME = "TIE Interceptor"; Interceptor.DMG = 40; Interceptor.HP = 40; Interceptor.DOGE = 50; Interceptor.FILENAME = "TIE_Interceptor";
            Bomber.NAME = "TIE bomber"; Bomber.DMG = 10; Bomber.HP = 70; Bomber.DOGE = 5; Bomber.FILENAME = "TIE_Bomber";
            Destroyer.NAME = "Star Destroyer"; Destroyer.DMG = 60; Destroyer.HP= 150 ; Destroyer.DOGE = 0; Destroyer.FILENAME = "Star_Destroyer";
            Vader.NAME = "Darth Vader's TIE"; Vader.DMG = 45; Vader.HP = 70; Vader.DOGE = 60; Vader.FILENAME = "Vader_TIE";

            #endregion stats
            InitializeComponent();
        }
        #region action
        private void Next_Round_Click(object sender, RoutedEventArgs e)
        {
            var sound1 = new MediaPlayer();
            if (action ==1)
            {
                var sound1file = new Uri($@"mp3/{sndP}.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                Enemy_HP_Label.Content = Convert.ToInt32(Convert.ToInt32(Enemy_HP_Label.Content) - DMG);
                MessageBox.Show($"{PlayerName.Content} hit {EnemyName.Content} for {DMG} damage. {EnemyName.Content}’s HP is now: {Enemy_HP_Label.Content}");
                sound1file = new Uri($@"mp3/{sndE}.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                Player_HP_Label.Content = Convert.ToInt32(Convert.ToInt32(Player_HP_Label.Content) - EDMG);
                MessageBox.Show($"{EnemyName.Content} has hit {PlayerName.Content} for {EDMG} damage. {PlayerName.Content}’s HP is now: {Player_HP_Label.Content}");
                Player_HP.Maximum = HP; Player_HP.Value = Convert.ToInt32(Player_HP.Value - EDMG);
                Enemy_HP.Value = Convert.ToInt32(Enemy_HP.Value - DMG);
            }
            else if (action ==2)
            {
                var sound1file = new Uri($@"mp3/{sndP}_FLY.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                Player_HP.Value = HP; Player_HP.Maximum = HP;
                Player_HP_Label.Content = Player_HP.Value.ToString();
                MessageBox.Show($"{PlayerName.Content} dodged {EnemyName.Content}’s shots and healed to {Player_HP_Label.Content} HP");
            }
            else
            {
                MessageBox.Show("Chose an action please!");
            }
        }
        #endregion action
        SolidColorBrush myBrush = new SolidColorBrush(Colors.White);
        #region UI
        private void Next_Round_MouseEnter(object sender, MouseEventArgs e)
        {
            Next_Round.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
        }
        private void Next_Round_MouseLeave(object sender, MouseEventArgs e)
        {
            Next_Round.Foreground = myBrush;
        }
        private void Atack_MouseEnter(object sender, MouseEventArgs e)
        {
            Atack.BorderThickness = new System.Windows.Thickness(3);
        }
        private void Atack_MouseLeave(object sender, MouseEventArgs e)
        {
                Atack.BorderThickness = new System.Windows.Thickness(0);
        }
        private void Heal_MouseEnter(object sender, MouseEventArgs e)
        {
            Heal.BorderThickness = new System.Windows.Thickness(3);
        }

        private void Heal_MouseLeave(object sender, MouseEventArgs e)
        {
            Heal.BorderThickness = new System.Windows.Thickness(0);
        }
        private void Atack_Click(object sender, RoutedEventArgs e)
        {
            action = 1;
            Atack.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            Heal.Foreground = myBrush;
        }

        private void Heal_Click(object sender, RoutedEventArgs e)
        {
            action = 2;
            Heal.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffe81f"));
            Atack.Foreground = myBrush;
        }
        #endregion UI
        int help = 1;
        int help2 = 1;
        #region Que
        private async void Enemy_HP_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var sound1 = new MediaPlayer();
                if (Enemy_HP.Value <= 0 & help == 1)
                {
                    help2= 0;
                    Player_HP.Maximum = HP;
                    Player_HP.Value = HP;
                    Player_HP_Label.Content = HP;
                    sndE = Interceptor.FILENAME;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed. {PlayerName.Content} has been fully repaired.");
                    await Task.Delay(2000);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Interceptor.NAME}");
                    EnemyName.Content = Interceptor.NAME;
                    Enemy_HP.Maximum = Interceptor.HP; Enemy_HP.Value = Interceptor.HP;
                    Enemy_HP_Label.Content = Interceptor.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Interceptor.FILENAME}.png", UriKind.Relative));
                    EDMG = Interceptor.DMG;
                    help = 2;
                    help2 = 1;
                }
                if (Enemy_HP.Value <= 0 && help == 2)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    Player_HP.Value = HP;
                    Player_HP_Label.Content = HP;
                    sndE = Destroyer.FILENAME;
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"{EnemyName.Content} has been destroyed. {PlayerName.Content} has been fully repaired.");
                    await Task.Delay(2000);
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Destroyer.NAME}");
                    EnemyName.Content = Destroyer.NAME;
                    Enemy_HP.Maximum = Destroyer.HP; Enemy_HP.Value = Destroyer.HP;
                    Enemy_HP_Label.Content = Destroyer.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Destroyer.FILENAME}.png", UriKind.Relative));
                    EDMG = Destroyer.DMG;
                    help = 3;
                    help2 = 1;
                }
                if (Enemy_HP.Value <= 0 && help == 3)
                {
                    Win objMainWindow = new Win();
                    this.Visibility = Visibility.Hidden;
                    objMainWindow.Show();
                }
        }
        private void Player_HP_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Player_HP.Value <= 0 & help2 == 1)
            {
                MessageBox.Show($"{PlayerName.Content} has been destroyed. Mission failed");
                Los objMainWindow = new Los();
                this.Visibility = Visibility.Hidden;
                objMainWindow.Show();
            }
        }
        #endregion que
        #region activation
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var sound1 = new MediaPlayer();
            if (Class1.ins.select == 1)
            {
                var sound1file = new Uri($@"mp3/Millenium_Falcon_FLY.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                DMG = Falcon.DMG;
                AG = Falcon.DOGE / 100;
                HP = Falcon.HP;
                PlayerName.Content = (Falcon.NAME);
                Player_HP.Maximum = Falcon.HP; Player_HP_Label.Content = Falcon.HP; Player_HP.Value = Falcon.HP;
                player_img.Source = new BitmapImage(new Uri($@"Imgs/{Falcon.FILENAME}.png", UriKind.Relative));
                sndP = Falcon.FILENAME;
                MessageBox.Show($"The Milenium Falcon enters the mission sector.");
            }
            else if (Class1.ins.select == 2)
            {
                var sound1file = new Uri($@"mp3/X-Wing_FLY.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                DMG = X.DMG;
                AG = X.DOGE / 100;
                HP = X.HP;
                PlayerName.Content = (X.NAME);
                Player_HP.Maximum = X.HP; Player_HP_Label.Content = X.HP; Player_HP.Value = X.HP;
                player_img.Source = new BitmapImage(new Uri($@"Imgs/{X.FILENAME}.png", UriKind.Relative));
                sndP = X.FILENAME;
                MessageBox.Show($"The X-Wing enters the mission sector.");
            }
            else if (Class1.ins.select == 3)
            {
                var sound1file = new Uri($@"mp3/Y-Wing_FLY.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                DMG = Y.DMG;
                AG = Y.DOGE / 100;
                HP = Y.HP;
                PlayerName.Content = (Y.NAME);
                Player_HP.Maximum = Y.HP; Player_HP_Label.Content = Y.HP; Player_HP.Value = Y.HP;
                player_img.Source = new BitmapImage(new Uri($@"Imgs/{Y.FILENAME}.png", UriKind.Relative));
                sndP = Y.FILENAME;
                MessageBox.Show($"The Y-Wing enters the mission sector.");
            }
            EnemyName.Content = TIE.NAME;
            Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
            Enemy_HP_Label.Content = TIE.HP;
            enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
            EDMG = TIE.DMG;
            sndE = TIE.FILENAME;
            var sound1file1 = new Uri($@"mp3/TIE_Fighter_FLY.mp3", UriKind.Relative);
            sound1.Open(sound1file1);
            sound1.Play();
            MessageBox.Show($"A TIE Fighter enters {PlayerName.Content}’s sights.");
        }
        #endregion activation
    }
}