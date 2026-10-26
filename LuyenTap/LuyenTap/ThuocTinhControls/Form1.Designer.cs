namespace ThuocTinhControls
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
            this.lblMau = new System.Windows.Forms.Label();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.btnNenVang = new System.Windows.Forms.Button();
            this.btnNenXanh = new System.Windows.Forms.Button();
            this.btnChuDo = new System.Windows.Forms.Button();
            this.btnChuDen = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.chkDam = new System.Windows.Forms.CheckBox();
            this.chkChoSua = new System.Windows.Forms.CheckBox();
            this.chkHien = new System.Windows.Forms.CheckBox();
            this.btnGiua = new System.Windows.Forms.Button();
            this.btnPhai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMau
            // 
            this.lblMau.Location = new System.Drawing.Point(100, 66);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(234, 23);
            this.lblMau.TabIndex = 0;
            this.lblMau.Text = "Xin chao : ";
            // 
            // txtMau
            // 
            this.txtMau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMau.Location = new System.Drawing.Point(450, 66);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(128, 22);
            this.txtMau.TabIndex = 1;
            this.txtMau.TextChanged += new System.EventHandler(this.txtMau_TextChanged);
            // 
            // btnNenVang
            // 
            this.btnNenVang.Location = new System.Drawing.Point(103, 121);
            this.btnNenVang.Name = "btnNenVang";
            this.btnNenVang.Size = new System.Drawing.Size(75, 23);
            this.btnNenVang.TabIndex = 2;
            this.btnNenVang.Text = "Nen vang";
            this.btnNenVang.UseVisualStyleBackColor = true;
            this.btnNenVang.Click += new System.EventHandler(this.btnNenVang_Click);
            // 
            // btnNenXanh
            // 
            this.btnNenXanh.Location = new System.Drawing.Point(103, 150);
            this.btnNenXanh.Name = "btnNenXanh";
            this.btnNenXanh.Size = new System.Drawing.Size(75, 23);
            this.btnNenXanh.TabIndex = 3;
            this.btnNenXanh.Text = "Nen xanh";
            this.btnNenXanh.UseVisualStyleBackColor = true;
            this.btnNenXanh.Click += new System.EventHandler(this.btnNenXanh_Click_1);
            // 
            // btnChuDo
            // 
            this.btnChuDo.Location = new System.Drawing.Point(103, 179);
            this.btnChuDo.Name = "btnChuDo";
            this.btnChuDo.Size = new System.Drawing.Size(75, 23);
            this.btnChuDo.TabIndex = 4;
            this.btnChuDo.Text = "chu do";
            this.btnChuDo.UseVisualStyleBackColor = true;
            this.btnChuDo.Click += new System.EventHandler(this.btnChuDo_Click);
            // 
            // btnChuDen
            // 
            this.btnChuDen.Location = new System.Drawing.Point(103, 219);
            this.btnChuDen.Name = "btnChuDen";
            this.btnChuDen.Size = new System.Drawing.Size(75, 23);
            this.btnChuDen.TabIndex = 5;
            this.btnChuDen.Text = "chu den";
            this.btnChuDen.UseVisualStyleBackColor = true;
            this.btnChuDen.Click += new System.EventHandler(this.btnChuDen_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(103, 260);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(75, 23);
            this.btnTang.TabIndex = 6;
            this.btnTang.Text = "A+";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(103, 303);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(75, 23);
            this.btnGiam.TabIndex = 7;
            this.btnGiam.Text = "A-";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(103, 332);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(75, 23);
            this.btnTrai.TabIndex = 8;
            this.btnTrai.Text = "Left";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(548, 293);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(169, 16);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "TextBox đang focus: Không";
            // 
            // chkDam
            // 
            this.chkDam.AutoSize = true;
            this.chkDam.Location = new System.Drawing.Point(396, 121);
            this.chkDam.Name = "chkDam";
            this.chkDam.Size = new System.Drawing.Size(69, 20);
            this.chkDam.TabIndex = 10;
            this.chkDam.Text = "In dam";
            this.chkDam.UseVisualStyleBackColor = true;
            this.chkDam.CheckedChanged += new System.EventHandler(this.chkDam_CheckedChanged);
            // 
            // chkChoSua
            // 
            this.chkChoSua.AutoSize = true;
            this.chkChoSua.Checked = true;
            this.chkChoSua.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChoSua.Location = new System.Drawing.Point(396, 233);
            this.chkChoSua.Name = "chkChoSua";
            this.chkChoSua.Size = new System.Drawing.Size(112, 20);
            this.chkChoSua.TabIndex = 11;
            this.chkChoSua.Text = "Cho phep sua";
            this.chkChoSua.UseVisualStyleBackColor = true;
            this.chkChoSua.CheckedChanged += new System.EventHandler(this.chkChoSua_CheckedChanged);
            // 
            // chkHien
            // 
            this.chkHien.AutoSize = true;
            this.chkHien.Checked = true;
            this.chkHien.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHien.Location = new System.Drawing.Point(396, 179);
            this.chkHien.Name = "chkHien";
            this.chkHien.Size = new System.Drawing.Size(90, 20);
            this.chkHien.TabIndex = 12;
            this.chkHien.Text = "Hien lable";
            this.chkHien.UseVisualStyleBackColor = true;
            this.chkHien.CheckedChanged += new System.EventHandler(this.chkHien_CheckedChanged);
            // 
            // btnGiua
            // 
            this.btnGiua.Location = new System.Drawing.Point(226, 332);
            this.btnGiua.Name = "btnGiua";
            this.btnGiua.Size = new System.Drawing.Size(75, 23);
            this.btnGiua.TabIndex = 13;
            this.btnGiua.Text = "Mid";
            this.btnGiua.UseVisualStyleBackColor = true;
            this.btnGiua.Click += new System.EventHandler(this.btnGiua_Click);
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(350, 332);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(75, 23);
            this.btnPhai.TabIndex = 14;
            this.btnPhai.Text = "Right";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.btnGiua);
            this.Controls.Add(this.chkHien);
            this.Controls.Add(this.chkChoSua);
            this.Controls.Add(this.chkDam);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btnChuDen);
            this.Controls.Add(this.btnChuDo);
            this.Controls.Add(this.btnNenXanh);
            this.Controls.Add(this.btnNenVang);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.lblMau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMau;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Button btnNenVang;
        private System.Windows.Forms.Button btnNenXanh;
        private System.Windows.Forms.Button btnChuDo;
        private System.Windows.Forms.Button btnChuDen;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.CheckBox chkDam;
        private System.Windows.Forms.CheckBox chkChoSua;
        private System.Windows.Forms.CheckBox chkHien;
        private System.Windows.Forms.Button btnGiua;
        private System.Windows.Forms.Button btnPhai;
    }
}

