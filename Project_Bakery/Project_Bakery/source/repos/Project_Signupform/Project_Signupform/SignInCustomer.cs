using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Signupform
{
    public partial class SignInCustomer : Form
    {
        public static string names;
        public SignInCustomer()
        {
            InitializeComponent();
        }

        private void SignInCustomer_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = @"Server=.\sqlexpress;Database=bakeshop;Integrated Security=true";
            SqlConnection con = new SqlConnection(constring);
            //con.Open();
            //MessageBox.Show("Farihaa");
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from OnlineCustomer where Name =  @Name and Email = @Email and Contact = @Contact", con);
            //SqlCommand cmd = new SqlCommand("Select * from Login1 where User_Name ='"+textBox1.Text+"' and Password1 = '"+textBox2.Text+"'", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@Email", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Contact", textBox3.Text.ToString());
            con.Open();
            //Console.WriteLine("hhehhehehehehe");
            var result = cmd.ExecuteScalar();
            //SqlDataAdapter result = new SqlDataAdapter();
            //result.SelectCommand = cmd;
            //result.Fill(dt);
            names = textBox1.Text;
            //MessageBox.Show(dr[1].ToString());
            if (result != null)
            {
                //MessageBox.Show("");
                var f10 = new menu();
                this.Hide();
                f10.Show();

            }
            else
            { MessageBox.Show("incorrect name/email/number"); }
            //string qry = "INSERT INTO MyTable (MyName) VALUES('" + textBox1.Text +  "')";
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
