using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace kursa4
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
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
            SQLiteConnection m_dbConnection;

            if (File.Exists(@"C:\guitars.sqlite") == false)
            {
                SQLiteConnection.CreateFile(@"C:\guitars.sqlite");
            }

            m_dbConnection = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
            m_dbConnection.Open();

            using var cmd = new SQLiteCommand(m_dbConnection);
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS guitars (id INTEGER PRIMARY KEY, year INT, country TEXT, firm TEXT, model TEXT, form TEXT, material TEXT, num INT, pic TEXT)";
            cmd.ExecuteNonQuery();
            /*string cntr = "russia";
            string numb = "4";
            string frst = "ауди";*/

            /*cmd.CommandText = "INSERT INTO guitars(year, country, firm, model, form, material, num, pic) VALUES(2008, 'Russia', 'Mitsubishi', 'retard', 'tttt', 'tree', 4, 'fgfgfg')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(year, country, firm, model, form, material, num, pic) VALUES(2045, 'Russia', 'Mitsubishi', 'retard', 'tggggt', 'tree', 4, 'fgfgfg')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(year, country, firm, model, form, material, num, pic) VALUES(2008, 'Russia', 'Mitsubishi', 'resfsshfd', 'tttt', 'tree', 4, 'fgfgfg')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(year, country, firm, model, form, material, num, pic) VALUES(2038, 'Russia', 'Mitsubishi', 'reghghd', 'tttt', 'tree', 4, 'fgfgfg')";
            cmd.ExecuteNonQuery();*/
            /*frst = "ауди2";
            numb = "5";
            cmd.CommandText = "INSERT INTO guitars(name, year, country) VALUES('" + frst + "'," + numb + ",'" + cntr + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(name, year, country) VALUES('" + frst + "'," + numb + ",'" + cntr + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(name, year, country) VALUES('" + frst + "'," + numb + ",'" + cntr + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(name, year, country) VALUES('" + frst + "'," + numb + ",'" + cntr + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(name, year, country) VALUES('" + frst + "'," + numb + ",'" + cntr + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(name, year, country) VALUES('" + frst + "'," + numb + ",'" + cntr + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO guitars(name, year, country) VALUES('" + frst + "'," + numb + ",'" + cntr + "')";
            cmd.ExecuteNonQuery();*/
        }
    }
}
