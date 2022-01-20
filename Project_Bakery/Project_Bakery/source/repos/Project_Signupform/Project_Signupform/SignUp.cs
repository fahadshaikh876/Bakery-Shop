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
    public partial class SignUp : Form
    {
        public static string names;
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Server=.\sqlexpress;Database=bakeshop;Integrated Security=true";
            SqlConnection con = new SqlConnection(constring);
            

            //SqlCommand cmd0 = new SqlCommand("SELECT idCustomer FROM OnlineCustomer WHERE idCutsomer = (SELECT max(idCustomer) FROM OnlineCustomer", con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter reader = new SqlDataAdapter("SELECT * FROM OnlineCustomer", con);
            con.Open();
            //reader.Fill(dt);
            ////int count = cmd0.ExecuteNonQuery();
            ////SqlDataAdapter reader = cmd0.ExecuteReader();

            ////count++;
            //int count = new int();
            //count = dt.Rows.Count;
            SqlCommand cmd = new SqlCommand("insert into OnlineCustomer values (@id, @name, @email, @no)", con);
            cmd.Parameters.AddWithValue("@id", 62);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@no", textBox4.Text);
            names = textBox2.Text;

            //if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            //{
            //    try
            //{
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                //MessageBox.Show("data inserteed");
                var menu = new menu(); //to be made 
                this.Hide();
                menu.Show();
            }
            else { MessageBox.Show("data not given properly"); }

            //catch (Exception e)
            //{
            //    Console.WriteLine("Error Generated. Details: " + e.ToString());
            //}
            con.Close();
        } 
        //}
            private void SignUp_Load(object sender, EventArgs e)
            {
            
            }
        } }

        
    

