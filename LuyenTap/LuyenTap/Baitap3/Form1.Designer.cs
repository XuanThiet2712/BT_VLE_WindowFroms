namespace Baitap3
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(85, 63);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(203, 22);
            this.txtBox.TabIndex = 0;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(383, 63);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(183, 20);
            this.chkBox.TabIndex = 1;
            this.chkBox.Text = "Toi dong y voi dieu khoan";
            this.chkBox.UseVisualStyleBackColor = true;
            this.chkBox.CheckedChanged += new System.EventHandler(this.chkBox_CheckedChanged);
            // 
            // btnDongY
            // 
            this.btnDongY.Enabled = false;
            this.btnDongY.Location = new System.Drawing.Point(345, 166);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(106, 102);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "button1";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.Button btnDongY;
    }
}

