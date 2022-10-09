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
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingBanner.Width += 30;
            int loadingpercentge = loadingBanner.Width / 3;
            percent.Text = loadingpercentge.ToString();

            if (loadingBanner.Width >= 300)
            {
                timer1.Stop();
                var login = new Login();
                this.Hide();
                login.Closed += (s, args) => this.Close();
                login.Show();
            }
        }
    }
}
