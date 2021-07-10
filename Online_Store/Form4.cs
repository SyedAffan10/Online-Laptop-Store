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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Processor : Quad - Core 2.50 GHz Intel Core i7 processor \n RAM : 16GB \n Harddisk : 128GB SSD \n LCD : 15.6″ HD Touchscreen Touch Screen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 125, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Lenevo Ideapad Gaming";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 lenevo6 = new Form6();
                lenevo6.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string message = "Processor : Ci7 8th Gen \n RAM : 16GB \n Harddisk : 512GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 140, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Lenevo Ideapad";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 lenevo6 = new Form6();
                lenevo6.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Processor : Intel Core i3 - 854U \n RAM : 12GB \n Harddisk : 256GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 80, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Lenevo Andrean";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 lenevo6 = new Form6();
                lenevo6.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string message = "Processor : Intel Core i5 - 450G(4 x 2.1 GHz) \n RAM : 8GB \n Harddisk : 128GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 95, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Lenevo Ideapad 330s";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 lenevo6 = new Form6();
                lenevo6.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fLenevo6 = new Form1();
            fLenevo6.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
