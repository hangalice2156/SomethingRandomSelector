﻿using System;
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
        System.Media.SoundPlayer player = new System.Media.SoundPlayer("./music.wav");
        bool[] record;
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

            control_index = 1;
            column_count = ds.Tables[control_index].Columns.Count;
            record = new bool[ds.Tables[control_index].Rows.Count];
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            control_index = e.RowIndex + 1;
            column_count = ds.Tables[control_index].Columns.Count;
            record = new bool[ds.Tables[control_index].Rows.Count];
            //MessageBox.Show("" + + ds.Tables[control_index].Rows[rnd.Next(3)][1]+ ds.Tables[control_index].Rows[rnd.Next(3)][2]);
        }
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        int control_index,times, column_count;

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.OpenFile());
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    sw.WriteLine(random_result(!checkBox1.Checked));
                }
                for (int i = 0; i < record.Count(); i++)
                {
                    record[i] = false;
                }
                sw.Close();
            }
        }

        private void change(object sender,EventArgs e)
        {
            if (times <= 0) timer1.Tick -= change;
            else
            {
                label1.Text = random_result(false);
                times--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 50;
            timer1.Tick += change;
            player.Play();
        }

        private string random_result(bool need_record) {
            int rnd_out=0,row_count= ds.Tables[control_index].Rows.Count;
            for(int i=0;i< row_count; ++i)
            {
                if (!record[i])
                {
                    rnd_out = 1;
                    break;
                }
            }
            if (rnd_out == 0) return "Empty";
            do
            {
                rnd_out = rnd.Next(ds.Tables[control_index].Rows.Count);
            } while (record[rnd_out]);
            if(need_record) record[rnd_out] = true;
            string output = "";
            for (int i = 1; i < column_count; ++i)
            {
                output += ds.Tables[control_index].Rows[rnd_out][i] + " ";
            }
            return output;
        }
    }
}
