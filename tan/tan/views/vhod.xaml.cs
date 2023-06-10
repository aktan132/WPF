
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using tan.Model;


namespace tan.views
{
 
    public partial class vhod : Page
    {
        ApplicationContext context;
     
        public vhod()
        {
            InitializeComponent();
            context = new ApplicationContext();

        }

  

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new avtorization());
        }

        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;

        }

        private void Button_Click56(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Txpassword.Password == "admin" && Txlogin.Text == "Admin")
            {
                Menu taskWindow = new Menu(Txpassword.Password);
                taskWindow.Show();
                Application.Current.MainWindow.Close();
            }
            else
            {

                string login = Txlogin.Text;
                string password = Txpassword.Password;
                if (login.Length < 5)
                {
                    Txlogin.ToolTip = "Это поле введено некорректно";
                    Txlogin.Background = Brushes.Green;
                }

                else if (password.Length < 5)
                {
                    Txlogin.ToolTip = "Это поле введено некорректно";
                    Txpassword.Background = Brushes.Green;
                }
                else
                {
                    Txlogin.ToolTip = "";
                    Txlogin.Background = Brushes.Transparent;
                    Txpassword.ToolTip = "";
                    Txpassword.Background = Brushes.Transparent;


                    using (ApplicationContext context = new ApplicationContext())
                    {
                        User authUser = null;
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            authUser = db.Users.Where(b => b.login == login && b.password ==
                            password).FirstOrDefault();
                        }

                        if (authUser != null)
                        {

                            animeloading taskWindow = new animeloading(login,password);
                            taskWindow.Show();
                            Application.Current.MainWindow.Close();
                            App.Current.Resources["log"] = login;
                            App.Current.Resources["pass"] = password;
                        }
                        else
                            MessageBox.Show("Вы ввели что-то некорректно");
                    }

                }
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}

