using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kayan_Yazı_V2._0
{
    public partial class Form1 : Form
    {

        string kelime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = label3.Text.Substring(1) + label3.Text.Substring(0,1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kelime = textBox1.Text;

            kelime=kelime.ToUpper();

            label3.Text = kelime;

            timer1.Start();
        }
    }
}
