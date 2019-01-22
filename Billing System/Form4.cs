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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\METHON\Documents\Visual Studio 2013\Projects\mmmmmmmm\mmmmmmmm\mmmmm.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            cn1.Open();
            
            //con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from ms", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            cn1.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Form7 a = new Form7();
            a.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\METHON\Documents\Visual Studio 2013\Projects\mmmmmmmm\mmmmmmmm\mmmmm.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("delete from ms where Customer_id='" + textBox1.Text + "'", cn1);


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

        private void btnadd_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox5.Text);
            int tot = a * b;
            textBox4.Text = tot.ToString();

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\METHON\Documents\Visual Studio 2013\Projects\mmmmmmmm\mmmmmmmm\mmmmm.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO ms (Customer_id,Product_Name,Quantity,Price,Total) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox5.Text + "','" + textBox4.Text + "')", cn1);

            
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
    }
}
