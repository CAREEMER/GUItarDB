using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace kursa4
{
    
    public partial class mainlist : Form
    {
        internal static bool root; /*ADMIN RIGHTS DETECTING BOOL*/
        internal static bool status = false; /*IS USER LOGGED IN?*/
        internal static string selectedItem; /*variable which contains ID of chosen item in search itembox in string*/
        internal static List<string> itemList = new List<string> { };

        public mainlist()
        {

            InitializeComponent();
            login focusform = new login();
            focusform.ShowDialog();

            collectAll();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                login focusform = new login();
                focusform.ShowDialog();
            }
            {
                List<string> specs = new List<string>
                {
                    "year",
                    "country",
                    "firm",
                    "model",
                    "form",
                    "material",
                    "num"
                };

                using var connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
                connectionDB.Open();
                if (listBox1.SelectedIndex == -1)
                {
                    var result = MessageBox.Show("Вы не выбрали категорию поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sebox.Items.Clear();
                    using var cmdr = new SQLiteCommand("SELECT * FROM guitars WHERE " + specs[listBox1.SelectedIndex] + " = '" + searchbox.Text + "'", connectionDB);
                    using SQLiteDataReader reader = cmdr.ExecuteReader();

                    while (reader.Read())
                    {
                        sebox.Items.Add($"ID[{reader["id"]}] Model: {reader["model"]}, Firm: {reader["firm"]}, Year: {reader["year"]}, Country: {reader["country"]}, Form: {reader["form"]}, Material: {reader["material"]}, Num: {reader["num"]}.");
                    }
                }
                connectionDB.Close();
            }
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                login focusform = new login();
                focusform.ShowDialog();
            }
            else
            {
                if (root == true)
                {
                    addobr additform = new addobr();
                    additform.Show();
                }
                else
                {
                    MessageBox.Show("Вы не обладаете правами администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void collectAll()
        {
            using var connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
            connectionDB.Open();
            using var cmdr = new SQLiteCommand("SELECT * FROM guitars", connectionDB);
            using SQLiteDataReader rdr = cmdr.ExecuteReader();

            while (rdr.Read())
            {
                sebox.Items.Add($"ID[{rdr["id"]}] Model: {rdr["model"]}, Firm: {rdr["firm"]}, Year: {rdr["year"]}, Country: {rdr["country"]}, Form: {rdr["form"]}, Material: {rdr["material"]}, Num: {rdr["num"]}.");
                itemList.Add(Convert.ToString(rdr["id"]));
            }
            connectionDB.Close();
        }

        private void buttonDeleteObr_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                login focusform = new login();
                focusform.ShowDialog();
            }
            else
            {
                if (root == true)
                {
                    deleteSelectedItem();
                    sebox.Items.Clear();
                    collectAll();
                }
                else
                {
                    MessageBox.Show("Вы не обладаете правами администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteSelectedItem()
        {
            getID(sebox.SelectedIndex);
            if (selectedItem != null)
            {
                using var connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
                connectionDB.Open();
                using var cmd = new SQLiteCommand(connectionDB);

                using var cmdr = new SQLiteCommand($"SELECT * FROM guitars WHERE ID = {selectedItem}", connectionDB);
                using SQLiteDataReader rdr = cmdr.ExecuteReader();
                string fn = "";
                while (rdr.Read())
                {
                    fn += rdr["pic"];
                }
                try
                {
                    if (File.Exists(Path.Combine(@"C:\GUIdbPics", fn)))
                    {
                        File.Delete(Path.Combine(@"C:\GUIdbPics", fn));
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cmd.CommandText = $"DELETE FROM guitars WHERE ID = {selectedItem}";
                cmd.ExecuteNonQuery();
                connectionDB.Close();
            }
        }
        private void getID(int selectedID)
        {
            if (selectedID != -1)
            {
                selectedItem = itemList[selectedID];
            } else
            {
                selectedItem = null;
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                login focusform = new login();
                focusform.ShowDialog();
            }
            else
            {
                sebox.Items.Clear();
                collectAll();
            }
        }

        private void buttonShowObr_Click(object sender, EventArgs e)
        {   
            if (status == false)
            {
                login focusform = new login();
                focusform.ShowDialog();
            }
            else
            {
                getID(sebox.SelectedIndex);
                if (selectedItem != null)
                {
                    showObr showForm = new showObr();
                    showForm.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                login focusform = new login();
                focusform.ShowDialog();
            }
            else
            {
                settings focusforum = new settings();
                focusforum.ShowDialog();
            }
        }
    }
}
