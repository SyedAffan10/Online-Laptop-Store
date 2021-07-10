using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Store
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL(); bool check = dal.Online_Store(textBox1.Text, textBox2.Text);
            if (check == true)
            {
                progressBar1.Show(); 
                progressBar1.Minimum = 0; 
                progressBar1.Maximum = 2000000; 
                for (int i = 0; i <= 2000000; i++)
                {
                    progressBar1.Value = i;
                }
                Form9 f9 = new Form9();
                f9.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Invalid user name and/or password.... ");
                textBox1.Clear(); 
                textBox2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }
    }
}
