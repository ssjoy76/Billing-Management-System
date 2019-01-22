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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\METHON\Documents\Visual Studio 2013\Projects\mmmmmmmm\mmmmmmmm\mmmmm.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO mg (Customer_id,Customer_Name,Email,Address,Phone_No) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", cn1);


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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\METHON\Documents\Visual Studio 2013\Projects\mmmmmmmm\mmmmmmmm\mmmmm.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("delete from mg where Customer_id='" + textBox1.Text + "'", cn1);


            try
            {

                cmd1.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted.");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();

            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\METHON\Documents\Visual Studio 2013\Projects\mmmmmmmm\mmmmmmmm\mmmmm.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            cn1.Open();

            //con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from mg", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            cn1.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form7 u = new Form7();
            u.Show();
            Hide();
        }
    }
}
