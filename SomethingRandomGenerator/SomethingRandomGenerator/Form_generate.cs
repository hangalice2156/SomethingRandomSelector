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
    public partial class Form_generate : Form
    {
        //TODO: Read data form database and repensent the UI

        public Form_generate()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlConnection db = new SqlConnection();

        private void Form_generate_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.MainControl' 資料表。您可以視需要進行移動或移除。
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|Database1.mdf;" +
            "Integrated Security=True";
            db.ConnectionString = cn;
            //int row_count = 0;
            ds = new DataSet();
            SqlDataAdapter daMain = new SqlDataAdapter("SELECT * FROM MainControl", cn);
            daMain.Fill(ds, "MainControl");

            /*SqlDataAdapter daEat = new SqlDataAdapter("SELECT * FROM 東西吃啥", cn);
            daEat.Fill(ds, "東西吃啥");
            SqlDataAdapter daStudent = new SqlDataAdapter("SELECT * FROM 學生名單", cn);
            daStudent.Fill(ds, "學生名單");*/
            int row_count=ds.Tables[0].Rows.Count;
            //foreach (DataRow row in ds.Tables[0].Rows) row_count++;

            DataTableReader dtr = new DataTableReader(ds.Tables[0]);
            for (int i = 0; i < row_count; ++i)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + ds.Tables[0].Rows[i]["Name"], cn);
                da.Fill(ds, "" + ds.Tables[0].Rows[i]["Name"]);
            }

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "MainControl";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            control_index = e.RowIndex + 1;
            column_count = ds.Tables[control_index].Columns.Count;
            //foreach (DataRow row in ds.Tables[control_index].Rows) row_count++;
            //row_count = ds.Tables[control_index].Rows.Count;
            times=rnd.Next(30);
            timer1.Tick += change;
            //MessageBox.Show("" + + ds.Tables[control_index].Rows[rnd.Next(3)][1]+ ds.Tables[control_index].Rows[rnd.Next(3)][2]);
        }
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        int control_index, column_count,times;
        private void change(object sender,EventArgs e)
        {
            if (times == 0) timer1.Tick -= change;
            int rnd_out = rnd.Next(ds.Tables[control_index].Rows.Count);
            string output = "";
            for (int i = 1; i < column_count; ++i)
            {
                output += ds.Tables[control_index].Rows[rnd_out][i] + " ";
            }
            label1.Text = output;
            times--;
        }
    }
}
