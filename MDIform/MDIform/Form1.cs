using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIform
{
    public partial class Form1 : Form
    {
        public bool chonDam=false, chonNghieng=false, gachChan=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FontFamily[] ff = FontFamily.Families;
            for (int i = 0; i < ff.Length; i++)
            {
                toolStripComboBox1.Items.Add(ff[i].Name);
            }
            for (int i = 8; i <= 72; i++)
            {
                toolStripComboBox2.Items.Add(i);
            }
            
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim() == "")
            {
                return;
            }
            richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, richTextBox1.Font.Size);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text.Trim() == "")
            {
                return;
            }
            richTextBox1.SelectionFont = new Font(toolStripComboBox1.Font.Name, (float)Convert.ToDouble(toolStripComboBox2.Text));
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (chonDam == false)
            {
                chonDam = true;
                tstrB.BackColor = Color.Gray;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Bold);
            }
            else {
                chonDam = false;
                tstrB.BackColor = Color.White;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Bold);
            }
            
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (chonNghieng == false)
            {
                chonNghieng = true;
                toolStripButton10.BackColor = Color.Gray;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Italic);
            }
            else {
                toolStripButton10.BackColor = Color.White;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Italic);
            }  
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (gachChan == false)
            {
                gachChan = true;
                toolStripButton11.BackColor = Color.Gray;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Underline);
            }
            else {
                toolStripButton11.BackColor = Color.White;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Underline);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text Files (*.doc)|*.docx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
            } 
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Files (*.doc)|*.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
            } 
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
