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
namespace mmmmmmmm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);
            int c = a * b;
            textBox4.Text = c.ToString();

            int m = Convert.ToInt32(textBox5.Text);
            int n = Convert.ToInt32(textBox6.Text);
            int net = c + m - n;
            textBox7.Text=net.ToString();
            int o = Convert.ToInt32(textBox8.Text);
            int back = o - net;
            textBox9.Text = back.ToString();
            

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\METHON\Documents\Visual Studio 2013\Projects\mmmmmmmm\mmmmmmmm\mmmmm.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO tofa (name,Quantity,Price,subprice,vat,discount,netpay,paid,retamount) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", cn1);


            try
            {

                cmd1.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved.");
            }

            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form7 l = new Form7();
            l.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\METHON\Documents\Visual Studio 2013\Projects\mmmmmmmm\mmmmmmmm\mmmmm.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            cn1.Open();

            //con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from tofa", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            cn1.Close();
        }
    }
}

