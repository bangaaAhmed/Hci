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
    public partial class Msgs : Form
    {
        public Msgs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warnning", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Question", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainScreen mainScreen = new mainScreen();
            this.Hide();
            mainScreen.Show();
        }
    }
}
