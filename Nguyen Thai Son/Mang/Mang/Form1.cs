using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Mang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] a;
        public String s = "";
        public int n;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void nhap(int[] a, int n) {
            n = Int32.Parse(textBox1.Text);
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Interaction.InputBox("Nhập dữ liệu cho phần tử thứ " + (i + 1) + "", "Thông báo", "", -1, -1));
            }
            for (int i = 0; i < n; i++)
            {
                s += " " + a[i];
            }
        }

        int tong(String s1)
        {
            int sum = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != ' ')
                {
                    sum += Int32.Parse(s1[i].ToString());
                }
            }
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhap(a, n);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " " + s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = tong(s);
            textBox3.Text = "" + sum;
        }
    }
}
