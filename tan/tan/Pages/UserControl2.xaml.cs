using DemoLibrary;
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

using tan.Model;

namespace tan.Pages
{
   

    public partial class UserControl2 : UserControl
    {
        List<User> Users = new List<User>();
        User selectedPerson = new User();

        public UserControl2(  )
        {
            InitializeComponent();
   

        }
        private void LoadPeopleList()
        {
            Users = SqliteDataAccess.LoadPeople();

            WireUpPeopleList();
        }
        private void WireUpPeopleList()
        {
            listPeopleListBox.ItemsSource = null;
            listPeopleListBox.Items.Clear();
            listPeopleListBox.ItemsSource = Users;
        }
        private void refreshUI()
        {
            LoadPeopleList();
            ResetUserInputUI();
        }
        private void ResetUserInputUI()
        {
            idText.Text = "";
            firstNameText.Text = "";
            lastNameText.Text = "";
            NameText.Text = "";
            editBtn.IsEnabled = false;
        }
        private void SelectedPerson()
        {
            selectedPerson = Users[listPeopleListBox.SelectedIndex];

            idText.Text = selectedPerson.Id.ToString();
            firstNameText.Text = selectedPerson.Login;
            lastNameText.Text = selectedPerson.Password;
            NameText.Text = selectedPerson.Name;
        }
        private void addPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            User p = new User();

            p.Login = firstNameText.Text;
            p.Password = lastNameText.Text;
            p.Name = NameText.Text;

            SqliteDataAccess.SavePerson(p);
            WireUpPeopleList();
            ResetUserInputUI();
            refreshUI();
        }
        private void refreshListBtn_Click(object sender, RoutedEventArgs e)
        {
            refreshUI();
        }
        private void ListBoxItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SelectedPerson();
            editBtn.IsEnabled = true;
            deleteBtn.IsEnabled = true;

        }
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            selectedPerson.Login = firstNameText.Text;
            selectedPerson.Password = lastNameText.Text;
            selectedPerson.Name = NameText.Text;
            SqliteDataAccess.EditPerson(selectedPerson);
            refreshUI();
        }
        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            List<User> selectedPersons = new List<User>();

            if (listPeopleListBox.SelectedItems.Count > 0)
            {
                foreach (User selPerson in listPeopleListBox.SelectedItems)
                {
                    selectedPersons.Add(selPerson);
                }
            }
            else
            {


                
            }
            SqliteDataAccess.DeleteMultiplePerson(selectedPersons);
            refreshUI();
        }
        private void findBtn_Click(object sender, RoutedEventArgs e)
        {
            string login;
            string password;
            string name;

            name = NameText.Text;
            login = firstNameText.Text;
            password = lastNameText.Text;

            Users = SqliteDataAccess.FindPeople(login, password);

            WireUpPeopleList();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {


        }

        private void firstNameText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
