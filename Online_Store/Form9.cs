using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Store
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.delete(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Record has been Deleted.....");
            textBox1.Clear();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-0B0HEJ3\SQLEXPRESS; Initial Catalog = online_store; Integrated Security = True");
            string sel = "select * from info";
            SqlDataAdapter ad = new SqlDataAdapter(sel, conn);
            conn.Open();
            DataTable dt = new DataTable(); 
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.insert(textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text);
            MessageBox.Show("Record has been inserted....."); 
            textBox2.Clear(); 
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
    
}
