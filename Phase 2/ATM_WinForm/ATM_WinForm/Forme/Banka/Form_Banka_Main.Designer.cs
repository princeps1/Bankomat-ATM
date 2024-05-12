namespace ATM_WinForm
{
    partial class Form_Banka_Main
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
            this.DodajBankuBtn = new System.Windows.Forms.Button();
            this.IzmeniBankuBtn = new System.Windows.Forms.Button();
            this.IzbrisiBankuBtn = new System.Windows.Forms.Button();
            this.BankaGrid = new System.Windows.Forms.DataGridView();
            this.BtnPregledFilijala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajBankuBtn
            // 
            this.DodajBankuBtn.Location = new System.Drawing.Point(16, 402);
            this.DodajBankuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajBankuBtn.Name = "DodajBankuBtn";
            this.DodajBankuBtn.Size = new System.Drawing.Size(267, 41);
            this.DodajBankuBtn.TabIndex = 1;
            this.DodajBankuBtn.Text = "Dodaj Banku";
            this.DodajBankuBtn.UseVisualStyleBackColor = true;
            this.DodajBankuBtn.Click += new System.EventHandler(this.DodajBankuBtn_Click);
            // 
            // IzmeniBankuBtn
            // 
            this.IzmeniBankuBtn.Enabled = false;
            this.IzmeniBankuBtn.Location = new System.Drawing.Point(16, 450);
            this.IzmeniBankuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmeniBankuBtn.Name = "IzmeniBankuBtn";
            this.IzmeniBankuBtn.Size = new System.Drawing.Size(267, 41);
            this.IzmeniBankuBtn.TabIndex = 2;
            this.IzmeniBankuBtn.Text = "Izmeni Banku";
            this.IzmeniBankuBtn.UseVisualStyleBackColor = true;
            this.IzmeniBankuBtn.Click += new System.EventHandler(this.IzmeniBankuBtn_Click);
            // 
            // IzbrisiBankuBtn
            // 
            this.IzbrisiBankuBtn.Enabled = false;
            this.IzbrisiBankuBtn.Location = new System.Drawing.Point(16, 498);
            this.IzbrisiBankuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzbrisiBankuBtn.Name = "IzbrisiBankuBtn";
            this.IzbrisiBankuBtn.Size = new System.Drawing.Size(267, 41);
            this.IzbrisiBankuBtn.TabIndex = 3;
            this.IzbrisiBankuBtn.Text = "Izbrisi Banku";
            this.IzbrisiBankuBtn.UseVisualStyleBackColor = true;
            this.IzbrisiBankuBtn.Click += new System.EventHandler(this.IzbrisiBankuBtn_Click);
            // 
            // BankaGrid
            // 
            this.BankaGrid.AllowUserToOrderColumns = true;
            this.BankaGrid.AllowUserToResizeRows = false;
            this.BankaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankaGrid.ColumnHeadersHeight = 29;
            this.BankaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BankaGrid.Location = new System.Drawing.Point(16, 15);
            this.BankaGrid.Margin = new System.Windows.Forms.Padding(4);
            this.BankaGrid.MultiSelect = false;
            this.BankaGrid.Name = "BankaGrid";
            this.BankaGrid.ReadOnly = true;
            this.BankaGrid.RowHeadersWidth = 51;
            this.BankaGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BankaGrid.Size = new System.Drawing.Size(1177, 380);
            this.BankaGrid.TabIndex = 4;
            this.BankaGrid.SelectionChanged += new System.EventHandler(this.BankaGrid_SelectionChanged);
            // 
            // BtnPregledFilijala
            // 
            this.BtnPregledFilijala.Location = new System.Drawing.Point(991, 409);
            this.BtnPregledFilijala.Name = "BtnPregledFilijala";
            this.BtnPregledFilijala.Size = new System.Drawing.Size(202, 34);
            this.BtnPregledFilijala.TabIndex = 5;
            this.BtnPregledFilijala.Text = "Pregled filijala";
            this.BtnPregledFilijala.UseVisualStyleBackColor = true;
            this.BtnPregledFilijala.Click += new System.EventHandler(this.BtnPregledFilijala_Click);
            // 
            // Form_Banka_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 554);
            this.Controls.Add(this.BtnPregledFilijala);
            this.Controls.Add(this.BankaGrid);
            this.Controls.Add(this.IzbrisiBankuBtn);
            this.Controls.Add(this.IzmeniBankuBtn);
            this.Controls.Add(this.DodajBankuBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Banka_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Banke";
            this.Load += new System.EventHandler(this.Form_Banka_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankaGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DodajBankuBtn;
        private System.Windows.Forms.Button IzmeniBankuBtn;
        private System.Windows.Forms.Button IzbrisiBankuBtn;
        private System.Windows.Forms.DataGridView BankaGrid;
        private System.Windows.Forms.Button BtnPregledFilijala;
    }
}