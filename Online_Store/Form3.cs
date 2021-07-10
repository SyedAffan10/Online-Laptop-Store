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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Processor : Intel Core i5 - 8265U CPU \n RAM : 8GB \n Harddisk : 256GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 90, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Dell Inspiron 15 7000";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 dell6 = new Form6();
                dell6.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string message = "Processor : Quad - Core 1.6GHz Intel Core i5 processor \n RAM : 16GB \n Harddisk : 128GB SSD \n LCD : 13.3″ HD Touchscreen Touch Screen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 105, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Dell Inspiron 7370";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 dell6 = new Form6();
                dell6.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Processor : Intel Core i3 - 330M 2 x 2.1 GHz \n RAM : 8GB \n Harddisk : 128GB SSD \n LCD : 14.1″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 45, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Dell Inspiron 1464";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 dell6 = new Form6();
                dell6.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string message = "Processor : Ci7 7th Gen \n RAM : 16GB \n Harddisk : 512GB SSD \n LCD : 13.3″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 195, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop ?\n _________________________________ ";
            string title = "Dell XPS 13 9365 2-In-1";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 dell6 = new Form6();
                dell6.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1dell = new Form1();
            f1dell.Show();
        }
    }
}