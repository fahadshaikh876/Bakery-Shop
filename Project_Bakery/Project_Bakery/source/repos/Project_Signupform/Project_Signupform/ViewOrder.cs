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

    public partial class ViewOrder : Form
    {
        public static string names;
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                Console.WriteLine(label2.Text);
                Console.WriteLine(label1.Text);
                Console.WriteLine("Address: " + richTextBox1.Text);
                Console.WriteLine("Order placed Date/time: " + DateTime.Now.ToString());
                Console.WriteLine("delivery date\time: " + dateTimePicker1.Text);
                MessageBox.Show("Order Placed, Thankyou");
                //+ "\n" + "Total Amount: " + Cart.total.ToString() + "\n" + "Adress: " + richTextBox1.Text + "\n" + "Order placed Date/time: " + DateTime.Now.ToString() + "\n" + "delivery date\time: " + dateTimePicker1.CustomFormat.ToString() + "\n")
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Insert Correct Adress");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = new Admin_View_Order();
            this.Hide();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            label1.Text = ("Total Amount: "+Cart.total.ToString());
            if (Form1.flag == true) {
                label2.Text = "Name: " + SignInCustomer.names;
            }
            else
            {
                label2.Text = "Name: " + SignUp.names;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
