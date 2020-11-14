using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace kursa4
{
    public partial class addobr : Form
    {
        internal static string filePath = "";
        protected bool validData;

        public addobr()
        {
            InitializeComponent();
            ((Control)pictureBox1).AllowDrop = true;
        }

        private void choosefile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"c:\\";
                openFileDialog.Filter = @"Jpg files (*.jpg)|*.jpg|Png files (*.png)|*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    addobr.filePath = openFileDialog.FileName;
                }
                label2.Visible = true;
                label2.Text = filePath;
            }
        }

        private void addObj_Click(object sender, EventArgs e)
        {
            bool statusObj = false; 
            string newFilePath = "";
            if (addobr.filePath.Contains(".png"))
            {
                newFilePath = @"c:\\GUIdbPics\" + DateTime.Now.ToString("HHmmss") + textBoxModel.Text + ".png";
            }
            else if (addobr.filePath.Contains(".jpg"))
            {
                newFilePath = @"c:\\GUIdbPics\" + DateTime.Now.ToString("HHmmss") + textBoxModel.Text + ".jpg";
            }
            else if (addobr.filePath == "")
            {
                newFilePath = "NaN";
            }
            SQLiteConnection connectionDB;
            connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
            connectionDB.Open();

            using var cmd = new SQLiteCommand(connectionDB);

            try
            {
                cmd.CommandText = "INSERT INTO guitars(year, country, firm, model, form, material, num, pic) VALUES(" + Convert.ToInt32(textBoxYear.Text) + ", '" + textBoxCountry.Text.Replace('[', '{').Replace(']', '}') + "', '" + textBoxFirm.Text.Replace('[', '{').Replace(']', '}') + "', '" + textBoxModel.Text.Replace('[', '{').Replace(']', '}') + "', '" + textBoxForm.Text.Replace('[', '{').Replace(']', '}') + "', '" + textBoxMaterial.Text.Replace('[', '{').Replace(']', '}') + "', " + Convert.ToInt32(textBoxNum.Text) + ", '" + newFilePath + "')";
                cmd.ExecuteNonQuery();
                statusObj = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (filePath != "")
            {
                if (Directory.Exists(@"c:\\GUIdbPics") == false)
                {
                    Directory.CreateDirectory(@"c:\\GUIdbPics");
                }
                try
                {
                    File.Copy(filePath, newFilePath, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (statusObj == true)
            {
                MessageBox.Show("Запись добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
            }
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            filePath = (string)filePaths[0];

            label2.Visible = true;
            label2.Text = filePath;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
