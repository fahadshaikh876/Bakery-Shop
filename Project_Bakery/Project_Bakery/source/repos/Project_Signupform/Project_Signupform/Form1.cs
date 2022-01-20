using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Signupform
{
    public partial class Form1 : Form
    {
        public static bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("bellliaaa");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("bellliaaa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
            var f3 = new SignUp();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            var f1 = new SignINCHOICE();
            this.Hide();
            f1.Show();
        }
    }
}
