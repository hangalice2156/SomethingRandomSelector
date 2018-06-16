using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomethingRandomSelector
{
    public partial class MainWindow : Form
    {
        //Mainwindow is to control all components of the program, everything starts here.
        //用來開啟其他部件的主視窗台，用這個Form 來開啟其他的Form.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_What_to_eat_Click(object sender, EventArgs e)
        {
            //TODO: Open Form_Eating with this button.

        }
    }
}
