using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinQPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void load()
        {
            NhanvienDataContext db = new NhanvienDataContext();
            var q = db.NHANVIENs.Select(p => new { p.MANV, p.HOTEN, p.NGAYSINH, p.DIACHI, p.DIENTHOAI, p.HSLUONG, p.MADONVI, LUONG=p.HSLUONG*1490000});
            var c = db.DONVIs.Select(k => new { k.MADONVI });
            var sum = db.NHANVIENs.Sum(p => p.HSLUONG * 1490000);
            dataGridView1.DataSource = q;
            comboBox1.ValueMember = "MADONVI";
            comboBox1.DataSource = c;
            textBox7.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NhanvienDataContext db = new NhanvienDataContext();
            var q = db.NHANVIENs.Select(p => new { p.MANV, p.HOTEN, p.NGAYSINH, p.DIACHI, p.DIENTHOAI, p.HSLUONG, p.MADONVI,LUONG=p.HSLUONG*1490000});
            var sum = db.NHANVIENs.Sum(p => p.HSLUONG * 1490000);
            var c = db.DONVIs.Select(k => new { k.MADONVI });
            dataGridView1.DataSource = q;
            comboBox1.ValueMember = "MADONVI";
            comboBox1.DataSource = c;
            textBox7.Text = sum.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            NhanvienDataContext db = new NhanvienDataContext();
            var q = db.NHANVIENs.Where(p => p.HOTEN.Contains(textBox8.Text)).Select(p => new { p.MANV, p.HOTEN, p.NGAYSINH, p.DIACHI, p.DIENTHOAI, p.HSLUONG, p.MADONVI });
            dataGridView1.DataSource = q;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanvienDataContext db = new NhanvienDataContext();
            NHANVIEN dv = new NHANVIEN();
            dv.MANV = Convert.ToInt32(textBox1.Text);
            dv.HOTEN = textBox2.Text;
            dv.NGAYSINH = textBox3.Text;
            dv.DIACHI = textBox4.Text;
            dv.DIENTHOAI = textBox5.Text;
            dv.HSLUONG = Convert.ToDouble(textBox6.Text);
            dv.MADONVI = Convert.ToInt32(comboBox1.Text);
            db.NHANVIENs.InsertOnSubmit(dv);
            db.SubmitChanges();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentCell.RowIndex;
            NhanvienDataContext db = new NhanvienDataContext();
            NHANVIEN q = db.NHANVIENs.Single(p => p.MANV == Convert.ToInt32(textBox1.Text));
            q.MANV = Convert.ToInt32(textBox1.Text);
            q.HOTEN = textBox2.Text;
            q.NGAYSINH = textBox3.Text;
            q.DIACHI = textBox4.Text;
            q.DIENTHOAI = textBox5.Text;
            q.HSLUONG = Convert.ToDouble(textBox6.Text);
            q.MADONVI = Convert.ToInt32(comboBox1.Text);
            db.SubmitChanges();
            load();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[dongchon].Cells["MANV"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dongchon].Cells["HOTEN"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dongchon].Cells["NGAYSINH"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[dongchon].Cells["DIACHI"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[dongchon].Cells["DIENTHOAI"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[dongchon].Cells["HSLUONG"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dongchon].Cells["MADONVI"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentCell.RowIndex;
            NhanvienDataContext db = new NhanvienDataContext();
            NHANVIEN q = db.NHANVIENs.Single(p => Convert.ToString(p.MANV) == dataGridView1.Rows[dongchon].Cells["MANV"].Value.ToString());
            db.NHANVIENs.DeleteOnSubmit(q);
            db.SubmitChanges();
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NhanvienDataContext db = new NhanvienDataContext();
            var q = db.NHANVIENs.Select(p => new { p.MANV, p.HOTEN, p.NGAYSINH, p.DIACHI, p.DIENTHOAI, p.HSLUONG, p.MADONVI }).OrderBy(p => p.HOTEN);
            dataGridView1.DataSource = q;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NhanvienDataContext db = new NhanvienDataContext();
            var q = db.NHANVIENs.Select(p => new { p.MANV, p.HOTEN, p.NGAYSINH, p.DIACHI, p.DIENTHOAI, p.HSLUONG, p.MADONVI }).OrderByDescending(p => p.HOTEN);
            dataGridView1.DataSource = q;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
