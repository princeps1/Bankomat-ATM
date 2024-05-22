namespace ATM_WinForm.Forme.Bankomat
{
    partial class Form_Servis_Main
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
            this.ServisiGrid = new System.Windows.Forms.DataGridView();
            this.IzbrisiServisBtn = new System.Windows.Forms.Button();
            this.IzmeniServisBtn = new System.Windows.Forms.Button();
            this.DodajServisBtn = new System.Windows.Forms.Button();
            this.PrikaziGreskeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServisiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ServisiGrid
            // 
            this.ServisiGrid.AllowUserToOrderColumns = true;
            this.ServisiGrid.AllowUserToResizeRows = false;
            this.ServisiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServisiGrid.ColumnHeadersHeight = 35;
            this.ServisiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ServisiGrid.Location = new System.Drawing.Point(13, 13);
            this.ServisiGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ServisiGrid.MultiSelect = false;
            this.ServisiGrid.Name = "ServisiGrid";
            this.ServisiGrid.ReadOnly = true;
            this.ServisiGrid.RowHeadersWidth = 51;
            this.ServisiGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ServisiGrid.Size = new System.Drawing.Size(1191, 380);
            this.ServisiGrid.TabIndex = 20;
            this.ServisiGrid.SelectionChanged += new System.EventHandler(this.ServisiGrid_SelectionChanged);
            // 
            // IzbrisiServisBtn
            // 
            this.IzbrisiServisBtn.Enabled = false;
            this.IzbrisiServisBtn.Location = new System.Drawing.Point(13, 498);
            this.IzbrisiServisBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzbrisiServisBtn.Name = "IzbrisiServisBtn";
            this.IzbrisiServisBtn.Size = new System.Drawing.Size(267, 41);
            this.IzbrisiServisBtn.TabIndex = 25;
            this.IzbrisiServisBtn.Text = "Izbrisi Servis";
            this.IzbrisiServisBtn.UseVisualStyleBackColor = true;
            this.IzbrisiServisBtn.Click += new System.EventHandler(this.IzbrisiServisBtn_Click);
            // 
            // IzmeniServisBtn
            // 
            this.IzmeniServisBtn.Enabled = false;
            this.IzmeniServisBtn.Location = new System.Drawing.Point(13, 450);
            this.IzmeniServisBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmeniServisBtn.Name = "IzmeniServisBtn";
            this.IzmeniServisBtn.Size = new System.Drawing.Size(267, 41);
            this.IzmeniServisBtn.TabIndex = 24;
            this.IzmeniServisBtn.Text = "Izmeni Servis";
            this.IzmeniServisBtn.UseVisualStyleBackColor = true;
            this.IzmeniServisBtn.Click += new System.EventHandler(this.IzmeniServisBtn_Click);
            // 
            // DodajServisBtn
            // 
            this.DodajServisBtn.Location = new System.Drawing.Point(13, 401);
            this.DodajServisBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajServisBtn.Name = "DodajServisBtn";
            this.DodajServisBtn.Size = new System.Drawing.Size(267, 41);
            this.DodajServisBtn.TabIndex = 23;
            this.DodajServisBtn.Text = "Dodaj Servis";
            this.DodajServisBtn.UseVisualStyleBackColor = true;
            this.DodajServisBtn.Click += new System.EventHandler(this.DodajServisBtn_Click);
            // 
            // PrikaziGreskeBtn
            // 
            this.PrikaziGreskeBtn.Location = new System.Drawing.Point(937, 412);
            this.PrikaziGreskeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrikaziGreskeBtn.Name = "PrikaziGreskeBtn";
            this.PrikaziGreskeBtn.Size = new System.Drawing.Size(267, 41);
            this.PrikaziGreskeBtn.TabIndex = 26;
            this.PrikaziGreskeBtn.Text = "Pregled otklonjenih gresaka";
            this.PrikaziGreskeBtn.UseVisualStyleBackColor = true;
            this.PrikaziGreskeBtn.Click += new System.EventHandler(this.PrikaziGreskeBtn_Click);
            // 
            // Form_Servis_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 571);
            this.Controls.Add(this.PrikaziGreskeBtn);
            this.Controls.Add(this.IzbrisiServisBtn);
            this.Controls.Add(this.IzmeniServisBtn);
            this.Controls.Add(this.DodajServisBtn);
            this.Controls.Add(this.ServisiGrid);
            this.Name = "Form_Servis_Main";
            this.Text = "ATM - Servisi Bankomata";
            this.Load += new System.EventHandler(this.Form_Servis_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServisiGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ServisiGrid;
        private System.Windows.Forms.Button IzbrisiServisBtn;
        private System.Windows.Forms.Button IzmeniServisBtn;
        private System.Windows.Forms.Button DodajServisBtn;
        private System.Windows.Forms.Button PrikaziGreskeBtn;
    }
}