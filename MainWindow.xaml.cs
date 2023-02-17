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
        int AG;
        int EAG;
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
        EnemyClass Defender = new EnemyClass();
        EnemyClass Vader = new EnemyClass();
        EnemyClass Star = new EnemyClass();
        public static Random RandomGen = new Random();
        #endregion Class creation
        public MainWindow()
        {
            #region stats
            Falcon.NAME = "Milenium Falcon"; Falcon.DMG = 30; Falcon.HP =160; Falcon.DOGE = 15; Falcon.FILENAME = "Milenium_Falcon";
            X.NAME = "X-Wing"; X.DMG = 35; X.HP= 70; X.DOGE= 70; X.FILENAME = "X-Wing";
            Y.NAME = "Y-Wing"; Y.DMG = 70; Y.HP= 100; Y.DOGE= 30; Y.FILENAME = "Y-Wing";
            TIE.NAME = "TIE Fighter"; TIE.DMG = 20; TIE.HP = 40; TIE.DOGE = 10; TIE.FILENAME = "TIE_Fighter";
            Interceptor.NAME = "TIE Interceptor"; Interceptor.DMG = 30; Interceptor.HP = 40; Interceptor.DOGE = 30; Interceptor.FILENAME = "TIE_Interceptor";
            Bomber.NAME = "TIE Bomber"; Bomber.DMG = 10; Bomber.HP = 70; Bomber.DOGE = 5; Bomber.FILENAME = "TIE_Bomber";
            Destroyer.NAME = "Star Destroyer"; Destroyer.DMG = 60; Destroyer.HP= 150 ; Destroyer.DOGE = 0; Destroyer.FILENAME = "Star_Destroyer";
            Vader.NAME = "Darth Vader's TIE"; Vader.DMG = 45; Vader.HP = 70; Vader.DOGE = 50; Vader.FILENAME = "Vader_TIE";
            Defender.NAME = "TIE Defender"; Defender.DMG = 35; Defender.HP = 100; Defender.DOGE = 50; Defender.FILENAME = "TIE_Defender";
            Star.NAME = "Death Star’s comms array"; Star.DMG = 50; Star.HP = 200; Star.DOGE = 0; Star.FILENAME = "Death_Star";
            #endregion stats
            InitializeComponent();
        }
        #region action
        public static Random Random1 = new Random();
        private async void Next_Round_Click(object sender, RoutedEventArgs e)
        {
            var sound1 = new MediaPlayer();
            var sound2 = new MediaPlayer();
            int chance = Random1.Next(0, 100);
            if (action ==1)
            {
                var sound1file = new Uri($@"mp3/{sndP}.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                await Task.Delay(100);
                if (chance < EAG)
                {
                    sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"{EnemyName.Content} has dodged {PlayerName.Content}’s shots");
                    chance = Random1.Next(0, 100);
                    if (chance < AG)
                    {
                        sound1file = new Uri($@"mp3/{sndE}.mp3", UriKind.Relative);
                        sound1.Open(sound1file);
                        sound1.Play();
                        var sound2file = new Uri($@"mp3/{sndP}_FLY.mp3", UriKind.Relative);
                        sound2.Open(sound2file);
                        sound2.Play();
                        MessageBox.Show($"{PlayerName.Content} Has dodged {EnemyName.Content}’s shots");
                    }
                    else
                    {
                        sound1file = new Uri($@"mp3/{sndE}.mp3", UriKind.Relative);
                        sound1.Open(sound1file);
                        sound1.Play();
                        Player_HP_Label.Content = Convert.ToInt32(Convert.ToInt32(Player_HP_Label.Content) - EDMG);
                        MessageBox.Show($"{EnemyName.Content} has hit {PlayerName.Content} for {EDMG} damage. {PlayerName.Content}’s HP is now: {Player_HP_Label.Content}");
                    }
                }
                else if (chance < AG)
                {
                    Enemy_HP_Label.Content = Convert.ToInt32(Convert.ToInt32(Enemy_HP_Label.Content) - DMG);
                    MessageBox.Show($"{PlayerName.Content} hit {EnemyName.Content} for {DMG} damage. {EnemyName.Content}’s HP is now: {Enemy_HP_Label.Content}");
                    sound1file = new Uri($@"mp3/{sndE}.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    var sound2file = new Uri($@"mp3/{sndP}_FLY.mp3", UriKind.Relative);
                    sound2.Open(sound2file);
                    sound2.Play();
                    MessageBox.Show($"{PlayerName.Content} Has dodged {EnemyName.Content}’s shots");
                }
                else
                {
                    Enemy_HP_Label.Content = Convert.ToInt32(Convert.ToInt32(Enemy_HP_Label.Content) - DMG);
                    MessageBox.Show($"{PlayerName.Content} hit {EnemyName.Content} for {DMG} damage. {EnemyName.Content}’s HP is now: {Enemy_HP_Label.Content}");
                    sound1file = new Uri($@"mp3/{sndE}.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    Player_HP_Label.Content = Convert.ToInt32(Convert.ToInt32(Player_HP_Label.Content) - EDMG);
                    MessageBox.Show($"{EnemyName.Content} has hit {PlayerName.Content} for {EDMG} damage. {PlayerName.Content}’s HP is now: {Player_HP_Label.Content}");
                }
                Enemy_HP.Value = Convert.ToInt32(Enemy_HP_Label.Content);
                Player_HP.Maximum = HP; Player_HP.Value = Convert.ToInt32(Player_HP_Label.Content);
            }
            else if (action ==2)
            {
                var sound1file = new Uri($@"mp3/{sndE}.mp3", UriKind.Relative);
                sound1.Open(sound1file);
                sound1.Play();
                await Task.Delay(100);
                var sound2file = new Uri($@"mp3/{sndP}_FLY.mp3", UriKind.Relative);
                sound2.Open(sound2file);
                sound2.Play();
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
        int help = 1, help2 = 1;
        #region Que
        private async void Enemy_HP_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var sound1 = new MediaPlayer();
            var sound2 = new MediaPlayer();
            #region M1
            if (Class2.ins.mission == 1)
                {
                    if (Enemy_HP.Value <= 0 && help == 1)
                    {
                        help2 = 0;
                        Player_HP.Maximum = HP;
                        sndE = TIE.FILENAME;
                        EAG = TIE.DOGE;
                        MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                        await Task.Delay(200);
                        var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                        sound1.Open(sound1file);
                        sound1.Play();
                        MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {TIE.NAME}");
                        EnemyName.Content = TIE.NAME;
                        Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
                        Enemy_HP_Label.Content = TIE.HP;
                        enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
                        EDMG = TIE.DMG;
                        help = 2;
                        help2 = 1;
                    }
                    else if (Enemy_HP.Value <= 0 && help == 2)
                    {
                        help2 = 0;
                        Player_HP.Maximum = HP;
                        sndE = TIE.FILENAME;
                        EAG = TIE.DOGE;
                        MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                        await Task.Delay(200);
                        var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                        sound1.Open(sound1file);
                        sound1.Play();
                        MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {TIE.NAME}");
                        EnemyName.Content = TIE.NAME;
                        Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
                        Enemy_HP_Label.Content = TIE.HP;
                        enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
                        EDMG = TIE.DMG;
                        help = 3;
                        help2 = 1;
                    }
                    else if (Enemy_HP.Value <= 0 && help == 3)
                    {
                        help2 = 0;
                        Player_HP.Maximum = HP;
                        sndE = TIE.FILENAME;
                        EAG = TIE.DOGE;
                        MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                        await Task.Delay(200);
                        var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                        sound1.Open(sound1file);
                        sound1.Play();
                        MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {TIE.NAME}");
                        EnemyName.Content = TIE.NAME;
                        Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
                        Enemy_HP_Label.Content = TIE.HP;
                        enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
                        EDMG = TIE.DMG;
                        help = 4;
                        help2 = 1;
                    }
                    else if (Enemy_HP.Value <= 0 && help == 4)
                    {
                        help2 = 0;
                        Player_HP.Maximum = HP;
                        sndE = Interceptor.FILENAME;
                        EAG = Interceptor.DOGE;
                        MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                        await Task.Delay(200);
                        var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                        sound1.Open(sound1file);
                        sound1.Play();
                        MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Interceptor.NAME}");
                        EnemyName.Content = Interceptor.NAME;
                        Enemy_HP.Maximum = Interceptor.HP; Enemy_HP.Value = Interceptor.HP;
                        Enemy_HP_Label.Content = Interceptor.HP;
                        enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Interceptor.FILENAME}.png", UriKind.Relative));
                        EDMG = Interceptor.DMG;
                        help = 5;
                        help2 = 1;
                    }
                    if (Enemy_HP.Value <= 0 && help == 5)
                    {
                        help2 = 0;
                        sound1.Stop();
                        sound2.Stop();
                        MessageBox.Show($"{EnemyName.Content} has been destroyed. Mission successful.");
                        Win objMainWindow = new Win();
                        this.Visibility = Visibility.Hidden;
                        objMainWindow.Show();
                    }
            }
            #endregion M1
            #region M2
            else if (Class2.ins.mission == 2)
            {
                if (Enemy_HP.Value <= 0 & help == 1)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Interceptor.FILENAME;
                    EAG = Interceptor.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
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
                else if (Enemy_HP.Value <= 0 && help == 2)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Interceptor.FILENAME;
                    EAG = Interceptor.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Interceptor.NAME}");
                    EnemyName.Content = Interceptor.NAME;
                    Enemy_HP.Maximum = Interceptor.HP; Enemy_HP.Value = Interceptor.HP;
                    Enemy_HP_Label.Content = Interceptor.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Interceptor.FILENAME}.png", UriKind.Relative));
                    EDMG = Interceptor.DMG;
                    help = 3;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 3)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Bomber.FILENAME;
                    EAG = Bomber.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Bomber.NAME}");
                    EnemyName.Content = Bomber.NAME;
                    Enemy_HP.Maximum = Bomber.HP; Enemy_HP.Value = Bomber.HP;
                    Enemy_HP_Label.Content = Bomber.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Bomber.FILENAME}.png", UriKind.Relative));
                    EDMG = Bomber.DMG;
                    help = 4;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 4)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Bomber.FILENAME;
                    EAG = Bomber.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Bomber.NAME}");
                    EnemyName.Content = Bomber.NAME;
                    Enemy_HP.Maximum = Bomber.HP; Enemy_HP.Value = Bomber.HP;
                    Enemy_HP_Label.Content = Bomber.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Bomber.FILENAME}.png", UriKind.Relative));
                    EDMG = Bomber.DMG;
                    help = 5;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 5)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Bomber.FILENAME;
                    EAG = Bomber.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Bomber.NAME}");
                    EnemyName.Content = Bomber.NAME;
                    Enemy_HP.Maximum = Bomber.HP; Enemy_HP.Value = Bomber.HP;
                    Enemy_HP_Label.Content = Bomber.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Bomber.FILENAME}.png", UriKind.Relative));
                    EDMG = Bomber.DMG;
                    help = 6;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 6)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Bomber.FILENAME;
                    EAG = Bomber.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Bomber.NAME}");
                    EnemyName.Content = Bomber.NAME;
                    Enemy_HP.Maximum = Bomber.HP; Enemy_HP.Value = Bomber.HP;
                    Enemy_HP_Label.Content = Bomber.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Bomber.FILENAME}.png", UriKind.Relative));
                    EDMG = Bomber.DMG;
                    help = 7;
                    help2 = 1;
                }
                if (Enemy_HP.Value <= 0 && help == 7)
                {
                    help2 = 0;
                    sound1.Stop();
                    sound2.Stop();
                    MessageBox.Show($"{EnemyName.Content} has been destroyed. Mission successful.");
                    Win objMainWindow = new Win();
                    this.Visibility = Visibility.Hidden;
                    objMainWindow.Show();
                }
            }
            #endregion M2
            #region M3
            else if (Class2.ins.mission == 3)
            {
                if (Enemy_HP.Value <= 0 & help == 1)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Interceptor.FILENAME;
                    EAG = Interceptor.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
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
                else if (Enemy_HP.Value <= 0 && help == 2)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Interceptor.FILENAME;
                    EAG = Interceptor.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Interceptor.NAME}");
                    EnemyName.Content = Interceptor.NAME;
                    Enemy_HP.Maximum = Interceptor.HP; Enemy_HP.Value = Interceptor.HP;
                    Enemy_HP_Label.Content = Interceptor.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Interceptor.FILENAME}.png", UriKind.Relative));
                    EDMG = Interceptor.DMG;
                    help = 3;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 3)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Destroyer.FILENAME;
                    EAG = Destroyer.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Destroyer.NAME}");
                    EnemyName.Content = Destroyer.NAME;
                    Enemy_HP.Maximum = Destroyer.HP; Enemy_HP.Value = Destroyer.HP;
                    Enemy_HP_Label.Content = Destroyer.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Destroyer.FILENAME}.png", UriKind.Relative));
                    EDMG = Destroyer.DMG;
                    help = 4;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 4)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Defender.FILENAME;
                    EAG = Defender.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Defender.NAME}");
                    EnemyName.Content = Defender.NAME;
                    Enemy_HP.Maximum = Defender.HP; Enemy_HP.Value = Defender.HP;
                    Enemy_HP_Label.Content = Defender.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Defender.FILENAME}.png", UriKind.Relative));
                    EDMG = Defender.DMG;
                    help = 5;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 5)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Defender.FILENAME;
                    EAG = Defender.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Defender.NAME}");
                    EnemyName.Content = Defender.NAME;
                    Enemy_HP.Maximum = Defender.HP; Enemy_HP.Value = Defender.HP;
                    Enemy_HP_Label.Content = Defender.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Defender.FILENAME}.png", UriKind.Relative));
                    EDMG = Defender.DMG;
                    help = 6;
                    help2 = 1;
                }
                if (Enemy_HP.Value <= 0 && help == 6)
                {
                    help2 = 0;
                    sound1.Stop();
                    sound2.Stop();
                    MessageBox.Show($"{EnemyName.Content} has been destroyed. Mission successful.");
                    Win objMainWindow = new Win();
                    this.Visibility = Visibility.Hidden;
                    objMainWindow.Show();
                }
            }
            #endregion M3
            #region M4
            else if (Class2.ins.mission == 4)
            {
                if (Enemy_HP.Value <= 0 & help == 1)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = TIE.FILENAME;
                    EAG = TIE.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {TIE.NAME}");
                    EnemyName.Content = TIE.NAME;
                    Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
                    Enemy_HP_Label.Content = TIE.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
                    EDMG = TIE.DMG;
                    help = 2;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 2)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = TIE.FILENAME;
                    EAG = TIE.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {TIE.NAME}");
                    EnemyName.Content = TIE.NAME;
                    Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
                    Enemy_HP_Label.Content = TIE.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
                    EDMG = TIE.DMG;
                    help = 3;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 3)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = TIE.FILENAME;
                    EAG = TIE.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {TIE.NAME}");
                    EnemyName.Content = TIE.NAME;
                    Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
                    Enemy_HP_Label.Content = TIE.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
                    EDMG = TIE.DMG;
                    help = 4;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 4)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Interceptor.FILENAME;
                    EAG = Interceptor.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Interceptor.NAME}");
                    EnemyName.Content = Interceptor.NAME;
                    Enemy_HP.Maximum = Interceptor.HP; Enemy_HP.Value = Interceptor.HP;
                    Enemy_HP_Label.Content = Interceptor.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Interceptor.FILENAME}.png", UriKind.Relative));
                    EDMG = Interceptor.DMG;
                    help = 5;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 5)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Interceptor.FILENAME;
                    EAG = Interceptor.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Interceptor.NAME}");
                    EnemyName.Content = Interceptor.NAME;
                    Enemy_HP.Maximum = Interceptor.HP; Enemy_HP.Value = Interceptor.HP;
                    Enemy_HP_Label.Content = Interceptor.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Interceptor.FILENAME}.png", UriKind.Relative));
                    EDMG = Interceptor.DMG;
                    help = 6;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 6)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Destroyer.FILENAME;
                    EAG = Destroyer.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Destroyer.NAME}");
                    EnemyName.Content = Destroyer.NAME;
                    Enemy_HP.Maximum = Destroyer.HP; Enemy_HP.Value = Destroyer.HP;
                    Enemy_HP_Label.Content = Destroyer.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Destroyer.FILENAME}.png", UriKind.Relative));
                    EDMG = Destroyer.DMG;
                    help = 7;
                    help2 = 1;
                }
                if (Enemy_HP.Value <= 0 && help == 7)
                {
                    help2 = 0;
                    sound1.Stop();
                    sound2.Stop();
                    MessageBox.Show($"{EnemyName.Content} has been destroyed. Mission successful.");
                    Win objMainWindow = new Win();
                    this.Visibility = Visibility.Hidden;
                    objMainWindow.Show();
                }
            }
            #endregion M4
            #region M5
            else if (Class2.ins.mission == 5)
            {
                if (Enemy_HP.Value <= 0 & help == 1)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = TIE.FILENAME;
                    EAG = TIE.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {TIE.NAME}");
                    EnemyName.Content = TIE.NAME;
                    Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
                    Enemy_HP_Label.Content = TIE.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
                    EDMG = TIE.DMG;
                    help = 2;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 2)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = TIE.FILENAME;
                    EAG = TIE.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {TIE.NAME}");
                    EnemyName.Content = TIE.NAME;
                    Enemy_HP.Maximum = TIE.HP; Enemy_HP.Value = TIE.HP;
                    Enemy_HP_Label.Content = TIE.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{TIE.FILENAME}.png", UriKind.Relative));
                    EDMG = TIE.DMG;
                    help = 3;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 3)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Destroyer.FILENAME;
                    EAG = Destroyer.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Destroyer.NAME}");
                    EnemyName.Content = Destroyer.NAME;
                    Enemy_HP.Maximum = Destroyer.HP; Enemy_HP.Value = Destroyer.HP;
                    Enemy_HP_Label.Content = Destroyer.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Destroyer.FILENAME}.png", UriKind.Relative));
                    EDMG = Destroyer.DMG;
                    help = 4;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 4)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Destroyer.FILENAME;
                    EAG = Destroyer.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Destroyer.NAME}");
                    EnemyName.Content = Destroyer.NAME;
                    Enemy_HP.Maximum = Destroyer.HP; Enemy_HP.Value = Destroyer.HP;
                    Enemy_HP_Label.Content = Destroyer.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Destroyer.FILENAME}.png", UriKind.Relative));
                    EDMG = Destroyer.DMG;
                    help = 5;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 5)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Vader.FILENAME;
                    EAG = Vader.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has been destroyed.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Vader.NAME}");
                    EnemyName.Content = Vader.NAME;
                    Enemy_HP.Maximum = Vader.HP; Enemy_HP.Value = Vader.HP;
                    Enemy_HP_Label.Content = Vader.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Vader.FILENAME}.png", UriKind.Relative));
                    EDMG = Vader.DMG;
                    help = 6;
                    help2 = 1;
                }
                else if (Enemy_HP.Value <= 0 && help == 6)
                {
                    help2 = 0;
                    Player_HP.Maximum = HP;
                    sndE = Star.FILENAME;
                    EAG = Star.DOGE;
                    MessageBox.Show($"{EnemyName.Content} has escaped.");
                    await Task.Delay(200);
                    var sound1file = new Uri($@"mp3/{sndE}_FLY.mp3", UriKind.Relative);
                    sound1.Open(sound1file);
                    sound1.Play();
                    MessageBox.Show($"A new enemy has entered {PlayerName.Content}’s sights. It is a {Star.NAME}");
                    EnemyName.Content = Star.NAME;
                    Enemy_HP.Maximum = Star.HP; Enemy_HP.Value = Star.HP;
                    Enemy_HP_Label.Content = Star.HP;
                    enemy_img.Source = new BitmapImage(new Uri($@"Imgs/{Star.FILENAME}.png", UriKind.Relative));
                    EDMG = Star.DMG;
                    help = 7;
                    help2 = 1;
                }
                if (Enemy_HP.Value <= 0 && help == 7)
                {
                    help2 = 0;
                    sound1.Stop();
                    sound2.Stop();
                    MessageBox.Show($"{EnemyName.Content} has been destroyed. Mission successful.");
                    Win objMainWindow = new Win();
                    this.Visibility = Visibility.Hidden;
                    objMainWindow.Show();
                }
            }
            #endregion M5
        }
        private async void Player_HP_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            await Task.Delay(1000);
            var sound1 = new MediaPlayer();
            var sound2 = new MediaPlayer();
            if (Player_HP.Value <= 0 && help2 == 1)
            {
                sound1.Stop();
                sound2.Stop();
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
                AG = Falcon.DOGE;
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
                AG = X.DOGE;
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
                AG = Y.DOGE;
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
            EAG = TIE.DOGE;
            var sound1file1 = new Uri($@"mp3/TIE_Fighter_FLY.mp3", UriKind.Relative);
            sound1.Open(sound1file1);
            sound1.Play();
            MessageBox.Show($"A TIE Fighter enters {PlayerName.Content}’s sights.");
        }
        #endregion activation
    }
}