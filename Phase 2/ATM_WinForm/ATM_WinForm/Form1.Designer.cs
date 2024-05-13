namespace ATM_WinForm
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
            this.SectionBankeBtn = new System.Windows.Forms.Button();
            this.welcomeMsg = new System.Windows.Forms.TextBox();
            this.descOfWlcmMsg = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SectionFilijaleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SectionBankeBtn
            // 
            this.SectionBankeBtn.Location = new System.Drawing.Point(61, 121);
            this.SectionBankeBtn.Name = "SectionBankeBtn";
            this.SectionBankeBtn.Size = new System.Drawing.Size(453, 38);
            this.SectionBankeBtn.TabIndex = 4;
            this.SectionBankeBtn.Text = "Banke";
            this.SectionBankeBtn.UseVisualStyleBackColor = true;
            this.SectionBankeBtn.Click += new System.EventHandler(this.SectionBanka_Click);
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.BackColor = System.Drawing.Color.White;
            this.welcomeMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMsg.Location = new System.Drawing.Point(12, 44);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(557, 19);
            this.welcomeMsg.TabIndex = 5;
            this.welcomeMsg.Text = "Dobrodosli na ATM koristan softver";
            this.welcomeMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descOfWlcmMsg
            // 
            this.descOfWlcmMsg.BackColor = System.Drawing.Color.White;
            this.descOfWlcmMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descOfWlcmMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descOfWlcmMsg.Location = new System.Drawing.Point(12, 69);
            this.descOfWlcmMsg.Name = "descOfWlcmMsg";
            this.descOfWlcmMsg.Size = new System.Drawing.Size(557, 15);
            this.descOfWlcmMsg.TabIndex = 6;
            this.descOfWlcmMsg.Text = "Tamo gde masta postaje stvarnost!!!";
            this.descOfWlcmMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 31);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "MMF Korporacija ®";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SectionFilijaleBtn
            // 
            this.SectionFilijaleBtn.Location = new System.Drawing.Point(61, 165);
            this.SectionFilijaleBtn.Name = "SectionFilijaleBtn";
            this.SectionFilijaleBtn.Size = new System.Drawing.Size(453, 38);
            this.SectionFilijaleBtn.TabIndex = 8;
            this.SectionFilijaleBtn.Text = "Filijale";
            this.SectionFilijaleBtn.UseVisualStyleBackColor = true;
            this.SectionFilijaleBtn.Click += new System.EventHandler(this.SectionFilijaleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(580, 431);
            this.Controls.Add(this.SectionFilijaleBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.descOfWlcmMsg);
            this.Controls.Add(this.welcomeMsg);
            this.Controls.Add(this.SectionBankeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Glavna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SectionBankeBtn;
        private System.Windows.Forms.TextBox welcomeMsg;
        private System.Windows.Forms.TextBox descOfWlcmMsg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SectionFilijaleBtn;
    }
}

