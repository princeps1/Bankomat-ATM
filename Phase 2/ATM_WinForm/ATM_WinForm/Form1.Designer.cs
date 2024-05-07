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
            this.cmdReadBank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdReadBank
            // 
            this.cmdReadBank.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdReadBank.Location = new System.Drawing.Point(30, 37);
            this.cmdReadBank.Name = "cmdReadBank";
            this.cmdReadBank.Size = new System.Drawing.Size(188, 78);
            this.cmdReadBank.TabIndex = 0;
            this.cmdReadBank.Text = "Ucitavanje podataka o Banci";
            this.cmdReadBank.UseVisualStyleBackColor = false;
            this.cmdReadBank.Click += new System.EventHandler(this.cmdReadBank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdReadBank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdReadBank;
    }
}

