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
using System.IO;
using System.Diagnostics;

namespace tan.Pages
{
    /// <summary>
    /// Логика взаимодействия для sorce.xaml
    /// </summary>
    public partial class sorce : Window
    {
        public sorce()
        {
            InitializeComponent();
            log.Content = App.Current.Resources["log"];
            pas.Content = App.Current.Resources["pass"];
         

            losa.Content = App.Current.Resources["sor"];
            losa1.Content = App.Current.Resources["sor2"];
            losa2.Content = App.Current.Resources["sor3"];
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {


            Close();
        }
        private void Drag(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                MainWindow.Wi.DragMove();
            }
        }

        private void sohr(object sender, RoutedEventArgs e)
        {
            string path = "sohr.txt"; // имя файла     

            StreamWriter sw = new StreamWriter(path); // создаём файл
            sw.WriteLine(log.Content);
            sw.WriteLine(pas.Content);
            sw.WriteLine(test1.Text);
            sw.WriteLine(losa.Content);
            sw.WriteLine(test2.Text);
            sw.WriteLine (losa1.Content);
            sw.WriteLine(test3.Text);
            sw.WriteLine(losa2.Content);
            sw.Close();
            Process.Start("notepad.exe", path);
        }
    }
}
