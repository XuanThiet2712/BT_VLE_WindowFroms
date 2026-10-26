namespace Bai1
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
            this.btnNenDo = new System.Windows.Forms.Button();
            this.btnNenXanh = new System.Windows.Forms.Button();
            this.btnNenVang = new System.Windows.Forms.Button();
            this.btnChuDo = new System.Windows.Forms.Button();
            this.btnChuDen = new System.Windows.Forms.Button();
            this.btnChuVang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pnlLuoi = new System.Windows.Forms.Panel();
            this.pnlLuoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMau
            // 
            this.lblMau.Location = new System.Drawing.Point(9, 40);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(375, 101);
            this.lblMau.TabIndex = 0;
            this.lblMau.Text = "label1";
            this.lblMau.Click += new System.EventHandler(this.lblMau_Click);
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(451, 41);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(92, 22);
            this.txtMau.TabIndex = 1;
            this.txtMau.TextChanged += new System.EventHandler(this.txtMau_TextChanged);
            // 
            // btnNenDo
            // 
            this.btnNenDo.BackColor = System.Drawing.Color.Red;
            this.btnNenDo.Location = new System.Drawing.Point(12, 164);
            this.btnNenDo.Name = "btnNenDo";
            this.btnNenDo.Size = new System.Drawing.Size(75, 23);
            this.btnNenDo.TabIndex = 2;
            this.btnNenDo.Tag = "TopLeft";
            this.btnNenDo.Text = "button1";
            this.btnNenDo.UseVisualStyleBackColor = false;
            this.btnNenDo.Click += new System.EventHandler(this.NutNen_Click);
            // 
            // btnNenXanh
            // 
            this.btnNenXanh.BackColor = System.Drawing.Color.Blue;
            this.btnNenXanh.Location = new System.Drawing.Point(12, 193);
            this.btnNenXanh.Name = "btnNenXanh";
            this.btnNenXanh.Size = new System.Drawing.Size(75, 23);
            this.btnNenXanh.TabIndex = 3;
            this.btnNenXanh.Tag = "MiddleLeft";
            this.btnNenXanh.Text = "button2";
            this.btnNenXanh.UseVisualStyleBackColor = false;
            this.btnNenXanh.Click += new System.EventHandler(this.NutNen_Click);
            // 
            // btnNenVang
            // 
            this.btnNenVang.BackColor = System.Drawing.Color.Yellow;
            this.btnNenVang.Location = new System.Drawing.Point(12, 235);
            this.btnNenVang.Name = "btnNenVang";
            this.btnNenVang.Size = new System.Drawing.Size(75, 23);
            this.btnNenVang.TabIndex = 4;
            this.btnNenVang.Tag = "BottomLeft";
            this.btnNenVang.Text = "button3";
            this.btnNenVang.UseVisualStyleBackColor = false;
            this.btnNenVang.Click += new System.EventHandler(this.NutNen_Click);
            // 
            // btnChuDo
            // 
            this.btnChuDo.BackColor = System.Drawing.Color.Red;
            this.btnChuDo.Location = new System.Drawing.Point(228, 164);
            this.btnChuDo.Name = "btnChuDo";
            this.btnChuDo.Size = new System.Drawing.Size(75, 23);
            this.btnChuDo.TabIndex = 5;
            this.btnChuDo.Tag = "TopCenter";
            this.btnChuDo.Text = "button4";
            this.btnChuDo.UseVisualStyleBackColor = false;
            this.btnChuDo.Click += new System.EventHandler(this.NutChu_Click);
            // 
            // btnChuDen
            // 
            this.btnChuDen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChuDen.Location = new System.Drawing.Point(228, 202);
            this.btnChuDen.Name = "btnChuDen";
            this.btnChuDen.Size = new System.Drawing.Size(75, 23);
            this.btnChuDen.TabIndex = 6;
            this.btnChuDen.Tag = "MiddleCenter";
            this.btnChuDen.Text = "button5";
            this.btnChuDen.UseVisualStyleBackColor = false;
            this.btnChuDen.Click += new System.EventHandler(this.NutChu_Click);
            // 
            // btnChuVang
            // 
            this.btnChuVang.Location = new System.Drawing.Point(228, 235);
            this.btnChuVang.Name = "btnChuVang";
            this.btnChuVang.Size = new System.Drawing.Size(75, 23);
            this.btnChuVang.TabIndex = 7;
            this.btnChuVang.Tag = "BottomCenter";
            this.btnChuVang.Text = "button6";
            this.btnChuVang.UseVisualStyleBackColor = true;
            this.btnChuVang.Click += new System.EventHandler(this.NutChu_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(373, 202);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(75, 23);
            this.btnGiam.TabIndex = 8;
            this.btnGiam.Tag = "MiddleRight";
            this.btnGiam.Text = "button7";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(373, 164);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(75, 23);
            this.btnTang.TabIndex = 9;
            this.btnTang.Tag = "TopRight";
            this.btnTang.Text = "button8";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(681, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "chkDam";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(681, 183);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 20);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "chkNghieng";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pnlLuoi
            // 
            this.pnlLuoi.Controls.Add(this.btnTang);
            this.pnlLuoi.Controls.Add(this.btnGiam);
            this.pnlLuoi.Controls.Add(this.btnChuVang);
            this.pnlLuoi.Controls.Add(this.btnChuDen);
            this.pnlLuoi.Controls.Add(this.btnChuDo);
            this.pnlLuoi.Controls.Add(this.btnNenVang);
            this.pnlLuoi.Controls.Add(this.btnNenXanh);
            this.pnlLuoi.Controls.Add(this.btnNenDo);
            this.pnlLuoi.Controls.Add(this.txtMau);
            this.pnlLuoi.Controls.Add(this.lblMau);
            this.pnlLuoi.Location = new System.Drawing.Point(46, 19);
            this.pnlLuoi.Name = "pnlLuoi";
            this.pnlLuoi.Size = new System.Drawing.Size(629, 392);
            this.pnlLuoi.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.pnlLuoi);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Bai 1 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLuoi.ResumeLayout(false);
            this.pnlLuoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMau;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Button btnNenDo;
        private System.Windows.Forms.Button btnNenXanh;
        private System.Windows.Forms.Button btnNenVang;
        private System.Windows.Forms.Button btnChuDo;
        private System.Windows.Forms.Button btnChuDen;
        private System.Windows.Forms.Button btnChuVang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel pnlLuoi;
    }
}

