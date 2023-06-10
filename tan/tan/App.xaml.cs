using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace tan
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string databaseName = "userss.db";

        static string databaseDir = Environment.CurrentDirectory;

        public static string databasePath = Path.Combine(databaseDir, databaseName);
        public static string connString = "Data Source=" + databasePath;
    }
}

