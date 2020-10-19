using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                string mahang = Convert.ToString(txtMahang.Text);
                Double donGia = Convert.ToDouble(txtDonGia.Text);
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                Double tien;

                if (checkBox1.Checked == true)
                {
                    if (radioButton1.Checked == true)
                    {
                        tien = (donGia * soLuong) - ((donGia * soLuong) * 0.05);
                        txtTien.Text = tien.ToString();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        tien = (donGia * soLuong) - ((donGia * soLuong) * 0.1);
                        txtTien.Text = tien.ToString();
                    }
                }
                else
                {
                    tien = (donGia * soLuong);
                    txtTien.Text = tien.ToString();
                }
            }
            catch (Exception) {
                MessageBox.Show("Hãy điền đầy đủ thông tin và đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
        }
    }
}
