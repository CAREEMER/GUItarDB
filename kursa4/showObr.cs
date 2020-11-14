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

namespace kursa4
{
    public partial class showObr : Form
    {
        public showObr()
        {
            using var connectionDB = new SQLiteConnection(@"Data Source=C:\guitars.sqlite;Version=3;");
            connectionDB.Open();
            using var cmd = new SQLiteCommand(connectionDB);
            if (mainlist.selectedItem != null)
            {
                InitializeComponent();
                using var cmdr = new SQLiteCommand("SELECT * FROM guitars WHERE ID = " + mainlist.selectedItem + "", connectionDB);
                using SQLiteDataReader rdr = cmdr.ExecuteReader();
                while (rdr.Read())
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(Convert.ToString(rdr["pic"]));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("У данного образца нет изображения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (Convert.ToString(rdr["pic"]) == "")
                    {
                        picNameLabel.Visible = false;
                    }
                    else
                    {
                        picNameLabel.Text = Convert.ToString(rdr["pic"]);
                    }
                    textBoxCountry.Text = Convert.ToString(rdr["country"]);
                    textBoxModel.Text = Convert.ToString(rdr["model"]);
                    textBoxFirm.Text = Convert.ToString(rdr["firm"]);
                    textBoxYear.Text = Convert.ToString(rdr["year"]);
                    textBoxForm.Text = Convert.ToString(rdr["form"]);
                    textBoxMaterial.Text = Convert.ToString(rdr["material"]);
                    textBoxNum.Text = Convert.ToString(rdr["num"]);
                }
            }
        }
    }
}
