using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace kursa4
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void changepwdbutton_Click(object sender, EventArgs e)
        {
            string oldpwd = textboxoldpwd.Text;
            string newpwd = textboxnewpwd.Text;
            string bdpwd = "";

            try
            {
                SQLiteConnection connectionDB;
                connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
                connectionDB.Open();

                using var cmdr = new SQLiteCommand($"SELECT * FROM admin", connectionDB);
                using SQLiteDataReader rdr = cmdr.ExecuteReader();
                while (rdr.Read())
                {
                    bdpwd = Convert.ToString(rdr["password"]);
                }
                if (oldpwd != bdpwd){
                    MessageBox.Show("Неправильный старый пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using var cmd = new SQLiteCommand(connectionDB);
                    cmd.CommandText = $"DELETE FROM admin";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"INSERT INTO admin(login, password) VALUES('admin', '{newpwd}')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Пароль успешно изменён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
