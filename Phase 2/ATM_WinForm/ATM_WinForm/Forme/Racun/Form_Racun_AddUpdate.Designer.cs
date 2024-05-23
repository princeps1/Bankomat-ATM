namespace ATM_WinForm.Forme.Racun
{
    partial class Form_Racun_AddUpdate
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
            this.DatumOtvaranjaRacunaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TekuciSaldoTxtBx = new System.Windows.Forms.TextBox();
            this.TekuciSaldoLbl = new System.Windows.Forms.Label();
            this.DatumOtvaranjaRacunaLbl = new System.Windows.Forms.Label();
            this.AkcijaRacunaBtn = new System.Windows.Forms.Button();
            this.AddUpdateNaslovLbl = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.TipRacunaLbl = new System.Windows.Forms.Label();
            this.BankaRacunaLbl = new System.Windows.Forms.Label();
            this.BankeComboBox = new System.Windows.Forms.ComboBox();
            this.ValutaLbl = new System.Windows.Forms.Label();
            this.ValutaTxtBx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatumOtvaranjaRacunaDateTimePicker
            // 
            this.DatumOtvaranjaRacunaDateTimePicker.Location = new System.Drawing.Point(102, 84);
            this.DatumOtvaranjaRacunaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatumOtvaranjaRacunaDateTimePicker.Name = "DatumOtvaranjaRacunaDateTimePicker";
            this.DatumOtvaranjaRacunaDateTimePicker.Size = new System.Drawing.Size(309, 22);
            this.DatumOtvaranjaRacunaDateTimePicker.TabIndex = 50;
            // 
            // TekuciSaldoTxtBx
            // 
            this.TekuciSaldoTxtBx.Location = new System.Drawing.Point(102, 225);
            this.TekuciSaldoTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.TekuciSaldoTxtBx.Name = "TekuciSaldoTxtBx";
            this.TekuciSaldoTxtBx.Size = new System.Drawing.Size(315, 22);
            this.TekuciSaldoTxtBx.TabIndex = 47;
            // 
            // TekuciSaldoLbl
            // 
            this.TekuciSaldoLbl.AutoSize = true;
            this.TekuciSaldoLbl.Location = new System.Drawing.Point(102, 205);
            this.TekuciSaldoLbl.Name = "TekuciSaldoLbl";
            this.TekuciSaldoLbl.Size = new System.Drawing.Size(85, 16);
            this.TekuciSaldoLbl.TabIndex = 45;
            this.TekuciSaldoLbl.Text = "Tekuci saldo";
            // 
            // DatumOtvaranjaRacunaLbl
            // 
            this.DatumOtvaranjaRacunaLbl.AutoSize = true;
            this.DatumOtvaranjaRacunaLbl.Location = new System.Drawing.Point(99, 66);
            this.DatumOtvaranjaRacunaLbl.Name = "DatumOtvaranjaRacunaLbl";
            this.DatumOtvaranjaRacunaLbl.Size = new System.Drawing.Size(149, 16);
            this.DatumOtvaranjaRacunaLbl.TabIndex = 42;
            this.DatumOtvaranjaRacunaLbl.Text = "Datum otvaranja racuna";
            // 
            // AkcijaRacunaBtn
            // 
            this.AkcijaRacunaBtn.Location = new System.Drawing.Point(105, 409);
            this.AkcijaRacunaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AkcijaRacunaBtn.Name = "AkcijaRacunaBtn";
            this.AkcijaRacunaBtn.Size = new System.Drawing.Size(316, 34);
            this.AkcijaRacunaBtn.TabIndex = 41;
            this.AkcijaRacunaBtn.UseVisualStyleBackColor = true;
            this.AkcijaRacunaBtn.Click += new System.EventHandler(this.AkcijaRacunaBtn_Click);
            // 
            // AddUpdateNaslovLbl
            // 
            this.AddUpdateNaslovLbl.AutoSize = true;
            this.AddUpdateNaslovLbl.Location = new System.Drawing.Point(30, 32);
            this.AddUpdateNaslovLbl.Name = "AddUpdateNaslovLbl";
            this.AddUpdateNaslovLbl.Size = new System.Drawing.Size(44, 16);
            this.AddUpdateNaslovLbl.TabIndex = 51;
            this.AddUpdateNaslovLbl.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 20);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Devizni";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(119, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 20);
            this.radioButton2.TabIndex = 53;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dinarski";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TipRacunaLbl
            // 
            this.TipRacunaLbl.AutoSize = true;
            this.TipRacunaLbl.Location = new System.Drawing.Point(103, 134);
            this.TipRacunaLbl.Name = "TipRacunaLbl";
            this.TipRacunaLbl.Size = new System.Drawing.Size(71, 16);
            this.TipRacunaLbl.TabIndex = 54;
            this.TipRacunaLbl.Text = "Tip racuna";
            // 
            // BankaRacunaLbl
            // 
            this.BankaRacunaLbl.AutoSize = true;
            this.BankaRacunaLbl.Location = new System.Drawing.Point(102, 263);
            this.BankaRacunaLbl.Name = "BankaRacunaLbl";
            this.BankaRacunaLbl.Size = new System.Drawing.Size(109, 16);
            this.BankaRacunaLbl.TabIndex = 55;
            this.BankaRacunaLbl.Text = "Odabrana banka";
            // 
            // BankeComboBox
            // 
            this.BankeComboBox.FormattingEnabled = true;
            this.BankeComboBox.Location = new System.Drawing.Point(104, 291);
            this.BankeComboBox.Name = "BankeComboBox";
            this.BankeComboBox.Size = new System.Drawing.Size(313, 24);
            this.BankeComboBox.TabIndex = 56;
            // 
            // ValutaLbl
            // 
            this.ValutaLbl.AutoSize = true;
            this.ValutaLbl.Location = new System.Drawing.Point(102, 332);
            this.ValutaLbl.Name = "ValutaLbl";
            this.ValutaLbl.Size = new System.Drawing.Size(45, 16);
            this.ValutaLbl.TabIndex = 57;
            this.ValutaLbl.Text = "Valuta";
            // 
            // ValutaTxtBx
            // 
            this.ValutaTxtBx.Location = new System.Drawing.Point(106, 352);
            this.ValutaTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.ValutaTxtBx.Name = "ValutaTxtBx";
            this.ValutaTxtBx.Size = new System.Drawing.Size(315, 22);
            this.ValutaTxtBx.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(106, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 38);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // Form_Racun_AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ValutaTxtBx);
            this.Controls.Add(this.ValutaLbl);
            this.Controls.Add(this.BankeComboBox);
            this.Controls.Add(this.BankaRacunaLbl);
            this.Controls.Add(this.TipRacunaLbl);
            this.Controls.Add(this.AddUpdateNaslovLbl);
            this.Controls.Add(this.DatumOtvaranjaRacunaDateTimePicker);
            this.Controls.Add(this.TekuciSaldoTxtBx);
            this.Controls.Add(this.TekuciSaldoLbl);
            this.Controls.Add(this.DatumOtvaranjaRacunaLbl);
            this.Controls.Add(this.AkcijaRacunaBtn);
            this.Name = "Form_Racun_AddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Racun_AddUpdate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatumOtvaranjaRacunaDateTimePicker;
        private System.Windows.Forms.TextBox TekuciSaldoTxtBx;
        private System.Windows.Forms.Label TekuciSaldoLbl;
        private System.Windows.Forms.Label DatumOtvaranjaRacunaLbl;
        private System.Windows.Forms.Button AkcijaRacunaBtn;
        private System.Windows.Forms.Label AddUpdateNaslovLbl;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label TipRacunaLbl;
        private System.Windows.Forms.Label BankaRacunaLbl;
        private System.Windows.Forms.ComboBox BankeComboBox;
        private System.Windows.Forms.Label ValutaLbl;
        private System.Windows.Forms.TextBox ValutaTxtBx;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}