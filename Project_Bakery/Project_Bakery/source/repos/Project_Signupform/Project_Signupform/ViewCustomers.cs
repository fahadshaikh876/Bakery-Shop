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
    public partial class ViewCustomers : Form
    {
        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ViewCustomers();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {

            string constring = @"Server=.\sqlexpress;Database=bakeshop;Integrated Security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from OnlineCustomer", con);
            //cmd.Parameters.AddWithValue("@id", 11);
            //cmd.Parameters.AddWithValue("@name", textBox2.Text)
            //cmd.Parameters.AddWithValue("@email", textBox3.Text);
            //cmd.Parameters.AddWithValue("@no", textBox4.Text);

            //SqlDataReader result = cmd.ExecuteReader();
            DataTable table = new DataTable();
            cmd.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f3 = new Admin_View();
            this.Hide();
            f3.Show();

            

        }
    }
}
