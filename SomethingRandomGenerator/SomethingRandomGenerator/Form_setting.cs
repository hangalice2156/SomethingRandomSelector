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
        int content_count;

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
                    textBox2.Text.Replace("'", "''") + "')";


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
            switch(textBox_add_table_number.Text)
            {
                case "1":
                    {
                        textBox7.Enabled = true;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        break;
                    }
                case "2":
                    {
                        textBox7.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = false;
                        break;
                    }
                case "3":
                    {
                        textBox7.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        break;
                    }
                default:
                    {
                        textBox7.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        label_count_table.Text = "請輸入1~3的數字";
                        break;
                    }
            }
        }
    }
}
