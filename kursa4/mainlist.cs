using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Specialized;
using System.Collections;
using System.IO;
using System.Diagnostics.Tracing;

namespace kursa4
{
    
    public partial class mainlist : Form
    {
        internal static bool root; /*ADMIN RIGHTS DETECTING BOOL*/
        internal static bool status = false; /*IS USER LOGGED IN?*/
        internal static string selectedItem; /*variable which contains ID of chosen item in search itembox in string*/

        public mainlist()
        {
            //CREATING LOGIN FORM

            InitializeComponent();
            login focusform = new login();
            focusform.ShowDialog();

            //CONNECTING DATABASE

            collectAll();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                login focusform = new login();
                focusform.ShowDialog();
            }
            else
                /*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*/
                //RETURN TO LOGIN FORM

                /*if (focusform.Visible == false)
                {*/
                //    focusform.ShowDialog();
                /*} else
                {
                    focusform.BringToFront();
                }*/
                /*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*//*QUESTIONABLE SHIT*/
            {
                /*SEARCH*//*SEARCH*//*SEARCH*//*SEARCH*//*SEARCH*//*SEARCH*//*SEARCH*//*SEARCH*//*SEARCH*/

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
                        sebox.Items.Add("ID[" + reader["id"] + "] Model: " + reader["model"] + ", Firm: " + reader["firm"] + ", Year: " + reader["year"] + ", Country: " + reader["country"] + ", Form: " + reader["form"] + ", Material: " + reader["material"] + ", Num: " + reader["num"] + ".");
                    }
                }
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
                sebox.Items.Add("ID[" + rdr["id"] + "] Model: " + rdr["model"] + ", Firm: " + rdr["firm"] + ", Year: " + rdr["year"] + ", Country: " + rdr["country"] + ", Form: " + rdr["form"] + ", Material: " + rdr["material"] + ", Num: " + rdr["num"] + ".");
            }
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
                    //sebox.SelectedItem = 1; // selectedItem;
                }
                else
                {
                    MessageBox.Show("Вы не обладаете правами администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteSelectedItem()
        {
            getID(sebox.Items, sebox.SelectedIndex);
            if (selectedItem != null)
            {
                using var connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
                connectionDB.Open();
                using var cmd = new SQLiteCommand(connectionDB);

                using var cmdr = new SQLiteCommand("SELECT * FROM guitars WHERE ID = " + selectedItem + "", connectionDB);
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

                cmd.CommandText = @"DELETE FROM guitars WHERE ID = " + selectedItem + "";
                cmd.ExecuteNonQuery();
            }
        }
        private void getID(ListBox.ObjectCollection itemBoxList, int selectedID)
        {
            string t = "";
            try
            {
                t = (string)itemBoxList[selectedID];
                int pFrom = t.IndexOf("[") + "[".Length;
                int pTo = t.LastIndexOf("]");

                if (t.Substring(pFrom, pTo - pFrom) != null)
                {
                    mainlist.selectedItem = t.Substring(pFrom, pTo - pFrom);
                }
                return;
            } catch 
            {
                MessageBox.Show("Выберите образец в списке");
                return;
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
                getID(sebox.Items, sebox.SelectedIndex);
                if (selectedItem != null)
                {
                    showObr showForm = new showObr();
                    showForm.Show();
                }
            }
        }
    }
}
