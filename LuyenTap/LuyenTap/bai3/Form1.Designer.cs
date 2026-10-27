namespace bai3
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
            this.btnMoThuMuc = new System.Windows.Forms.Button();
            this.cboSizeMode = new System.Windows.Forms.ComboBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMoThuMuc
            // 
            this.btnMoThuMuc.Location = new System.Drawing.Point(0, 0);
            this.btnMoThuMuc.Name = "btnMoThuMuc";
            this.btnMoThuMuc.Size = new System.Drawing.Size(101, 82);
            this.btnMoThuMuc.TabIndex = 0;
            this.btnMoThuMuc.Text = "Mo thu muc";
            this.btnMoThuMuc.UseVisualStyleBackColor = true;
            this.btnMoThuMuc.Click += new System.EventHandler(this.btnMoThuMuc_Click);
            // 
            // cboSizeMode
            // 
            this.cboSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSizeMode.FormattingEnabled = true;
            this.cboSizeMode.Location = new System.Drawing.Point(145, 262);
            this.cboSizeMode.Name = "cboSizeMode";
            this.cboSizeMode.Size = new System.Drawing.Size(121, 24);
            this.cboSizeMode.TabIndex = 2;
            this.cboSizeMode.SelectedIndexChanged += new System.EventHandler(this.cboSizeMode_SelectedIndexChanged);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(349, 60);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(426, 353);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 3;
            this.picAnh.TabStop = false;
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(211, 134);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(101, 82);
            this.btnSau.TabIndex = 5;
            this.btnSau.Text = "sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(66, 134);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(101, 82);
            this.btnTruoc.TabIndex = 6;
            this.btnTruoc.Text = "truoc";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(165, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 82);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoa khoi danh sach";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.cboSizeMode);
            this.Controls.Add(this.btnMoThuMuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoThuMuc;
        private System.Windows.Forms.ComboBox cboSizeMode;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnXoa;
    }
}

