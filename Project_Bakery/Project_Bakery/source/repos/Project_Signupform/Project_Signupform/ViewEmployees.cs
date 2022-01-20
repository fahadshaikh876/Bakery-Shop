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
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            string constring = @"Server=.\sqlexpress;Database=bakeshop;Integrated Security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from Employee", con);
            SqlDataAdapter cmd2 = new SqlDataAdapter("select * from DeliveryPerson", con);
            //cmd.Parameters.AddWithValue("@id", 11);
            //cmd.Parameters.AddWithValue("@name", textBox2.Text)
            //cmd.Parameters.AddWithValue("@email", textBox3.Text);
            //cmd.Parameters.AddWithValue("@no", textBox4.Text);

            //SqlDataReader result = cmd.ExecuteReader();
            DataTable table = new DataTable();
            cmd.Fill(table);
            dataGridView1.DataSource = table;

            DataTable table2 = new DataTable();
            cmd2.Fill(table2);
            dataGridView2.DataSource = table2;

            con.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = new Admin_View();
            this.Hide();
            f1.Show();
        }
    }
}
