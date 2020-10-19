using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            txtTongTien.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String ten = Convert.ToString(txtTen.Text);
                Double tien = 0;
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin và đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (checkBox1.Checked == true)
                    {
                        tien += 100000;
                    }
                    if (checkBox2.Checked == true)
                    {
                        tien += 1500000;
                    }
                    if (numericUpDown1.Value != 0)
                    {
                        int so1 = Convert.ToInt32(numericUpDown1.Value);
                        tien = so1 * 150000;
                    }
                    if (numericUpDown2.Value != 0)
                    {
                        int so2 = Convert.ToInt32(numericUpDown2.Value);
                        tien = so2 * 200000;
                    }
                    txtTongTien.Text = tien.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin và đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
