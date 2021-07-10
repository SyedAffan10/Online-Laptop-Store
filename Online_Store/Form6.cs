using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Online_Store
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // For Email Validation
            string pattern = @"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            if(Regex.IsMatch(textBox4.Text,pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox4, "Please Provide Valid Email Address");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = (textBox1.Text);
           string number = (textBox2.Text);
            string address = (textBox3.Text);
            string email = (textBox4.Text);
            DAL dal = new DAL();
            dal.insert(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text);
            MessageBox.Show("Now your Information is in process");
            progressBar1.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000000;
            for(int i=0;i<progressBar1.Maximum;i++)
            {
                progressBar1.Value = i;
            }
            string message = "Would you like to buy another ?";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 store = new Form1();
                store.Show();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }
    }
}
