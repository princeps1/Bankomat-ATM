namespace ATM_WinForm.Forme.Banka
{
    partial class Form_BankaBrTelefona_AddUpdate
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
            this.AddUpdateTxt = new System.Windows.Forms.TextBox();
            this.AkcijaBrTelefonaBtn = new System.Windows.Forms.Button();
            this.labelaAddEditLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddUpdateTxt
            // 
            this.AddUpdateTxt.Location = new System.Drawing.Point(68, 97);
            this.AddUpdateTxt.Name = "AddUpdateTxt";
            this.AddUpdateTxt.Size = new System.Drawing.Size(210, 22);
            this.AddUpdateTxt.TabIndex = 1;
            // 
            // AkcijaBrTelefonaBtn
            // 
            this.AkcijaBrTelefonaBtn.Location = new System.Drawing.Point(68, 152);
            this.AkcijaBrTelefonaBtn.Name = "AkcijaBrTelefonaBtn";
            this.AkcijaBrTelefonaBtn.Size = new System.Drawing.Size(210, 57);
            this.AkcijaBrTelefonaBtn.TabIndex = 2;
            this.AkcijaBrTelefonaBtn.Text = "button1";
            this.AkcijaBrTelefonaBtn.UseVisualStyleBackColor = true;
            this.AkcijaBrTelefonaBtn.Click += new System.EventHandler(this.AkcijaBrTelefonaBtn_Click);
            // 
            // labelaAddEditLBL
            // 
            this.labelaAddEditLBL.AutoSize = true;
            this.labelaAddEditLBL.Location = new System.Drawing.Point(146, 50);
            this.labelaAddEditLBL.Name = "labelaAddEditLBL";
            this.labelaAddEditLBL.Size = new System.Drawing.Size(44, 16);
            this.labelaAddEditLBL.TabIndex = 3;
            this.labelaAddEditLBL.Text = "label1";
            // 
            // Form_BankaBrTelefona_AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 333);
            this.Controls.Add(this.labelaAddEditLBL);
            this.Controls.Add(this.AkcijaBrTelefonaBtn);
            this.Controls.Add(this.AddUpdateTxt);
            this.Name = "Form_BankaBrTelefona_AddUpdate";
            this.Text = "ATM - Broj Telefona Banke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AddUpdateTxt;
        private System.Windows.Forms.Button AkcijaBrTelefonaBtn;
        private System.Windows.Forms.Label labelaAddEditLBL;
    }
}