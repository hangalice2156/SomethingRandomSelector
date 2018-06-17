using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomethingRandomGenerator
{
    public partial class MainWindow : Form
    {
        private Form_generate F_ge;
        private Form_setting F_se;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            //TODO: Load From_generate with this button.

            F_ge = new Form_generate();
            this.Hide();
            if (F_ge.ShowDialog() != DialogResult.OK) this.Show();
        }

        private void button_setting_Click(object sender, EventArgs e)
        {
            //TODO: Load From_setting

            F_se = new Form_setting();
            this.Hide();
            if (F_se.ShowDialog() != DialogResult.OK) this.Show();
        }
    }
}
