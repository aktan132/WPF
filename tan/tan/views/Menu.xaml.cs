using System;
using System.Windows;


namespace tan.views
{
    
    public partial class Menu : Window
    {
        public Menu(string login)
        {
            InitializeComponent();
            log.Content = login;
            losa.Content = login;
         
          
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
            // PagesNavigation.Navigate(new HomePage());
        
            PagesNavigation.Navigate(new System.Uri(" Pages/teoria.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdSounds_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/UserControl2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdNotes_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/NotesPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdPayment_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/parametr.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdSounds_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
