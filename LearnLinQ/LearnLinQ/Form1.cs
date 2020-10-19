using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearnLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void load()
        {
            QLNvDBDataContext db = new QLNvDBDataContext();
            var q = db.DONVIs.Select(p => new { p.MADONVI, p.TENDONVI, p.DIENTHOAI });
            dataGridView1.DataSource = q;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QLNvDBDataContext db = new QLNvDBDataContext();
            var q = db.DONVIs.Select(p => new { p.MADONVI, p.TENDONVI, p.DIENTHOAI});
            dataGridView1.DataSource = q;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            QLNvDBDataContext db = new QLNvDBDataContext();
            var q = db.DONVIs.Where(p => p.TENDONVI.Contains(textBox3.Text)).Select(p => new {p.MADONVI, p.TENDONVI, p.DIENTHOAI});
            dataGridView1.DataSource = q;
        }    

        private void button3_Click(object sender, EventArgs e)
        {
            QLNvDBDataContext db = new QLNvDBDataContext();
            var q = db.DONVIs.Select(p => new { p.MADONVI, p.TENDONVI, p.DIENTHOAI }).OrderBy(p => p.TENDONVI);
            dataGridView1.DataSource = q;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLNvDBDataContext db = new QLNvDBDataContext();
            var q = db.DONVIs.Select(p => new { p.MADONVI, p.TENDONVI, p.DIENTHOAI }).OrderByDescending(p => p.TENDONVI);
            dataGridView1.DataSource = q;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLNvDBDataContext db = new QLNvDBDataContext();
            DONVI dv = new DONVI();
            dv.MADONVI = Convert.ToInt32(textBox1.Text);
            dv.TENDONVI = textBox2.Text;
            dv.DIENTHOAI = textBox4.Text;
            db.DONVIs.InsertOnSubmit(dv);
            db.SubmitChanges();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentCell.RowIndex;
            QLNvDBDataContext db = new QLNvDBDataContext();
            DONVI q = db.DONVIs.Single(p => Convert.ToString(p.MADONVI) == dataGridView1.Rows[dongchon].Cells["MADONVI"].Value.ToString());
            db.DONVIs.DeleteOnSubmit(q);
            db.SubmitChanges();
            load();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[dongchon].Cells["MADONVI"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dongchon].Cells["TENDONVI"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[dongchon].Cells["DIENTHOAI"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentCell.RowIndex;
            QLNvDBDataContext db = new QLNvDBDataContext();
            DONVI q = db.DONVIs.Single(p => Convert.ToString(p.MADONVI) == dataGridView1.Rows[dongchon].Cells["MADONVI"].Value.ToString());
            q.MADONVI = Convert.ToInt32(textBox1.Text);
            q.TENDONVI = textBox2.Text;
            q.DIENTHOAI = textBox4.Text;
            db.SubmitChanges();
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
