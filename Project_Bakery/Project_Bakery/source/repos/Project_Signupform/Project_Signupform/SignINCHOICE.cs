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
    public partial class SignINCHOICE : Form
    {
        
        public SignINCHOICE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var f3 = new SignInAdmin();
            this.Hide();
            f3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f4 = new SignInCustomer(); //to be made 
            this.Hide();
            f4.Show();
        }

        private void SignINCHOICE_Load(object sender, EventArgs e)
        {

        }
    }
}
