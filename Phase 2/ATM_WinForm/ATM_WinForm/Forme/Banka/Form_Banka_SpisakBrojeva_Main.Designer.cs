namespace ATM_WinForm.Forme.Banka
{
    partial class Form_Banka_SpisakBrojeva_Main
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
            this.BankaBrTelGrid = new System.Windows.Forms.DataGridView();
            this.IzbrisiBrojTelefonaBtn = new System.Windows.Forms.Button();
            this.IzmeniBrojTelefonaBtn = new System.Windows.Forms.Button();
            this.DodajBrojTelefonaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankaBrTelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BankaBrTelGrid
            // 
            this.BankaBrTelGrid.AllowUserToOrderColumns = true;
            this.BankaBrTelGrid.AllowUserToResizeRows = false;
            this.BankaBrTelGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankaBrTelGrid.ColumnHeadersHeight = 29;
            this.BankaBrTelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BankaBrTelGrid.Location = new System.Drawing.Point(19, 17);
            this.BankaBrTelGrid.Margin = new System.Windows.Forms.Padding(4);
            this.BankaBrTelGrid.MultiSelect = false;
            this.BankaBrTelGrid.Name = "BankaBrTelGrid";
            this.BankaBrTelGrid.ReadOnly = true;
            this.BankaBrTelGrid.RowHeadersWidth = 51;
            this.BankaBrTelGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BankaBrTelGrid.Size = new System.Drawing.Size(1177, 380);
            this.BankaBrTelGrid.TabIndex = 8;
            this.BankaBrTelGrid.SelectionChanged += new System.EventHandler(this.BankaBrTelGrid_SelectionChanged);
            // 
            // IzbrisiBrojTelefonaBtn
            // 
            this.IzbrisiBrojTelefonaBtn.Enabled = false;
            this.IzbrisiBrojTelefonaBtn.Location = new System.Drawing.Point(19, 501);
            this.IzbrisiBrojTelefonaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzbrisiBrojTelefonaBtn.Name = "IzbrisiBrojTelefonaBtn";
            this.IzbrisiBrojTelefonaBtn.Size = new System.Drawing.Size(267, 41);
            this.IzbrisiBrojTelefonaBtn.TabIndex = 7;
            this.IzbrisiBrojTelefonaBtn.Text = "Izbrisi Broj Telefona";
            this.IzbrisiBrojTelefonaBtn.UseVisualStyleBackColor = true;
            this.IzbrisiBrojTelefonaBtn.Click += new System.EventHandler(this.IzbrisiBrojTelefonaBtn_Click);
            // 
            // IzmeniBrojTelefonaBtn
            // 
            this.IzmeniBrojTelefonaBtn.Enabled = false;
            this.IzmeniBrojTelefonaBtn.Location = new System.Drawing.Point(19, 453);
            this.IzmeniBrojTelefonaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmeniBrojTelefonaBtn.Name = "IzmeniBrojTelefonaBtn";
            this.IzmeniBrojTelefonaBtn.Size = new System.Drawing.Size(267, 41);
            this.IzmeniBrojTelefonaBtn.TabIndex = 6;
            this.IzmeniBrojTelefonaBtn.Text = "Izmeni Broj Telefona";
            this.IzmeniBrojTelefonaBtn.UseVisualStyleBackColor = true;
            this.IzmeniBrojTelefonaBtn.Click += new System.EventHandler(this.IzmeniBrojTelefonaBtn_Click);
            // 
            // DodajBrojTelefonaBtn
            // 
            this.DodajBrojTelefonaBtn.Location = new System.Drawing.Point(19, 405);
            this.DodajBrojTelefonaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajBrojTelefonaBtn.Name = "DodajBrojTelefonaBtn";
            this.DodajBrojTelefonaBtn.Size = new System.Drawing.Size(267, 41);
            this.DodajBrojTelefonaBtn.TabIndex = 5;
            this.DodajBrojTelefonaBtn.Text = "Dodaj Broj Telefona";
            this.DodajBrojTelefonaBtn.UseVisualStyleBackColor = true;
            this.DodajBrojTelefonaBtn.Click += new System.EventHandler(this.DodajBrojTelefonaBtn_Click);
            // 
            // Form_Banka_SpisakBrojeva_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 559);
            this.Controls.Add(this.BankaBrTelGrid);
            this.Controls.Add(this.IzbrisiBrojTelefonaBtn);
            this.Controls.Add(this.IzmeniBrojTelefonaBtn);
            this.Controls.Add(this.DodajBrojTelefonaBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Banka_SpisakBrojeva_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Brojevi Telefona Banke";
            this.Load += new System.EventHandler(this.Form_Banka_SpisakBrojeva_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankaBrTelGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BankaBrTelGrid;
        private System.Windows.Forms.Button IzbrisiBrojTelefonaBtn;
        private System.Windows.Forms.Button IzmeniBrojTelefonaBtn;
        private System.Windows.Forms.Button DodajBrojTelefonaBtn;
    }
}