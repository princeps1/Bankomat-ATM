namespace ATM_WinForm.Forme.Bankomat
{
    partial class Form_Bankomat_Servisi_AddUpdate
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
            this.FirmaLbl = new System.Windows.Forms.Label();
            this.AkcijaServisaBtn = new System.Windows.Forms.Button();
            this.AddUpdateTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirmaLbl
            // 
            this.FirmaLbl.AutoSize = true;
            this.FirmaLbl.Location = new System.Drawing.Point(125, 53);
            this.FirmaLbl.Name = "FirmaLbl";
            this.FirmaLbl.Size = new System.Drawing.Size(268, 16);
            this.FirmaLbl.TabIndex = 12;
            this.FirmaLbl.Text = "Unesite naziv firme koja servisira bankomat:";
            // 
            // AkcijaServisaBtn
            // 
            this.AkcijaServisaBtn.Location = new System.Drawing.Point(153, 135);
            this.AkcijaServisaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AkcijaServisaBtn.Name = "AkcijaServisaBtn";
            this.AkcijaServisaBtn.Size = new System.Drawing.Size(211, 38);
            this.AkcijaServisaBtn.TabIndex = 11;
            this.AkcijaServisaBtn.Text = "button1";
            this.AkcijaServisaBtn.UseVisualStyleBackColor = true;
            this.AkcijaServisaBtn.Click += new System.EventHandler(this.AkcijaServisaBtn_Click);
            // 
            // AddUpdateTxt
            // 
            this.AddUpdateTxt.Location = new System.Drawing.Point(153, 86);
            this.AddUpdateTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUpdateTxt.Name = "AddUpdateTxt";
            this.AddUpdateTxt.Size = new System.Drawing.Size(209, 22);
            this.AddUpdateTxt.TabIndex = 10;
            // 
            // Form_Bankomat_Servisi_AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 232);
            this.Controls.Add(this.FirmaLbl);
            this.Controls.Add(this.AkcijaServisaBtn);
            this.Controls.Add(this.AddUpdateTxt);
            this.Name = "Form_Bankomat_Servisi_AddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Dodaj servis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirmaLbl;
        private System.Windows.Forms.Button AkcijaServisaBtn;
        private System.Windows.Forms.TextBox AddUpdateTxt;
    }
}