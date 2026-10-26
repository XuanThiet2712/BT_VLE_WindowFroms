namespace Baitap4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkKhach = new System.Windows.Forms.CheckBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnHien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(61, 80);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(70, 16);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật khẩu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(165, 74);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(151, 22);
            this.txtMatKhau.TabIndex = 2;
            // 
            // chkKhach
            // 
            this.chkKhach.AutoSize = true;
            this.chkKhach.Location = new System.Drawing.Point(369, 80);
            this.chkKhach.Name = "chkKhach";
            this.chkKhach.Size = new System.Drawing.Size(214, 20);
            this.chkKhach.TabIndex = 3;
            this.chkKhach.Text = "Dang nhap voi tu cach la khach";
            this.chkKhach.UseVisualStyleBackColor = true;
            // 
            // picAnh
            // 
            this.picAnh.Image = ((System.Drawing.Image)(resources.GetObject("picAnh.Image")));
            this.picAnh.Location = new System.Drawing.Point(398, 140);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(136, 130);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 4;
            this.picAnh.TabStop = false;
            // 
            // btnAn
            // 
            this.btnAn.Location = new System.Drawing.Point(120, 140);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(96, 108);
            this.btnAn.TabIndex = 5;
            this.btnAn.Text = "Aanr";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(244, 140);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(96, 108);
            this.btnHien.TabIndex = 6;
            this.btnHien.Text = "Hien";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 304);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.chkKhach);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatKhau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkKhach;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnHien;
    }
}

