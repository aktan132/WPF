
using System.Data.SQLite;
namespace tan.Model
{
     class Register
    {
        public string login;

        public string password;

        public Register() { }

        public Register(string Login, string Password)
        {
            this.Login = Login;

            this.Password = Password;
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public static void registerUser(Register register)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "INSERT INTO Users(Login,Password) VALUES (@Login,@Password )";

                command.Parameters.AddWithValue("@Login", register.Login);

                command.Parameters.AddWithValue("@Password", register.Password);

                command.ExecuteNonQuery();
            }
        }
    }
}
