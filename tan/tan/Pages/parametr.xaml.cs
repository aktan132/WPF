using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tan.Pages
{
    /// <summary>
    /// Lógica de interacción para HomePage.xaml
    /// </summary>
    public partial class parametr : Page
    {
        public parametr()
        {
            InitializeComponent();
        }

        MediaPlayer player = new MediaPlayer();
        string filename;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Dark(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"Styles/LightTheme.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Button_Click_green(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"Styles/DarkTheme.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Button_Click_Open(object sender, RoutedEventArgs e)
        {

            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Media files (*.mp3;*.mpg;*.mpeg)|*.mp3;*.mpg;*.mpeg|All files (*.*)|*.*";

            bool? dialaof = FileDialog.ShowDialog();
            if (dialaof == true)
            {
                filename = FileDialog.FileName;
                fileopens.Text = FileDialog.SafeFileName;
                player.Open( new Uri(filename));
            }
        }

        private void Button_Click_Play(object sender, RoutedEventArgs e)
        {
            player.Play();
            sliderPosition.Maximum = player.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void Button_Click_Pause(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }
        private void sliderPosition_ValueChanged(object sender, RoutedEventArgs e)
        {
            
            player.Pause();
            player.Position = TimeSpan.FromSeconds(sliderPosition.Value);
            player.Play();
        }
        private void sliderPosition_ValueChanged1(object sender, RoutedEventArgs e)
        {

         
            player.Volume = (sliderPosition1.Value);
  
        }

        private void Button_Click_blue(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"Styles/BlueTheme.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Button_Click_i(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/tan132") { UseShellExecute = true });
        }
    }
}
