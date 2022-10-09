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
    public partial class DrageDrop : Form
    {
        int index = 0;
        public DrageDrop()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainScreen main = new mainScreen();
            this.Hide();
            main.Show();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            index = listBox.IndexFromPoint(e.X, e.Y);
            if (index >= 0 & e.Button == MouseButtons.Left) {
                listBox.DoDragDrop(listBox.Items[index].ToString(),DragDropEffects.Move);
            }

        }

        private void listBox2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {

                e.Effect = DragDropEffects.Move;
            }
            else {
                e.Effect = DragDropEffects.None;
            }

        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listboxx = sender as ListBox;
            listboxx.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            listBox1.Items.RemoveAt(index);
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }
    }
}
