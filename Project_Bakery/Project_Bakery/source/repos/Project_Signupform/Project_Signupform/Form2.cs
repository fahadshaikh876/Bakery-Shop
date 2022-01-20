using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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
    public partial class menu : Form
    {
        //public static string names;
       
        public menu()
        {
            InitializeComponent();
        }
        DataGridViewRow[] dta = new DataGridViewRow[100];
        int count = 0;

        //List<DataGridViewRow> dt = new List<DataGridViewRow>();
        //public menu(DataGridViewRow r)

        //{ 
        //}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dataGridView1.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            //{

            //}
            if (e.ColumnIndex == 3)
            {
                //MessageBox.Show("Clicked"+e.RowIndex);
                //Grid.CurrentCell = Grid.Rows(0).Cells(0);
                
                dta[count] = dataGridView1.Rows[e.RowIndex];
                count++;
                //dt.Add(dataGridView1.Rows[e.RowIndex]);

                Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            }
        }

        private void menu_Load(object sender, EventArgs e)
        {
            //names = SignUp.names;

            // TODO: This line of code loads data into the 'bakeshopDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.bakeshopDataSet.Items);
            string constring = @"Server=.\sqlexpress;Database=bakeshop;Integrated Security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select name,price,Picture from Items", con);
            //cmd.Parameters.AddWithValue("@id", 11);
            //cmd.Parameters.AddWithValue("@name", textBox2.Text)
            //cmd.Parameters.AddWithValue("@email", textBox3.Text);
            //cmd.Parameters.AddWithValue("@no", textBox4.Text);
        
            //SqlDataReader result = cmd.ExecuteReader();
            DataTable table = new DataTable();
            
            table.Columns.Add("Pic", Type.GetType("System.Byte[]"));

            cmd.Fill(table);
            foreach (DataRow r in table.Rows)
            {
                r["Pic"] = File.ReadAllBytes(Application.StartupPath+"/Pictures/p1.jpg");
                //Console.WriteLine(r["Picture"].ToString());
                //Console.WriteLine(Application.StartupPath);
            }
            //int number_of_rows = dataGridView1.RowCount;
            //int i = 0;
            //foreach (DataRow r in table.Rows)
            //{
            //    //Image img = new Bitmap(r[2].ToString());
            //    //dataGridView1["Picture", i].Value= img;
            //    dataGridView1["Name", i].Value = r[0].ToString();
            //    dataGridView1["Price", i].Value = r[1].ToString();
            //}
            

            //table.Load(result);
            //table.Columns.Add("Picture", Type.GetType("System.Byte[]"));

       
            dataGridView1.DataSource = table;
      


            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    Console.WriteLine(dataGridView1. 
            //}
            //foreach ( row in datagridviews.Rows)
            //{
            //    currQty += row.Cells["qty"].Value;
            //    //More code here
            //}

            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBy(this.bakeshopDataSet.Items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Cart(dta);
            this.Hide();
            f1.Show();

        }
    }
}
