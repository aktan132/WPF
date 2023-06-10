
using System.Windows.Controls;


namespace tan.Pages
{
    
    public partial class Zadan : Page
    {
        public Zadan()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new uveren());
        }

        private void PagesNavigation_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
