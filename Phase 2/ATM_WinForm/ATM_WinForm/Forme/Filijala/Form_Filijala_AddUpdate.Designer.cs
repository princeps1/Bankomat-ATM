﻿namespace ATM_WinForm.Forme.Filijala
{
    partial class Form_Filijala_AddUpdate
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
            this.AkcijaFilijaleBtn = new System.Windows.Forms.Button();
            this.RadnoVremeTxtBx = new System.Windows.Forms.TextBox();
            this.RadnoVremeLbl = new System.Windows.Forms.Label();
            this.BrTelefonaTxtBx = new System.Windows.Forms.TextBox();
            this.BrTelLbl = new System.Windows.Forms.Label();
            this.AdresaTxtBx = new System.Windows.Forms.TextBox();
            this.AdresaLbl = new System.Windows.Forms.Label();
            this.BankaLbl = new System.Windows.Forms.Label();
            this.BankaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AkcijaFilijaleBtn
            // 
            this.AkcijaFilijaleBtn.Location = new System.Drawing.Point(103, 372);
            this.AkcijaFilijaleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AkcijaFilijaleBtn.Name = "AkcijaFilijaleBtn";
            this.AkcijaFilijaleBtn.Size = new System.Drawing.Size(316, 34);
            this.AkcijaFilijaleBtn.TabIndex = 18;
            this.AkcijaFilijaleBtn.Text = "Dodaj Filijalu";
            this.AkcijaFilijaleBtn.UseVisualStyleBackColor = true;
            this.AkcijaFilijaleBtn.Click += new System.EventHandler(this.AkcijaFilijaleBtn_Click);
            // 
            // RadnoVremeTxtBx
            // 
            this.RadnoVremeTxtBx.Location = new System.Drawing.Point(103, 306);
            this.RadnoVremeTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadnoVremeTxtBx.Name = "RadnoVremeTxtBx";
            this.RadnoVremeTxtBx.Size = new System.Drawing.Size(315, 22);
            this.RadnoVremeTxtBx.TabIndex = 17;
            // 
            // RadnoVremeLbl
            // 
            this.RadnoVremeLbl.AutoSize = true;
            this.RadnoVremeLbl.Location = new System.Drawing.Point(99, 274);
            this.RadnoVremeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RadnoVremeLbl.Name = "RadnoVremeLbl";
            this.RadnoVremeLbl.Size = new System.Drawing.Size(89, 16);
            this.RadnoVremeLbl.TabIndex = 16;
            this.RadnoVremeLbl.Text = "Radno vreme";
            // 
            // BrTelefonaTxtBx
            // 
            this.BrTelefonaTxtBx.Location = new System.Drawing.Point(103, 219);
            this.BrTelefonaTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrTelefonaTxtBx.Name = "BrTelefonaTxtBx";
            this.BrTelefonaTxtBx.Size = new System.Drawing.Size(315, 22);
            this.BrTelefonaTxtBx.TabIndex = 15;
            // 
            // BrTelLbl
            // 
            this.BrTelLbl.AutoSize = true;
            this.BrTelLbl.Location = new System.Drawing.Point(99, 187);
            this.BrTelLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrTelLbl.Name = "BrTelLbl";
            this.BrTelLbl.Size = new System.Drawing.Size(82, 16);
            this.BrTelLbl.TabIndex = 14;
            this.BrTelLbl.Text = "Broj telefona";
            // 
            // AdresaTxtBx
            // 
            this.AdresaTxtBx.Location = new System.Drawing.Point(103, 135);
            this.AdresaTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdresaTxtBx.Name = "AdresaTxtBx";
            this.AdresaTxtBx.Size = new System.Drawing.Size(315, 22);
            this.AdresaTxtBx.TabIndex = 13;
            // 
            // AdresaLbl
            // 
            this.AdresaLbl.AutoSize = true;
            this.AdresaLbl.Location = new System.Drawing.Point(99, 103);
            this.AdresaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdresaLbl.Name = "AdresaLbl";
            this.AdresaLbl.Size = new System.Drawing.Size(51, 16);
            this.AdresaLbl.TabIndex = 12;
            this.AdresaLbl.Text = "Adresa";
            // 
            // BankaLbl
            // 
            this.BankaLbl.AutoSize = true;
            this.BankaLbl.Location = new System.Drawing.Point(99, 25);
            this.BankaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BankaLbl.Name = "BankaLbl";
            this.BankaLbl.Size = new System.Drawing.Size(46, 16);
            this.BankaLbl.TabIndex = 10;
            this.BankaLbl.Text = "Banka";
            // 
            // BankaComboBox
            // 
            this.BankaComboBox.Location = new System.Drawing.Point(103, 57);
            this.BankaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BankaComboBox.MaxDropDownItems = 50;
            this.BankaComboBox.Name = "BankaComboBox";
            this.BankaComboBox.Size = new System.Drawing.Size(316, 24);
            this.BankaComboBox.TabIndex = 19;
            // 
            // Form_Filijala_AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 444);
            this.Controls.Add(this.BankaComboBox);
            this.Controls.Add(this.AkcijaFilijaleBtn);
            this.Controls.Add(this.RadnoVremeTxtBx);
            this.Controls.Add(this.RadnoVremeLbl);
            this.Controls.Add(this.BrTelefonaTxtBx);
            this.Controls.Add(this.BrTelLbl);
            this.Controls.Add(this.AdresaTxtBx);
            this.Controls.Add(this.AdresaLbl);
            this.Controls.Add(this.BankaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Filijala_AddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Dodaj Filijalu";
            this.Load += new System.EventHandler(this.Form_Filijala_AddUpdate_Load);
            this.Click += new System.EventHandler(this.BrTelLbl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AkcijaFilijaleBtn;
        private System.Windows.Forms.TextBox RadnoVremeTxtBx;
        private System.Windows.Forms.Label RadnoVremeLbl;
        private System.Windows.Forms.TextBox BrTelefonaTxtBx;
        private System.Windows.Forms.Label BrTelLbl;
        private System.Windows.Forms.TextBox AdresaTxtBx;
        private System.Windows.Forms.Label AdresaLbl;
        private System.Windows.Forms.Label BankaLbl;
        private System.Windows.Forms.ComboBox BankaComboBox;
    }
}