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
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Msgs msg = new Msgs();
            this.Hide();
            msg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DrageDrop dragDrop = new DrageDrop();
            this.Hide();
            dragDrop.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wordpad wordpad = new wordpad();
            wordpad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenusTooltip mT = new MenusTooltip();
            this.Hide();
            mT.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep();
        }
    }
}
