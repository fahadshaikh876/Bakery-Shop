using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data.SqlClient;

namespace Project_Signupform
{
    public partial class SignInAdmin : Form
    {
        public SignInAdmin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignInAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox3.Name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Name);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox2.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Server=.\sqlexpress;Database=bakeshop;Integrated Security=true";
            SqlConnection con = new SqlConnection(constring);
            //con.Open();
            //MessageBox.Show("Farihaa");
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select idLogin from Login1 where User_Name =  @Username and Password1 = @password", con);
            //SqlCommand cmd = new SqlCommand("Select * from Login1 where User_Name ='"+textBox1.Text+"' and Password1 = '"+textBox2.Text+"'", con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@password", textBox2.Text.ToString());
            con.Open();
            //Console.WriteLine("hhehhehehehehe");
            var result = cmd.ExecuteScalar();
            //SqlDataAdapter result = new SqlDataAdapter();
            //result.SelectCommand = cmd;
            //result.Fill(dt);
            
            //MessageBox.Show(dr[1].ToString());
            if (result!= null)
            {
                //MessageBox.Show("");
                var f1 = new Admin_View();
                this.Hide();
                f1.Show();

            }
                else
                { MessageBox.Show("incorrect name/email/number"); }
            //string qry = "INSERT INTO MyTable (MyName) VALUES('" + textBox1.Text +  "')";
            con.Close();
           // SqlCommand cmd = new SqlCommand(qry, con);
            //cmd.ExecuteNonQuery();
        }
    }
}
