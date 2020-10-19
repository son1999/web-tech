namespace SoChinhPhuong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.txtKiemTra = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.txtThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKq);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtThoat);
            this.panel1.Controls.Add(this.txtReset);
            this.panel1.Controls.Add(this.txtKiemTra);
            this.panel1.Controls.Add(this.txtSo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 182);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số chính phương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập n";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(117, 35);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(355, 20);
            this.txtSo.TabIndex = 1;
            // 
            // txtKiemTra
            // 
            this.txtKiemTra.Location = new System.Drawing.Point(17, 134);
            this.txtKiemTra.Name = "txtKiemTra";
            this.txtKiemTra.Size = new System.Drawing.Size(75, 23);
            this.txtKiemTra.TabIndex = 2;
            this.txtKiemTra.Text = "Kiểm tra";
            this.txtKiemTra.UseVisualStyleBackColor = true;
            this.txtKiemTra.Click += new System.EventHandler(this.txtKiemTra_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(197, 134);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 3;
            this.txtReset.Text = "Nhập lại";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // txtThoat
            // 
            this.txtThoat.Location = new System.Drawing.Point(397, 134);
            this.txtThoat.Name = "txtThoat";
            this.txtThoat.Size = new System.Drawing.Size(75, 23);
            this.txtThoat.TabIndex = 4;
            this.txtThoat.Text = "Thoát";
            this.txtThoat.UseVisualStyleBackColor = true;
            this.txtThoat.Click += new System.EventHandler(this.txtThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(117, 82);
            this.txtKq.Name = "txtKq";
            this.txtKq.ReadOnly = true;
            this.txtKq.Size = new System.Drawing.Size(355, 20);
            this.txtKq.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button txtThoat;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button txtKiemTra;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Label label3;
    }
}

