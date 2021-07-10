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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        } 

        private void pictureBox5_Click(object sender, EventArgs e)
        {         
            string message = "Processor : Intel Core i5 - 450G(4 x 2.1 GHz) \n RAM : 8GB \n Harddisk : 128GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price: 65, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop \n _________________________________ ";
            string title = "HP Probook 450 G7";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                Form6 hp6 = new Form6();
                hp6.Show();
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            string message = "Processor : Intel Core i3 - 854U \n RAM : 12GB \n Harddisk : 256GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 70, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop \n _________________________________ ";
            string title = "HP Notebook Pro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 hp6 = new Form6();
                hp6.Show();
            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            string message = "Processor : Ci7 8th Gen \n RAM : 16GB \n Harddisk : 512GB SSD \n LCD : 15.6″ HD Touchscreen \n Keyboard : Backlit \n Installation : Win 10 Pro \n Price : 125, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop \n _________________________________ ";
            string title = "HP Chromobook 15 9365 2-In-1";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 hp6 = new Form6();
                hp6.Show();
            }
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            string message = "Processor : Quad - Core 2.50 GHz Intel Core i7 processor \n RAM : 16GB \n Harddisk : 128GB SSD \n LCD : 15.6″ HD Touchscreen Touch Screen \n Keyboard : Backlit Installation : Win 10 Pro \n Price : 105, 000 \n \n _________________________________ \n Do You Want To Buy This Laptop \n _________________________________ ";
            string title = "HP Ryzen";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form6 hp6 = new Form6();
                hp6.Show();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}