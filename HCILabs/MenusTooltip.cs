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
    public partial class MenusTooltip : Form
    {
        ContextMenuStrip cm = new ContextMenuStrip();

        public MenusTooltip()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenusTooltip_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mainScreen mScreen = new mainScreen();
            this.Hide();
            mScreen.Show();
        }
    }
}
