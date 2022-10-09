using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCILabs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            String inputUser = username.Text;
            if (username.Text == "abc" && pass.Text== "123")
            {

                mainScreen mainScreen = new mainScreen();
                this.Hide();
                mainScreen.Closed += (s, args) => this.Close();
                mainScreen.Show();
            }
            else if (!(username.Text == "abc")) {
                MessageBox.Show("your username it is not regester or wrong please try again!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (!(pass.Text == "123"))
            {
                MessageBox.Show("WRONG PASSWORD", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
