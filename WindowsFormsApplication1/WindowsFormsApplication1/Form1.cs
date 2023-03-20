using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fillbtn_Click(object sender, EventArgs e)
        {
            wishlist.Items.Add("Diploma");
            wishlist.Items.Add("House n LOT");
            wishlist.Items.Add("Happy Life");
            wishlist.Items.Add("Iphone 20");
            wishlist.Items.Add("1M");
        }

        private void wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = wishlist.Text;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Sortbtn_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }

        private void Countbtn_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
