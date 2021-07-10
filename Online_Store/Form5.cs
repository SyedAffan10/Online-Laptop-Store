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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Processor : Ci7 8th Gen \n RAM : 16GB \n Harddisk : 512GB SSD \n LCD : 13″ HD Touchscreen \n Keyboard : Backlit \n Price : 110, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Apple Mackbook 15";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 Apple6 = new Form6();
                Apple6.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string message = "Processor : Quad - Core 2.50 GHz Intel Core i7 processor \n RAM : 16GB \n Harddisk : 128GB SSD \n LCD : 15.6″ HD Touchscreen Touch Screen \n Keyboard : Backlit \n Price : 105, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Apple Mackbook 2017";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 Apple6 = new Form6();
                Apple6.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Processor : Intel Core i5(4 x 2.1 GHz) \n RAM : 8GB \n Harddisk : 128GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Price : 140, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Apple Mackbook 2018";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 Apple6 = new Form6();
                Apple6.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string message = "Processor : Core i7 10 Generation(1.5 Ghz) \n RAM : 16GB \n Harddisk : 256GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Price : 135, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Apple Mackbook Pro 2020";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 Apple6 = new Form6();
                Apple6.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fApple6 = new Form1();
            fApple6.Show();
        }
    }
}
