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
using tan.Model;

namespace tan.views
{
    /// <summary>
    /// Логика взаимодействия для avtorization.xaml
    /// </summary>

    public partial class avtorization : Page
    {
        //private User _currentUser = new User();
        ApplicationContext db;
        public avtorization()

        {
            InitializeComponent();
            db = new ApplicationContext();

            // DataContext = _currentUser;
            //CmbRole.ItemsSource = AppData.db.Role.ToList();
        }

        //  private void Save_Btn_click(object sender, RoutedEventArgs e)
        //{
        //  User people = new User();
        //people.Login = LoginTxb.Text;
        //pople.Password = Password_Txb.Text;
        //people.ID = (int)DateTime.Now.Ticks;
        // Беру данные из Комбобокса
        //var CurrentRole = CmbRole.SelectedItem as Role;

        //people.RoleID = CurrentRole.ID;
        //AppData.db.User.Add(people);
        //AppData.db.SaveChanges();

        //NavigationService.Navigate(new priv());
        //}

        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        //   private void Save_Btn_click43(object sender, RoutedEventArgs e)
        //   {
        //      using (ApplicationContext db = new ApplicationContext())
        //   {
        //        var login = LoginTxb.Text;
        //      var pass = Password_Txb.Text;
        //      if (login.Length < 1)
        //    {
        //        LoginTxb.ToolTip = "Это поле введено некорректно";
        //       LoginTxb.Background = Brushes.Green;
        //   }
        //  else if (pass.Length < 1)
        //  {
        //     Password_Txb.ToolTip = "Это поле введено некорректно";
        //      Password_Txb.Background = Brushes.Green;
        //  }
        //  else
        //  {
        //    LoginTxb.ToolTip = "";
        //    LoginTxb.Background = Brushes.Transparent;
        //   Password_Txb.ToolTip = "";
        //   Password_Txb.Background = Brushes.Transparent;

        //if (login != null && pass != null)
        //    {
        //    db.Users.Add(new User() { Login = login, Password = pass, });
        //   db.SaveChanges();
        //     NavigationService.Navigate(new priv());
        //  }
        //   else
        //  {
        //       MessageBox.Show("Вы ввели что-то некорректно");
        //   }
        //  }

        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_vhod(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new vhod());
        }

        private void Save_Btn_click431(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();

            reg.Login = LoginTxb.Text;
            reg.Password = Password_Txb.Text;
            if( (LoginTxb.Text.Length < 5 ) || (LoginTxb.Text.Length > 11))
            {
                LoginTxb.Text = "поле введено неккоректно";
            }

            else if ((Password_Txb.Text.Length < 5) || (Password_Txb.Text.Length > 11))
            {
                Password_Txb.Text = "поле введено неккоректно";
            }
            else
            {
       
             

                Register.registerUser(reg);




                NavigationService.Navigate(new priv());


            }
        }
    }
}
