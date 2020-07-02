using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0702
{
    public partial class Form1 : Form
    {

        int a;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;

            button1.Visible = false;

            button2.Text = a + "回目";
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a++;

            button1.Visible = true;

            button1.Text = a + "回目";
            button2.Visible = false;
        }
    }
}
