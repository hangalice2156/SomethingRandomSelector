using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace SomethingRandomGenerator
{
    public partial class Form_setting : Form
    {
        //TODO: Let user browse and customize database

        DataSet ds;
        public Form_setting()
        {
            InitializeComponent();
        }

        private void Form_setting_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|Database1.mdf;" +
            "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);

            ds = new DataSet();
            SqlDataAdapter daMain = new SqlDataAdapter("SELECT * FROM MainControl", cn);
            daMain.Fill(ds, "MainControl");
            SqlDataAdapter daEat = new SqlDataAdapter("SELECT * FROM 東西吃啥", cn);
            daEat.Fill(ds, "東西吃啥");
            SqlDataAdapter daStudent = new SqlDataAdapter("SELECT * FROM 學生名單", cn);
            daStudent.Fill(ds, "學生名單");

            dataGridView1.DataSource = ds;
            dataGridView2.DataSource = ds;

            dataGridView1.DataMember = "MainControl";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView2.DataMember = ds.Tables[e.RowIndex + 1].ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataMember = ds.Tables[e.RowIndex + 1].ToString();
        }
    }
}
