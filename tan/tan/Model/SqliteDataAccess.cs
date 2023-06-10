using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using tan.Model;

namespace DemoLibrary
{
 class SqliteDataAccess
    {
        public static List<User> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
                var output = cnn.Query<User>("select * from Users", new DynamicParameters());
        
                return output.ToList();
            }
        }
        public static void SavePerson(User Users)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Users (Login, Password) values (@Login, @Password)", Users);
            }
        }
        public static void EditPerson(User selectedPerson)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
              
                cnn.Execute("UPDATE Users SET(Login, Password) = (@Login, @Password) WHERE Id = @Id", selectedPerson);
            }
        }
        public static void DeletePerson(User selectedPerson)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Users WHERE Id = @Id", selectedPerson);
            }
        }
        public static void DeleteMultiplePerson(List<User> selectedPersons)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                foreach (User selPerson in selectedPersons)
                {
                    cnn.Execute("DELETE FROM Users WHERE Id = @Id", selPerson);
                }
            }
        }
        public static List<User> FindPeople(string firstname, string lastname )
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var param = new Dictionary<string, object>()
                {
                    ["Login"] = $"%{firstname}%",
                    ["Password"] = $"%{lastname}%"

                   
                };

                var output = cnn.Query<User>("SELECT * FROM Users WHERE Login LIKE @Login AND Password  LIKE @Password ", param);
                return output.ToList();
            }
        }
        private static string LoadConnectionString(string id = "DefaultConnection")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
