using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmmmmmmm
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 j = new Form5();
            j.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 n = new Form4();
            n.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 y = new Form6();
            y.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 o = new Form2();
            o.Show();
            Hide();
        }
    }
}
