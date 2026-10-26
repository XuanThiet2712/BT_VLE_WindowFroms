namespace Baitap5
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
            this.btnDaiDien = new System.Windows.Forms.Button();
            this.btnBig = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDaiDien
            // 
            this.btnDaiDien.Location = new System.Drawing.Point(181, 53);
            this.btnDaiDien.Name = "btnDaiDien";
            this.btnDaiDien.Size = new System.Drawing.Size(181, 155);
            this.btnDaiDien.TabIndex = 0;
            this.btnDaiDien.Text = "button1";
            this.btnDaiDien.UseVisualStyleBackColor = true;
            // 
            // btnBig
            // 
            this.btnBig.Location = new System.Drawing.Point(125, 298);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(124, 39);
            this.btnBig.TabIndex = 1;
            this.btnBig.Text = "button2";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(339, 298);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(124, 39);
            this.btnSmall.TabIndex = 2;
            this.btnSmall.Text = "button3";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(443, 86);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(44, 16);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnBig);
            this.Controls.Add(this.btnDaiDien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDaiDien;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Label lblInfo;
    }
}

