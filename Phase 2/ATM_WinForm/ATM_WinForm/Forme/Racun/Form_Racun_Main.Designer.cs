namespace ATM_WinForm.Forme.Racun
{
    partial class Form_Racun_Main
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
            this.RacunGrid = new System.Windows.Forms.DataGridView();
            this.DodajRacunBtn = new System.Windows.Forms.Button();
            this.IzmeniRacunBtn = new System.Windows.Forms.Button();
            this.IzbrisiRacunBtn = new System.Windows.Forms.Button();
            this.PrikaziKorisnikaBtn = new System.Windows.Forms.Button();
            this.PrikaziKarticeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RacunGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RacunGrid
            // 
            this.RacunGrid.AllowUserToOrderColumns = true;
            this.RacunGrid.AllowUserToResizeRows = false;
            this.RacunGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RacunGrid.ColumnHeadersHeight = 29;
            this.RacunGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RacunGrid.Location = new System.Drawing.Point(13, 13);
            this.RacunGrid.Margin = new System.Windows.Forms.Padding(4);
            this.RacunGrid.MultiSelect = false;
            this.RacunGrid.Name = "RacunGrid";
            this.RacunGrid.ReadOnly = true;
            this.RacunGrid.RowHeadersWidth = 51;
            this.RacunGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RacunGrid.Size = new System.Drawing.Size(1191, 380);
            this.RacunGrid.TabIndex = 6;
            this.RacunGrid.SelectionChanged += new System.EventHandler(this.RacunGrid_SelectionChanged);
            // 
            // DodajRacunBtn
            // 
            this.DodajRacunBtn.Location = new System.Drawing.Point(13, 401);
            this.DodajRacunBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajRacunBtn.Name = "DodajRacunBtn";
            this.DodajRacunBtn.Size = new System.Drawing.Size(267, 41);
            this.DodajRacunBtn.TabIndex = 7;
            this.DodajRacunBtn.Text = "Dodaj Racun";
            this.DodajRacunBtn.UseVisualStyleBackColor = true;
            // 
            // IzmeniRacunBtn
            // 
            this.IzmeniRacunBtn.Enabled = false;
            this.IzmeniRacunBtn.Location = new System.Drawing.Point(13, 450);
            this.IzmeniRacunBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmeniRacunBtn.Name = "IzmeniRacunBtn";
            this.IzmeniRacunBtn.Size = new System.Drawing.Size(267, 41);
            this.IzmeniRacunBtn.TabIndex = 8;
            this.IzmeniRacunBtn.Text = "Izmeni Racun";
            this.IzmeniRacunBtn.UseVisualStyleBackColor = true;
            // 
            // IzbrisiRacunBtn
            // 
            this.IzbrisiRacunBtn.Enabled = false;
            this.IzbrisiRacunBtn.Location = new System.Drawing.Point(13, 499);
            this.IzbrisiRacunBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzbrisiRacunBtn.Name = "IzbrisiRacunBtn";
            this.IzbrisiRacunBtn.Size = new System.Drawing.Size(267, 41);
            this.IzbrisiRacunBtn.TabIndex = 9;
            this.IzbrisiRacunBtn.Text = "Izbrisi Racun";
            this.IzbrisiRacunBtn.UseVisualStyleBackColor = true;
            // 
            // PrikaziKorisnikaBtn
            // 
            this.PrikaziKorisnikaBtn.Location = new System.Drawing.Point(990, 404);
            this.PrikaziKorisnikaBtn.Name = "PrikaziKorisnikaBtn";
            this.PrikaziKorisnikaBtn.Size = new System.Drawing.Size(215, 38);
            this.PrikaziKorisnikaBtn.TabIndex = 10;
            this.PrikaziKorisnikaBtn.Text = "Prikazi korisnika";
            this.PrikaziKorisnikaBtn.UseVisualStyleBackColor = true;
            this.PrikaziKorisnikaBtn.Click += new System.EventHandler(this.PrikaziKorisnikaBtn_Click);
            // 
            // PrikaziKarticeBtn
            // 
            this.PrikaziKarticeBtn.Location = new System.Drawing.Point(990, 448);
            this.PrikaziKarticeBtn.Name = "PrikaziKarticeBtn";
            this.PrikaziKarticeBtn.Size = new System.Drawing.Size(215, 40);
            this.PrikaziKarticeBtn.TabIndex = 11;
            this.PrikaziKarticeBtn.Text = "Prikazi kartice";
            this.PrikaziKarticeBtn.UseVisualStyleBackColor = true;
            this.PrikaziKarticeBtn.Click += new System.EventHandler(this.PrikaziKarticeBtn_Click);
            // 
            // Form_Racun_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 558);
            this.Controls.Add(this.PrikaziKarticeBtn);
            this.Controls.Add(this.PrikaziKorisnikaBtn);
            this.Controls.Add(this.IzbrisiRacunBtn);
            this.Controls.Add(this.IzmeniRacunBtn);
            this.Controls.Add(this.DodajRacunBtn);
            this.Controls.Add(this.RacunGrid);
            this.Name = "Form_Racun_Main";
            this.Text = "ATM - Racuni";
            this.Load += new System.EventHandler(this.Form_Racun_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RacunGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RacunGrid;
        private System.Windows.Forms.Button DodajRacunBtn;
        private System.Windows.Forms.Button IzmeniRacunBtn;
        private System.Windows.Forms.Button IzbrisiRacunBtn;
        private System.Windows.Forms.Button PrikaziKorisnikaBtn;
        private System.Windows.Forms.Button PrikaziKarticeBtn;
    }
}