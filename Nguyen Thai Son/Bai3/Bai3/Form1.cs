using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Lỗi!\nBạn phải chọn một mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (listBox1.Items.Count != 0) {
                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.Remove(listBox1.Items[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count < 1)
            {
                MessageBox.Show("Lỗi!\nBạn phải chọn một mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (listBox2.Items.Count != 0)
            {
                listBox1.Items.Add(listBox2.Items[0]);
                listBox2.Items.Remove(listBox2.Items[0]);
            }
        }
    }
}
