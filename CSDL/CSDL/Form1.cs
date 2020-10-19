using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection conn;

        public DataSet ds;

        public String strConnect = @"Data Source=(local);Initial Catalog=banhang;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banhangDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            conn = new SqlConnection(strConnect);
            if (conn.State == ConnectionState.Closed) 
            conn.Open();
            String sql = "SELECT TENDONVI,MADONVI FROM DONVI";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TENDONVI";
            comboBox1.ValueMember = "MADONVI";
            LoadNV();
        }

        private void LoadNV()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN", conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dong;
            dong = dataGridView1.CurrentCellAddress.Y;
            SqlCommand cmd = new SqlCommand("DELETE FROM NHANVIEN WHERE MANV = @MANV", conn);
            cmd.Parameters.AddWithValue("@MANV", dataGridView1.Rows[dong].Cells["MANV"].Value);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Xóa thành công");
                LoadNV();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                LoadNV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN(MANV, HOTEN, NGAYSINH, DIACHI, DIENTHOAI, HSLUONG, MADONVI) values (@MANV, @HOTEN, @NGAYSINH, @DIACHI, @DIENTHOAI, @HSLUONG, @MADONVI)", conn);
            cmd.Parameters.AddWithValue("@MANV", textBox1.Text);
            cmd.Parameters.AddWithValue("@HOTEN", textBox2.Text);
            cmd.Parameters.AddWithValue("@NGAYSINH", textBox3.Text);
            cmd.Parameters.AddWithValue("@DIACHI", textBox4.Text);
            cmd.Parameters.AddWithValue("@DIENTHOAI", textBox5.Text);
            cmd.Parameters.AddWithValue("@HSLUONG", textBox6.Text);
            cmd.Parameters.AddWithValue("@MADONVI", comboBox1.SelectedValue.ToString());
            if (cmd.ExecuteNonQuery() != 0) {
                MessageBox.Show("Thêm thành công");
                LoadNV();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                LoadNV();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dong = dataGridView1.CurrentCellAddress.Y;
            SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET MANV=@MANV, HOTEN=@HOTEN, NGAYSINH=@NGAYSINH, DIACHI=@DIACHI, DIENTHOAI=@DIENTHOAI, HSLUONG=@HSLUONG, MADONVI=@MADONVI WHERE MANV=@MANV", conn);
            cmd.Parameters.AddWithValue("@MANV", textBox1.Text);
            cmd.Parameters.AddWithValue("@HOTEN", textBox2.Text);
            cmd.Parameters.AddWithValue("@NGAYSINH", textBox3.Text);
            cmd.Parameters.AddWithValue("@DIACHI", textBox4.Text);
            cmd.Parameters.AddWithValue("@DIENTHOAI", textBox5.Text);
            cmd.Parameters.AddWithValue("@HSLUONG", textBox6.Text);
            cmd.Parameters.AddWithValue("@MADONVI", textBox8.Text);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadNV();
            }
            else {
                MessageBox.Show("Cập nhật thất bại");
                LoadNV();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int dong = dataGridView1.CurrentCellAddress.Y;
            if (dong >= 0) {
                textBox1.Text = dataGridView1.Rows[dong].Cells["MANV"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dong].Cells["HOTEN"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dong].Cells["NGAYSINH"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[dong].Cells["DIACHI"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[dong].Cells["DIENTHOAI"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[dong].Cells["HSLUONG"].Value.ToString();
                comboBox1.SelectedItem = dataGridView1.Rows[dong].Cells["MADONVI"].Value.ToString();
            }
        }
    }
}
