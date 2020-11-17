using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace kursa4
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bdlog = "";
            string bdpwd = "";
            using var connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
            connectionDB.Open();

            using var cmdr = new SQLiteCommand($"SELECT * FROM admin", connectionDB);
            using SQLiteDataReader rdr = cmdr.ExecuteReader();
            while (rdr.Read())
            {
                bdlog = (string)rdr["login"];
                bdpwd = (string)rdr["password"];
            }
            connectionDB.Close();
                if (guestcheckbox.Checked == true)
            {
                //LOGIN AS A GUEST

                mainlist.root = false;
                mainlist.status = true;
                this.Close();
            } else if (textBox1.Text == bdlog && textBox2.Text == bdpwd)
            {
                //LOGIN AS AN ADMIN

                mainlist.root = true;
                mainlist.status = true;
                this.Close();
            } else
            {
                //MESSAGEBOX WARNING

                var result = MessageBox.Show("Некорректный логин или пароль. Войдите как гость.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
