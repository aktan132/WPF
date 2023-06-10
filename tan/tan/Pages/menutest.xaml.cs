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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tan.Pages
{
    /// <summary>
    /// Логика взаимодействия для menutest.xaml
    /// </summary>
    public partial class menutest : Page
    {
       

        public menutest()
        {
            InitializeComponent();
          
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_EAZY(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new test());
        }

        private void Button_ClickL_LVL3(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new test3());
        }

        private void Button_ClickL_LVL2(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new test2());
        }

        private void chet(object sender, RoutedEventArgs e )
        {
          sorce taskWindow = new sorce();

            taskWindow.Show();
        }
    }
}
