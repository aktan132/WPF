
namespace tan.Model
{
    class User
    {
        public int Id { get; set; }
        public string Login, Password, Name, Otchestvo, Familia;
        public User() { }
        public string login
        {
            get { return Login; }
            set { Login = value; }
        }
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string otchestvo
        {
            get { return Otchestvo; }
            set { Otchestvo = value; }
        }
        public string familia
        {
            get { return Familia; }
            set { Familia = value; }
        }



        public User(string Login, string Password, string Name,string Otchestvo, string Familia)
        {
            
        }
    }
}
