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
            this.cmdCreateBank = new System.Windows.Forms.Button();
            this.cmdReadBankName = new System.Windows.Forms.Button();
            this.cmdReadFilijaleList = new System.Windows.Forms.Button();
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
            // cmdCreateBank
            // 
            this.cmdCreateBank.Location = new System.Drawing.Point(30, 144);
            this.cmdCreateBank.Name = "cmdCreateBank";
            this.cmdCreateBank.Size = new System.Drawing.Size(188, 65);
            this.cmdCreateBank.TabIndex = 1;
            this.cmdCreateBank.Text = "Dodaj banku";
            this.cmdCreateBank.UseVisualStyleBackColor = true;
            this.cmdCreateBank.Click += new System.EventHandler(this.cmdCreateBank_Click);
            // 
            // cmdReadBankName
            // 
            this.cmdReadBankName.Location = new System.Drawing.Point(416, 44);
            this.cmdReadBankName.Name = "cmdReadBankName";
            this.cmdReadBankName.Size = new System.Drawing.Size(278, 70);
            this.cmdReadBankName.TabIndex = 2;
            this.cmdReadBankName.Text = "IME BANKE";
            this.cmdReadBankName.UseVisualStyleBackColor = true;
            this.cmdReadBankName.Click += new System.EventHandler(this.cmdReadBankName_Click);
            // 
            // cmdReadFilijaleList
            // 
            this.cmdReadFilijaleList.Location = new System.Drawing.Point(416, 142);
            this.cmdReadFilijaleList.Name = "cmdReadFilijaleList";
            this.cmdReadFilijaleList.Size = new System.Drawing.Size(277, 49);
            this.cmdReadFilijaleList.TabIndex = 3;
            this.cmdReadFilijaleList.Text = "Lista Filijala";
            this.cmdReadFilijaleList.UseVisualStyleBackColor = true;
            this.cmdReadFilijaleList.Click += new System.EventHandler(this.cmdReadFilijaleList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdReadFilijaleList);
            this.Controls.Add(this.cmdReadBankName);
            this.Controls.Add(this.cmdCreateBank);
            this.Controls.Add(this.cmdReadBank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdReadBank;
        private System.Windows.Forms.Button cmdCreateBank;
        private System.Windows.Forms.Button cmdReadBankName;
        private System.Windows.Forms.Button cmdReadFilijaleList;
    }
}

