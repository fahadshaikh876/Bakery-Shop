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

    public partial class Cart : Form
    {
        //public static string names = menu.names;
        //List<DataGridViewRow> newss = new List<DataGridViewRow>();
        public DataGridViewRow[] newss = new DataGridViewRow[100];
        public static int total = 0;
        //protected List<string> list = new List<string>();
        public Cart(DataGridViewRow[] faa)
        {
            //this.newss = faa;
            //MessageBox.Show(faa[0].Cells[1].Value.ToString());
            //Console.WriteLine(faa[0].Cells[1].Value.GetType());
            this.newss = faa;
            
            
            InitializeComponent();
            
            
        }
        
       
        //List<DataGridViewRow> dt = new List<DataGridViewRow>();
        //public Cart(DataGridViewRow r)
        //{
        //    //InitializeComponent();
        //}

      

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new ViewOrder();
            this.Hide();
            f2.Show();

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < newss.Length; i++)
            {
                if (newss[i] != null)
                {
                    string[] aa = new string[2];
                    aa[0] = newss[i].Cells[0].Value.ToString();
                    aa[1] = newss[i].Cells[1].Value.ToString();
                    ListViewItem it = new ListViewItem(aa[0]);
                   
                    //it.SubItems.Add(aa[0]);
                    it.SubItems.Add(aa[1]);
                    listView2.Items.Add(it);
                }
            }
            listView2.View = View.Details;
            //    listView2.Items.Add("sknsa");
            //    listView2.Items.Add("faas");
            //ListViewItem itme = new ListViewItem();
            //itme.SubItems.Add("hello");

            //for (int i = 0; i < newss.Length; i++)
            //{


            //    ListViewItem item = new ListViewItem(this.newss[i].Cells[0].Value.ToString());
            //    item.SubItems.Add(this.newss[i].Cells[1].Value.ToString());
            //    listView1.Items.Add(item);
            //    //listView1.Items.Add(newss[i].Cells[1].Value.ToString());

            //    //item.SubItems.Add(item);


            for (int i = 0; i < newss.Length; i++)
            {
                if (newss[i] != null)
                {
                    total += Convert.ToInt32(newss[i].Cells[1].Value);
                }
                //MessageBox.Show(total.ToString());
                textBox2.Text = "Rs. "+ total.ToString();
            }


            //}
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
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
