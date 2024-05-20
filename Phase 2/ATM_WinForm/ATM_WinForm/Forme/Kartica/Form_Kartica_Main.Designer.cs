namespace ATM_WinForm.Forme.Kartica
{
    partial class Form_Kartica_Main
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
            this.KarticaGrid = new System.Windows.Forms.DataGridView();
            this.DodajKarticuBtn = new System.Windows.Forms.Button();
            this.IzmeniKarticuBtn = new System.Windows.Forms.Button();
            this.IzbrisiKarticuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KarticaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // KarticaGrid
            // 
            this.KarticaGrid.AllowUserToOrderColumns = true;
            this.KarticaGrid.AllowUserToResizeRows = false;
            this.KarticaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KarticaGrid.ColumnHeadersHeight = 35;
            this.KarticaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.KarticaGrid.Location = new System.Drawing.Point(13, 13);
            this.KarticaGrid.Margin = new System.Windows.Forms.Padding(4);
            this.KarticaGrid.MultiSelect = false;
            this.KarticaGrid.Name = "KarticaGrid";
            this.KarticaGrid.ReadOnly = true;
            this.KarticaGrid.RowHeadersWidth = 51;
            this.KarticaGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.KarticaGrid.Size = new System.Drawing.Size(1187, 380);
            this.KarticaGrid.TabIndex = 10;
            this.KarticaGrid.SelectionChanged += new System.EventHandler(this.KarticaGrid_SelectionChanged);
            // 
            // DodajKarticuBtn
            // 
            this.DodajKarticuBtn.Location = new System.Drawing.Point(13, 401);
            this.DodajKarticuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajKarticuBtn.Name = "DodajKarticuBtn";
            this.DodajKarticuBtn.Size = new System.Drawing.Size(267, 41);
            this.DodajKarticuBtn.TabIndex = 11;
            this.DodajKarticuBtn.Text = "Dodaj Karticu";
            this.DodajKarticuBtn.UseVisualStyleBackColor = true;
            this.DodajKarticuBtn.Click += new System.EventHandler(this.DodajKarticuBtn_Click);
            // 
            // IzmeniKarticuBtn
            // 
            this.IzmeniKarticuBtn.Enabled = false;
            this.IzmeniKarticuBtn.Location = new System.Drawing.Point(13, 450);
            this.IzmeniKarticuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmeniKarticuBtn.Name = "IzmeniKarticuBtn";
            this.IzmeniKarticuBtn.Size = new System.Drawing.Size(267, 41);
            this.IzmeniKarticuBtn.TabIndex = 12;
            this.IzmeniKarticuBtn.Text = "Izmeni Karticu";
            this.IzmeniKarticuBtn.UseVisualStyleBackColor = true;
            this.IzmeniKarticuBtn.Click += new System.EventHandler(this.IzmeniKarticuBtn_Click);
            // 
            // IzbrisiKarticuBtn
            // 
            this.IzbrisiKarticuBtn.Enabled = false;
            this.IzbrisiKarticuBtn.Location = new System.Drawing.Point(13, 499);
            this.IzbrisiKarticuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzbrisiKarticuBtn.Name = "IzbrisiKarticuBtn";
            this.IzbrisiKarticuBtn.Size = new System.Drawing.Size(267, 41);
            this.IzbrisiKarticuBtn.TabIndex = 13;
            this.IzbrisiKarticuBtn.Text = "Izbrisi Karticu";
            this.IzbrisiKarticuBtn.UseVisualStyleBackColor = true;
            this.IzbrisiKarticuBtn.Click += new System.EventHandler(this.IzbrisiKarticuBtn_Click);
            // 
            // Form_Kartica_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 558);
            this.Controls.Add(this.IzbrisiKarticuBtn);
            this.Controls.Add(this.IzmeniKarticuBtn);
            this.Controls.Add(this.DodajKarticuBtn);
            this.Controls.Add(this.KarticaGrid);
            this.Name = "Form_Kartica_Main";
            this.Text = "ATM - Kartice";
            this.Load += new System.EventHandler(this.Form_Kartica_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KarticaGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KarticaGrid;
        private System.Windows.Forms.Button DodajKarticuBtn;
        private System.Windows.Forms.Button IzmeniKarticuBtn;
        private System.Windows.Forms.Button IzbrisiKarticuBtn;
    }
}