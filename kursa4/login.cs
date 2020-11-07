using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (guestcheckbox.Checked == true)
            {
                //LOGIN AS A GUEST

                mainlist.root = false;
                mainlist.status = true;
                this.Close();
            } else if (textBox1.Text == "admin" && textBox2.Text == "password")
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
