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
        SqlConnection db = new SqlConnection();
        int control_index; // for knowing which table user is looking.
        int row_count;

        public Form_setting()
        {
            InitializeComponent();
        }

        private void Form_setting_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|Database1.mdf;" +
            "Integrated Security=True";
            db.ConnectionString = cn;

            ds = new DataSet();
            SqlDataAdapter daMain = new SqlDataAdapter("SELECT * FROM MainControl", cn);
            daMain.Fill(ds, "MainControl");
            
            row_count = 0; //reset
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row_count++;
            }
            for(int i = 0; i < row_count; ++i)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + ds.Tables[0].Rows[i]["Name"] , cn);
                da.Fill(ds, ""+ds.Tables[0].Rows[i]["Name"]);
            }

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
            try
            {
                control_index = e.RowIndex + 1;
                dataGridView2.DataMember = ds.Tables[control_index].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("請使用輸入介面添加新項目");
            }
        }

        private void button_add_content_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                //MessageBox.Show(ds.Tables[control_index] + " , " + ds.Tables[control_index].Columns[1]);
                cmd.CommandText = "INSERT INTO " + ds.Tables[control_index] + 
                    "(" + ds.Tables[control_index].Columns[0] + "," +  
                    ds.Tables[control_index].Columns[1] + "," + 
                    ds.Tables[control_index].Columns[2] + "," +
                    ds.Tables[control_index].Columns[3] + ")" + 
                    "VALUES('" +
                    textBox_add_content.Text.Replace("'", "''") + "','" +
                    textBox2.Text.Replace("'", "''") + "','" +
                    textBox3.Text.Replace("'", "''") + "','" +
                    textBox4.Text.Replace("'", "''") + "')";


                cmd.ExecuteNonQuery();
                db.Close();
                Form_setting_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("請檢察輸入是否有誤或編號重複!");
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = "UPDATE " + ds.Tables[control_index] + " SET "+ ds.Tables[control_index].Columns[1] + "='" + textBox2.Text.Replace("'", "''") + "'," +
                    ds.Tables[control_index].Columns[2] + "='" + textBox3.Text.Replace("'", "''") + "'," +
                    ds.Tables[control_index].Columns[3] + "='" + textBox4.Text.Replace("'", "''") + "'" +
                    " WHERE " + ds.Tables[control_index].Columns[0] + "='" + textBox_add_content.Text.Replace("'", "''") + "'";
                    
                /*cmd.CommandText = "UPDATE 學生名單 SET 姓名='" + textBox2.Text.Replace("'", "''") + "'" +
                    " WHERE 學號='" + textBox_add_content.Text.Replace("'", "''") + "'";*/

                cmd.ExecuteNonQuery();
                db.Close();
                Form_setting_Load(sender, e);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("請檢察輸入是否有誤!");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "DELETE FROM " + ds.Tables[control_index] + 
                    " WHERE " + ds.Tables[control_index].Columns[0] + "='" + textBox_add_content.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                Form_setting_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_add_table_number_TextChanged(object sender, EventArgs e)
        {
            switch(textBox_table_number.Text)
            {
                case "1":
                    {
                        textBox_add_1.Enabled = true;
                        textBox_add_2.Enabled = false;
                        textBox_add_3.Enabled = false;
                        break;
                    }
                case "2":
                    {
                        textBox_add_1.Enabled = true;
                        textBox_add_2.Enabled = true;
                        textBox_add_3.Enabled = false;
                        break;
                    }
                case "3":
                    {
                        textBox_add_1.Enabled = true;
                        textBox_add_2.Enabled = true;
                        textBox_add_3.Enabled = true;
                        break;
                    }
                default:
                    {
                        textBox_add_1.Enabled = false;
                        textBox_add_2.Enabled = false;
                        textBox_add_3.Enabled = false;
                        label_count_table.Text = "請輸入1~3的數字";
                        break;
                    }
            }
        }

        private void button_add_table_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                
                string column_1 = ((textBox_add_1.Text != "") ? textBox_add_1.Text : "項目一");
                string column_2 = ((textBox_add_2.Text != "") ? textBox_add_2.Text : "項目二");
                string column_3 = ((textBox_add_3.Text != "") ? textBox_add_3.Text : "項目三");

                //MessageBox.Show(column_1 + "," + column_2 + "," + column_3);
                cmd.CommandText = "CREATE TABLE " +
                    textBox_table_name.Text + "(編號 VARCHAR (50) NOT NULL, " +
                    column_1 + " VARCHAR (50) NULL, " +
                    column_2 + " VARCHAR (50) NULL, " +
                    column_3 + " VARCHAR (50) NULL, " +
                    "PRIMARY KEY (編號) " +
                    ")";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO " + ds.Tables[0] +
                    "(" + ds.Tables[0].Columns[0] + "," +
                    ds.Tables[0].Columns[1] + "," +
                    ds.Tables[0].Columns[2] + ")" +
                    "VALUES('" +
                    textBox_table_id.Text.Replace("'", "''") + "','" +
                    textBox_table_name.Text.Replace("'", "''") + "','" +
                    textBox_table_number.Text.Replace("'", "''") + "')";

                cmd.ExecuteNonQuery();
                db.Close();
                Form_setting_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
