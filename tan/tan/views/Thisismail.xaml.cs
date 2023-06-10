using System;
using System.Windows;
using tan.Pages;

namespace tan.views
{
   
    public partial class Thisismail : Window
    {
        public Thisismail(string login, string password)
        {
            InitializeComponent();
            log.Content = login;
    
            losa.Content = login;
            pas.Content = password;
           
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

         
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
            

            PagesNavigation.Navigate(new System.Uri(" Pages/teoria.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdSounds_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Zadan.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdNotes_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/menutest.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdPayment_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/parametr.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdSounds_Checked(object sender, RoutedEventArgs e)
        {
        }

        public void rd_Click(object sender, RoutedEventArgs e)
        {
            string login = (string)log.Content;
            string password = (string)pas.Content;
 

            
           
            
        }
    }
}
