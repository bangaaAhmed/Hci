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
    public partial class wordpad : Form
    {
        public wordpad()
        {
            InitializeComponent();
            Graphics g = richTextBox1.CreateGraphics();
            foreach (FontFamily fontFamily in FontFamily.GetFamilies(g))
            {
                fonts.Items.Add(fontFamily.Name);
            }
            for (int i = 7; i <= 70; i += 7)
            {
                fontSize.Items.Add(i.ToString());
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (font != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, font.Style ^ FontStyle.Bold);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, font.Style ^ FontStyle.Italic);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, font.Style ^ FontStyle.Underline);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void SetNewFont()
        {
            Font oldFont, newFont;
            String fontName;
            float fz = 8;
            FontStyle fontStyle;
            byte charset = 0;

            fontName = fonts.Text;
            if (string.IsNullOrEmpty(fontSize.Text))
                fz = 8;
            else
                fz = float.Parse(fontSize.Text);

            oldFont = richTextBox1.SelectionFont;

            if (oldFont == null)
                fontStyle = FontStyle.Regular;
            else
            {
                fontStyle = oldFont.Style;
                charset = oldFont.GdiCharSet;
            }

            newFont = new Font(fontName, fz, fontStyle, GraphicsUnit.Point, charset);
            richTextBox1.SelectionFont = newFont;
        }

        private void fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mainScreen mScreen = new mainScreen();
            mScreen.Show();
            this.Hide();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will added soon :)");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will added soon :)");

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }
    }
}
