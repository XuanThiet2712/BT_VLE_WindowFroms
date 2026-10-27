namespace bai4
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
            this.btnMoMau = new System.Windows.Forms.Button();
            this.pnlDieuKhien = new System.Windows.Forms.Panel();
            this.cboBorder = new System.Windows.Forms.ComboBox();
            this.trkOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radMin = new System.Windows.Forms.RadioButton();
            this.radMax = new System.Windows.Forms.RadioButton();
            this.cboCursor = new System.Windows.Forms.ComboBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.chkTaskbar = new System.Windows.Forms.CheckBox();
            this.chkControlBox = new System.Windows.Forms.CheckBox();
            this.chkMaximizeBox = new System.Windows.Forms.CheckBox();
            this.btnThemNut = new System.Windows.Forms.Button();
            this.btnXoaNut = new System.Windows.Forms.Button();
            this.chkAutoSize = new System.Windows.Forms.CheckBox();
            this.WindowState = new System.Windows.Forms.GroupBox();
            this.pnlDieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).BeginInit();
            this.WindowState.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoMau
            // 
            this.btnMoMau.Location = new System.Drawing.Point(0, 0);
            this.btnMoMau.Name = "btnMoMau";
            this.btnMoMau.Size = new System.Drawing.Size(87, 58);
            this.btnMoMau.TabIndex = 0;
            this.btnMoMau.Text = "button1";
            this.btnMoMau.UseVisualStyleBackColor = true;
            this.btnMoMau.Click += new System.EventHandler(this.btnMoDau_Click);
            // 
            // pnlDieuKhien
            // 
            this.pnlDieuKhien.Controls.Add(this.chkAutoSize);
            this.pnlDieuKhien.Controls.Add(this.WindowState);
            this.pnlDieuKhien.Controls.Add(this.chkMaximizeBox);
            this.pnlDieuKhien.Controls.Add(this.btnXoaNut);
            this.pnlDieuKhien.Controls.Add(this.chkControlBox);
            this.pnlDieuKhien.Controls.Add(this.cboBorder);
            this.pnlDieuKhien.Controls.Add(this.chkTaskbar);
            this.pnlDieuKhien.Controls.Add(this.btnThemNut);
            this.pnlDieuKhien.Controls.Add(this.btnIcon);
            this.pnlDieuKhien.Controls.Add(this.trkOpacity);
            this.pnlDieuKhien.Controls.Add(this.chkTopMost);
            this.pnlDieuKhien.Controls.Add(this.cboCursor);
            this.pnlDieuKhien.Enabled = false;
            this.pnlDieuKhien.Location = new System.Drawing.Point(12, 64);
            this.pnlDieuKhien.Name = "pnlDieuKhien";
            this.pnlDieuKhien.Size = new System.Drawing.Size(378, 399);
            this.pnlDieuKhien.TabIndex = 1;
            // 
            // cboBorder
            // 
            this.cboBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBorder.FormattingEnabled = true;
            this.cboBorder.Location = new System.Drawing.Point(210, 24);
            this.cboBorder.Name = "cboBorder";
            this.cboBorder.Size = new System.Drawing.Size(121, 24);
            this.cboBorder.TabIndex = 0;
            this.cboBorder.SelectedIndexChanged += new System.EventHandler(this.cboBoder_SelectedIndexChanged);
            // 
            // trkOpacity
            // 
            this.trkOpacity.Location = new System.Drawing.Point(43, 231);
            this.trkOpacity.Maximum = 100;
            this.trkOpacity.Name = "trkOpacity";
            this.trkOpacity.Size = new System.Drawing.Size(104, 56);
            this.trkOpacity.TabIndex = 2;
            this.trkOpacity.TickFrequency = 10;
            this.trkOpacity.Value = 100;
            this.trkOpacity.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(141, 378);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(28, 16);
            this.lblOpacity.TabIndex = 3;
            this.lblOpacity.Text = "100";
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Location = new System.Drawing.Point(40, 60);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(95, 20);
            this.chkTopMost.TabIndex = 4;
            this.chkTopMost.Text = "checkBox1";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(0, 13);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(103, 20);
            this.radNormal.TabIndex = 5;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "radioButton1";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
            // 
            // radMin
            // 
            this.radMin.AutoSize = true;
            this.radMin.Location = new System.Drawing.Point(0, 39);
            this.radMin.Name = "radMin";
            this.radMin.Size = new System.Drawing.Size(103, 20);
            this.radMin.TabIndex = 6;
            this.radMin.TabStop = true;
            this.radMin.Text = "radioButton1";
            this.radMin.UseVisualStyleBackColor = true;
            this.radMin.CheckedChanged += new System.EventHandler(this.radMin_CheckedChanged);
            // 
            // radMax
            // 
            this.radMax.AutoSize = true;
            this.radMax.Location = new System.Drawing.Point(2, 65);
            this.radMax.Name = "radMax";
            this.radMax.Size = new System.Drawing.Size(103, 20);
            this.radMax.TabIndex = 7;
            this.radMax.TabStop = true;
            this.radMax.Text = "radioButton1";
            this.radMax.UseVisualStyleBackColor = true;
            this.radMax.CheckedChanged += new System.EventHandler(this.radMax_CheckedChanged);
            // 
            // cboCursor
            // 
            this.cboCursor.FormattingEnabled = true;
            this.cboCursor.Location = new System.Drawing.Point(258, 144);
            this.cboCursor.Name = "cboCursor";
            this.cboCursor.Size = new System.Drawing.Size(115, 24);
            this.cboCursor.TabIndex = 8;
            this.cboCursor.SelectedIndexChanged += new System.EventHandler(this.cboCursor_SelectedIndexChanged);
            // 
            // btnIcon
            // 
            this.btnIcon.Location = new System.Drawing.Point(255, 195);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(76, 35);
            this.btnIcon.TabIndex = 9;
            this.btnIcon.Text = "button2";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // chkTaskbar
            // 
            this.chkTaskbar.AutoSize = true;
            this.chkTaskbar.Location = new System.Drawing.Point(227, 267);
            this.chkTaskbar.Name = "chkTaskbar";
            this.chkTaskbar.Size = new System.Drawing.Size(95, 20);
            this.chkTaskbar.TabIndex = 10;
            this.chkTaskbar.Text = "checkBox1";
            this.chkTaskbar.UseVisualStyleBackColor = true;
            this.chkTaskbar.CheckedChanged += new System.EventHandler(this.chkTaskbar_CheckedChanged);
            // 
            // chkControlBox
            // 
            this.chkControlBox.AutoSize = true;
            this.chkControlBox.Location = new System.Drawing.Point(227, 293);
            this.chkControlBox.Name = "chkControlBox";
            this.chkControlBox.Size = new System.Drawing.Size(95, 20);
            this.chkControlBox.TabIndex = 11;
            this.chkControlBox.Text = "checkBox1";
            this.chkControlBox.UseVisualStyleBackColor = true;
            this.chkControlBox.CheckedChanged += new System.EventHandler(this.chkControlBox_CheckedChanged);
            // 
            // chkMaximizeBox
            // 
            this.chkMaximizeBox.AutoSize = true;
            this.chkMaximizeBox.Location = new System.Drawing.Point(227, 319);
            this.chkMaximizeBox.Name = "chkMaximizeBox";
            this.chkMaximizeBox.Size = new System.Drawing.Size(95, 20);
            this.chkMaximizeBox.TabIndex = 12;
            this.chkMaximizeBox.Text = "checkBox2";
            this.chkMaximizeBox.UseVisualStyleBackColor = true;
            this.chkMaximizeBox.CheckedChanged += new System.EventHandler(this.chkMaximizeBox_CheckedChanged);
            // 
            // btnThemNut
            // 
            this.btnThemNut.Location = new System.Drawing.Point(43, 348);
            this.btnThemNut.Name = "btnThemNut";
            this.btnThemNut.Size = new System.Drawing.Size(53, 41);
            this.btnThemNut.TabIndex = 13;
            this.btnThemNut.Text = "button2";
            this.btnThemNut.UseVisualStyleBackColor = true;
            this.btnThemNut.Click += new System.EventHandler(this.btnThemNut_Click);
            // 
            // btnXoaNut
            // 
            this.btnXoaNut.Location = new System.Drawing.Point(116, 348);
            this.btnXoaNut.Name = "btnXoaNut";
            this.btnXoaNut.Size = new System.Drawing.Size(53, 41);
            this.btnXoaNut.TabIndex = 14;
            this.btnXoaNut.Text = "button3";
            this.btnXoaNut.UseVisualStyleBackColor = true;
            this.btnXoaNut.Click += new System.EventHandler(this.btnXoaNut_Click);
            // 
            // chkAutoSize
            // 
            this.chkAutoSize.AutoSize = true;
            this.chkAutoSize.Location = new System.Drawing.Point(227, 348);
            this.chkAutoSize.Name = "chkAutoSize";
            this.chkAutoSize.Size = new System.Drawing.Size(95, 20);
            this.chkAutoSize.TabIndex = 15;
            this.chkAutoSize.Text = "checkBox2";
            this.chkAutoSize.UseVisualStyleBackColor = true;
            this.chkAutoSize.CheckedChanged += new System.EventHandler(this.chkAutoSize_CheckedChanged);
            // 
            // WindowState
            // 
            this.WindowState.Controls.Add(this.radMax);
            this.WindowState.Controls.Add(this.radMin);
            this.WindowState.Controls.Add(this.radNormal);
            this.WindowState.Location = new System.Drawing.Point(64, 109);
            this.WindowState.Name = "WindowState";
            this.WindowState.Size = new System.Drawing.Size(118, 93);
            this.WindowState.TabIndex = 16;
            this.WindowState.TabStop = false;
            this.WindowState.Text = "WindowState";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 473);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.pnlDieuKhien);
            this.Controls.Add(this.btnMoMau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bảng điều khiển";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDieuKhien.ResumeLayout(false);
            this.pnlDieuKhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).EndInit();
            this.WindowState.ResumeLayout(false);
            this.WindowState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoMau;
        private System.Windows.Forms.Panel pnlDieuKhien;
        private System.Windows.Forms.ComboBox cboBorder;
        private System.Windows.Forms.TrackBar trkOpacity;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radMin;
        private System.Windows.Forms.RadioButton radMax;
        private System.Windows.Forms.ComboBox cboCursor;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.CheckBox chkTaskbar;
        private System.Windows.Forms.CheckBox chkControlBox;
        private System.Windows.Forms.CheckBox chkMaximizeBox;
        private System.Windows.Forms.Button btnThemNut;
        private System.Windows.Forms.Button btnXoaNut;
        private System.Windows.Forms.CheckBox chkAutoSize;
        private System.Windows.Forms.GroupBox WindowState;
    }
}