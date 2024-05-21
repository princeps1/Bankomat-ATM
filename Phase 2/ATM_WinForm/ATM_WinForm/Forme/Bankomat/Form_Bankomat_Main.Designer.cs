namespace ATM_WinForm.Forme.Bankomat
{
    partial class Form_Bankomat_Main
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
            this.IzbrisiBankomatBtn = new System.Windows.Forms.Button();
            this.IzmeniBankomatBtn = new System.Windows.Forms.Button();
            this.DodajBankomatBtn = new System.Windows.Forms.Button();
            this.BankomatGrid = new System.Windows.Forms.DataGridView();
            this.PrikaziKomentareBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankomatGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IzbrisiBankomatBtn
            // 
            this.IzbrisiBankomatBtn.Enabled = false;
            this.IzbrisiBankomatBtn.Location = new System.Drawing.Point(12, 409);
            this.IzbrisiBankomatBtn.Name = "IzbrisiBankomatBtn";
            this.IzbrisiBankomatBtn.Size = new System.Drawing.Size(200, 33);
            this.IzbrisiBankomatBtn.TabIndex = 12;
            this.IzbrisiBankomatBtn.Text = "Izbrisi Bankomat";
            this.IzbrisiBankomatBtn.UseVisualStyleBackColor = true;
            this.IzbrisiBankomatBtn.Click += new System.EventHandler(this.IzbrisiBankomatBtn_Click);
            // 
            // IzmeniBankomatBtn
            // 
            this.IzmeniBankomatBtn.Enabled = false;
            this.IzmeniBankomatBtn.Location = new System.Drawing.Point(12, 370);
            this.IzmeniBankomatBtn.Name = "IzmeniBankomatBtn";
            this.IzmeniBankomatBtn.Size = new System.Drawing.Size(200, 33);
            this.IzmeniBankomatBtn.TabIndex = 11;
            this.IzmeniBankomatBtn.Text = "Izmeni Bankomat";
            this.IzmeniBankomatBtn.UseVisualStyleBackColor = true;
            this.IzmeniBankomatBtn.Click += new System.EventHandler(this.IzmeniBankomatBtn_Click);
            // 
            // DodajBankomatBtn
            // 
            this.DodajBankomatBtn.Location = new System.Drawing.Point(12, 330);
            this.DodajBankomatBtn.Name = "DodajBankomatBtn";
            this.DodajBankomatBtn.Size = new System.Drawing.Size(200, 33);
            this.DodajBankomatBtn.TabIndex = 10;
            this.DodajBankomatBtn.Text = "Dodaj Bankomat";
            this.DodajBankomatBtn.UseVisualStyleBackColor = true;
            this.DodajBankomatBtn.Click += new System.EventHandler(this.DodajBankomatBtn_Click);
            // 
            // BankomatGrid
            // 
            this.BankomatGrid.AllowUserToOrderColumns = true;
            this.BankomatGrid.AllowUserToResizeRows = false;
            this.BankomatGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankomatGrid.ColumnHeadersHeight = 29;
            this.BankomatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BankomatGrid.Location = new System.Drawing.Point(12, 15);
            this.BankomatGrid.MultiSelect = false;
            this.BankomatGrid.Name = "BankomatGrid";
            this.BankomatGrid.ReadOnly = true;
            this.BankomatGrid.RowHeadersWidth = 51;
            this.BankomatGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BankomatGrid.Size = new System.Drawing.Size(890, 309);
            this.BankomatGrid.TabIndex = 9;
            this.BankomatGrid.SelectionChanged += new System.EventHandler(this.BankomatGrid_SelectionChanged);
            // 
            // PrikaziKomentareBtn
            // 
            this.PrikaziKomentareBtn.Location = new System.Drawing.Point(702, 330);
            this.PrikaziKomentareBtn.Name = "PrikaziKomentareBtn";
            this.PrikaziKomentareBtn.Size = new System.Drawing.Size(200, 33);
            this.PrikaziKomentareBtn.TabIndex = 23;
            this.PrikaziKomentareBtn.Text = "Prikazi Komentare";
            this.PrikaziKomentareBtn.UseVisualStyleBackColor = true;
            this.PrikaziKomentareBtn.Click += new System.EventHandler(this.PrikaziKomentareBtn_Click);
            // 
            // Form_Bankomat_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 457);
            this.Controls.Add(this.PrikaziKomentareBtn);
            this.Controls.Add(this.IzbrisiBankomatBtn);
            this.Controls.Add(this.IzmeniBankomatBtn);
            this.Controls.Add(this.DodajBankomatBtn);
            this.Controls.Add(this.BankomatGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_Bankomat_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Bankomati";
            this.Load += new System.EventHandler(this.Form_Bankomat_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankomatGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IzbrisiBankomatBtn;
        private System.Windows.Forms.Button IzmeniBankomatBtn;
        private System.Windows.Forms.Button DodajBankomatBtn;
        private System.Windows.Forms.DataGridView BankomatGrid;
        private System.Windows.Forms.Button PrikaziKomentareBtn;
    }
}