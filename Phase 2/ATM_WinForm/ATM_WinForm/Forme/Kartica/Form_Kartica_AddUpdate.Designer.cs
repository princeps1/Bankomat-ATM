namespace ATM_WinForm.Forme.Kartica
{
    partial class Form_Kartica_AddUpdate
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
            this.AkcijaKarticeBtn = new System.Windows.Forms.Button();
            this.DnevniLimitTxtBx = new System.Windows.Forms.TextBox();
            this.RadnoVremeLbl = new System.Windows.Forms.Label();
            this.DatumIstekaLbl = new System.Windows.Forms.Label();
            this.DatumIzdavanjaLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipComboBox = new System.Windows.Forms.ComboBox();
            this.MaxIznosZaduzenjaLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxIznosZaduzenjaTxtBx = new System.Windows.Forms.TextBox();
            this.DatumIstekaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MaxDatumVracanjaDugaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatumIzdavanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AkcijaKarticeBtn
            // 
            this.AkcijaKarticeBtn.Location = new System.Drawing.Point(99, 410);
            this.AkcijaKarticeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AkcijaKarticeBtn.Name = "AkcijaKarticeBtn";
            this.AkcijaKarticeBtn.Size = new System.Drawing.Size(316, 34);
            this.AkcijaKarticeBtn.TabIndex = 27;
            this.AkcijaKarticeBtn.UseVisualStyleBackColor = true;
            this.AkcijaKarticeBtn.Click += new System.EventHandler(this.AkcijaKarticeBtn_Click);
            // 
            // DnevniLimitTxtBx
            // 
            this.DnevniLimitTxtBx.Location = new System.Drawing.Point(103, 170);
            this.DnevniLimitTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.DnevniLimitTxtBx.Name = "DnevniLimitTxtBx";
            this.DnevniLimitTxtBx.Size = new System.Drawing.Size(315, 22);
            this.DnevniLimitTxtBx.TabIndex = 26;
            // 
            // RadnoVremeLbl
            // 
            this.RadnoVremeLbl.AutoSize = true;
            this.RadnoVremeLbl.Location = new System.Drawing.Point(100, 150);
            this.RadnoVremeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RadnoVremeLbl.Name = "RadnoVremeLbl";
            this.RadnoVremeLbl.Size = new System.Drawing.Size(75, 16);
            this.RadnoVremeLbl.TabIndex = 25;
            this.RadnoVremeLbl.Text = "Dnevni limit";
            // 
            // DatumIstekaLbl
            // 
            this.DatumIstekaLbl.AutoSize = true;
            this.DatumIstekaLbl.Location = new System.Drawing.Point(98, 80);
            this.DatumIstekaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatumIstekaLbl.Name = "DatumIstekaLbl";
            this.DatumIstekaLbl.Size = new System.Drawing.Size(85, 16);
            this.DatumIstekaLbl.TabIndex = 23;
            this.DatumIstekaLbl.Text = "Datum isteka";
            // 
            // DatumIzdavanjaLbl
            // 
            this.DatumIzdavanjaLbl.AutoSize = true;
            this.DatumIzdavanjaLbl.Location = new System.Drawing.Point(97, 22);
            this.DatumIzdavanjaLbl.Name = "DatumIzdavanjaLbl";
            this.DatumIzdavanjaLbl.Size = new System.Drawing.Size(107, 16);
            this.DatumIzdavanjaLbl.TabIndex = 29;
            this.DatumIzdavanjaLbl.Text = "Datum izdavanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tip";
            // 
            // TipComboBox
            // 
            this.TipComboBox.Items.AddRange(new object[] {
            "kreditna",
            "debitna"});
            this.TipComboBox.Location = new System.Drawing.Point(103, 235);
            this.TipComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TipComboBox.MaxDropDownItems = 50;
            this.TipComboBox.Name = "TipComboBox";
            this.TipComboBox.Size = new System.Drawing.Size(316, 24);
            this.TipComboBox.TabIndex = 31;
            this.TipComboBox.SelectedIndexChanged += new System.EventHandler(this.TipComboBox_SelectedIndexChanged);
            // 
            // MaxIznosZaduzenjaLbl
            // 
            this.MaxIznosZaduzenjaLbl.AutoSize = true;
            this.MaxIznosZaduzenjaLbl.Location = new System.Drawing.Point(98, 276);
            this.MaxIznosZaduzenjaLbl.Name = "MaxIznosZaduzenjaLbl";
            this.MaxIznosZaduzenjaLbl.Size = new System.Drawing.Size(178, 16);
            this.MaxIznosZaduzenjaLbl.TabIndex = 32;
            this.MaxIznosZaduzenjaLbl.Text = "Maksimalan iznos zaduzenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Maksimalan datum vracanja duga";
            // 
            // MaxIznosZaduzenjaTxtBx
            // 
            this.MaxIznosZaduzenjaTxtBx.Location = new System.Drawing.Point(103, 296);
            this.MaxIznosZaduzenjaTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.MaxIznosZaduzenjaTxtBx.Name = "MaxIznosZaduzenjaTxtBx";
            this.MaxIznosZaduzenjaTxtBx.Size = new System.Drawing.Size(315, 22);
            this.MaxIznosZaduzenjaTxtBx.TabIndex = 34;
            // 
            // DatumIstekaDateTimePicker
            // 
            this.DatumIstekaDateTimePicker.Location = new System.Drawing.Point(100, 114);
            this.DatumIstekaDateTimePicker.Name = "DatumIstekaDateTimePicker";
            this.DatumIstekaDateTimePicker.Size = new System.Drawing.Size(312, 22);
            this.DatumIstekaDateTimePicker.TabIndex = 35;
            // 
            // MaxDatumVracanjaDugaDateTimePicker
            // 
            this.MaxDatumVracanjaDugaDateTimePicker.Location = new System.Drawing.Point(103, 355);
            this.MaxDatumVracanjaDugaDateTimePicker.Name = "MaxDatumVracanjaDugaDateTimePicker";
            this.MaxDatumVracanjaDugaDateTimePicker.Size = new System.Drawing.Size(316, 22);
            this.MaxDatumVracanjaDugaDateTimePicker.TabIndex = 36;
            // 
            // DatumIzdavanjaDateTimePicker
            // 
            this.DatumIzdavanjaDateTimePicker.Location = new System.Drawing.Point(99, 41);
            this.DatumIzdavanjaDateTimePicker.Name = "DatumIzdavanjaDateTimePicker";
            this.DatumIzdavanjaDateTimePicker.Size = new System.Drawing.Size(309, 22);
            this.DatumIzdavanjaDateTimePicker.TabIndex = 37;
            // 
            // Form_Kartica_AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 487);
            this.Controls.Add(this.DatumIzdavanjaDateTimePicker);
            this.Controls.Add(this.MaxDatumVracanjaDugaDateTimePicker);
            this.Controls.Add(this.DatumIstekaDateTimePicker);
            this.Controls.Add(this.MaxIznosZaduzenjaTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxIznosZaduzenjaLbl);
            this.Controls.Add(this.TipComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatumIzdavanjaLbl);
            this.Controls.Add(this.AkcijaKarticeBtn);
            this.Controls.Add(this.DnevniLimitTxtBx);
            this.Controls.Add(this.RadnoVremeLbl);
            this.Controls.Add(this.DatumIstekaLbl);
            this.Name = "Form_Kartica_AddUpdate";
            this.Text = "Form_Kartica_AddUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AkcijaKarticeBtn;
        private System.Windows.Forms.TextBox DnevniLimitTxtBx;
        private System.Windows.Forms.Label RadnoVremeLbl;
        private System.Windows.Forms.Label DatumIstekaLbl;
        private System.Windows.Forms.Label DatumIzdavanjaLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipComboBox;
        private System.Windows.Forms.Label MaxIznosZaduzenjaLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxIznosZaduzenjaTxtBx;
        private System.Windows.Forms.DateTimePicker DatumIstekaDateTimePicker;
        private System.Windows.Forms.DateTimePicker MaxDatumVracanjaDugaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DatumIzdavanjaDateTimePicker;
    }
}