using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace kursa4
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DBinit();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainlist());

        }

        static void DBinit()
        {
            SQLiteConnection connectionDB;

            if (File.Exists(@"C:\guitars.sqlite") == false)
            {
                SQLiteConnection.CreateFile(@"C:\guitars.sqlite");
            }

            connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
            connectionDB.Open();

            using var cmd = new SQLiteCommand(connectionDB);
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS guitars (id INTEGER PRIMARY KEY, year INT, country TEXT, firm TEXT, model TEXT, form TEXT, material TEXT, num INT, pic TEXT)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS admin (id INTEGER PRIMARY KEY, login TEXT, password TEXT)";
            cmd.ExecuteNonQuery();

            string login = "admin";
            string password = "password";
            bool status = false;

            using var cmdr = new SQLiteCommand($"SELECT * FROM admin", connectionDB);
            using SQLiteDataReader rdr = cmdr.ExecuteReader();

            while (rdr.Read())
            {
                if (rdr["login"] != "" && rdr["password"] != "")
                {
                    status = true;
                }
            }

            if (!status)
            {
                cmd.CommandText = @$"INSERT INTO admin (login, password) VALUES ('{login}', '{password}')";
                cmd.ExecuteNonQuery();
            }
            connectionDB.Close();
        }
    }
}
