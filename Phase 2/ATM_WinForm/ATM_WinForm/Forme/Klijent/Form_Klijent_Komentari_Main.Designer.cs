﻿namespace ATM_WinForm.Forme.Klijent
{
    partial class Form_Klijent_Komentari_Main
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
            this.IzbrisiKomentarBtn = new System.Windows.Forms.Button();
            this.IzmeniKomentarBtn = new System.Windows.Forms.Button();
            this.DodajKomentarBtn = new System.Windows.Forms.Button();
            this.KomentariGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KomentariGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IzbrisiKomentarBtn
            // 
            this.IzbrisiKomentarBtn.Enabled = false;
            this.IzbrisiKomentarBtn.Location = new System.Drawing.Point(11, 409);
            this.IzbrisiKomentarBtn.Name = "IzbrisiKomentarBtn";
            this.IzbrisiKomentarBtn.Size = new System.Drawing.Size(200, 33);
            this.IzbrisiKomentarBtn.TabIndex = 18;
            this.IzbrisiKomentarBtn.Text = "Izbrisi Komentar";
            this.IzbrisiKomentarBtn.UseVisualStyleBackColor = true;
            this.IzbrisiKomentarBtn.Click += new System.EventHandler(this.IzbrisiKomentarBtn_Click);
            // 
            // IzmeniKomentarBtn
            // 
            this.IzmeniKomentarBtn.Enabled = false;
            this.IzmeniKomentarBtn.Location = new System.Drawing.Point(11, 370);
            this.IzmeniKomentarBtn.Name = "IzmeniKomentarBtn";
            this.IzmeniKomentarBtn.Size = new System.Drawing.Size(200, 33);
            this.IzmeniKomentarBtn.TabIndex = 17;
            this.IzmeniKomentarBtn.Text = "Izmeni Komentar";
            this.IzmeniKomentarBtn.UseVisualStyleBackColor = true;
            this.IzmeniKomentarBtn.Click += new System.EventHandler(this.IzmeniKomentarBtn_Click);
            // 
            // DodajKomentarBtn
            // 
            this.DodajKomentarBtn.Location = new System.Drawing.Point(11, 330);
            this.DodajKomentarBtn.Name = "DodajKomentarBtn";
            this.DodajKomentarBtn.Size = new System.Drawing.Size(200, 33);
            this.DodajKomentarBtn.TabIndex = 16;
            this.DodajKomentarBtn.Text = "Dodaj Komentar";
            this.DodajKomentarBtn.UseVisualStyleBackColor = true;
            this.DodajKomentarBtn.Click += new System.EventHandler(this.DodajKomentarBtn_Click);
            // 
            // KomentariGrid
            // 
            this.KomentariGrid.AllowUserToOrderColumns = true;
            this.KomentariGrid.AllowUserToResizeRows = false;
            this.KomentariGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KomentariGrid.ColumnHeadersHeight = 35;
            this.KomentariGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.KomentariGrid.Location = new System.Drawing.Point(11, 15);
            this.KomentariGrid.MultiSelect = false;
            this.KomentariGrid.Name = "KomentariGrid";
            this.KomentariGrid.ReadOnly = true;
            this.KomentariGrid.RowHeadersWidth = 51;
            this.KomentariGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.KomentariGrid.Size = new System.Drawing.Size(893, 309);
            this.KomentariGrid.TabIndex = 15;
            this.KomentariGrid.SelectionChanged += new System.EventHandler(this.KomentariGrid_SelectionChanged);
            // 
            // Form_Klijent_Komentari_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 457);
            this.Controls.Add(this.IzbrisiKomentarBtn);
            this.Controls.Add(this.IzmeniKomentarBtn);
            this.Controls.Add(this.DodajKomentarBtn);
            this.Controls.Add(this.KomentariGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Klijent_Komentari_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Komentari Klijenta";
            this.Load += new System.EventHandler(this.Form_Klijent_Komentari_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KomentariGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IzbrisiKomentarBtn;
        private System.Windows.Forms.Button IzmeniKomentarBtn;
        private System.Windows.Forms.Button DodajKomentarBtn;
        private System.Windows.Forms.DataGridView KomentariGrid;
    }
}