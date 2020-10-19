using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                if (checkedListBox1.GetItemChecked(i) == true) {
                    string item = checkedListBox1.Items[i].ToString();
                    checkedListBox2.Items.Add(item);
                    checkedListBox1.Items.RemoveAt(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i) == true)
                {
                    string item = checkedListBox2.Items[i].ToString();
                    checkedListBox1.Items.Add(item);
                    checkedListBox2.Items.RemoveAt(i);
                }
            }
        }
    }
}
