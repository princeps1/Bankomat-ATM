namespace ATM_WinForm.Forme.Bankomat
{
    partial class Form_OtklonjeneGreske_Main
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
            this.GreskeGrid = new System.Windows.Forms.DataGridView();
            this.IzbrisiGreskuBtn = new System.Windows.Forms.Button();
            this.IzmeniGreskuBtn = new System.Windows.Forms.Button();
            this.DodajGreskuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GreskeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GreskeGrid
            // 
            this.GreskeGrid.AllowUserToOrderColumns = true;
            this.GreskeGrid.AllowUserToResizeRows = false;
            this.GreskeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GreskeGrid.ColumnHeadersHeight = 35;
            this.GreskeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GreskeGrid.Location = new System.Drawing.Point(13, 13);
            this.GreskeGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GreskeGrid.MultiSelect = false;
            this.GreskeGrid.Name = "GreskeGrid";
            this.GreskeGrid.ReadOnly = true;
            this.GreskeGrid.RowHeadersWidth = 51;
            this.GreskeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GreskeGrid.Size = new System.Drawing.Size(1191, 380);
            this.GreskeGrid.TabIndex = 20;
            this.GreskeGrid.SelectionChanged += new System.EventHandler(this.GreskeGrid_SelectionChanged);
            // 
            // IzbrisiGreskuBtn
            // 
            this.IzbrisiGreskuBtn.Enabled = false;
            this.IzbrisiGreskuBtn.Location = new System.Drawing.Point(13, 505);
            this.IzbrisiGreskuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzbrisiGreskuBtn.Name = "IzbrisiGreskuBtn";
            this.IzbrisiGreskuBtn.Size = new System.Drawing.Size(267, 41);
            this.IzbrisiGreskuBtn.TabIndex = 25;
            this.IzbrisiGreskuBtn.Text = "Izbrisi Otklonjenu Gresku";
            this.IzbrisiGreskuBtn.UseVisualStyleBackColor = true;
            this.IzbrisiGreskuBtn.Click += new System.EventHandler(this.IzbrisiGreskuBtn_Click);
            // 
            // IzmeniGreskuBtn
            // 
            this.IzmeniGreskuBtn.Enabled = false;
            this.IzmeniGreskuBtn.Location = new System.Drawing.Point(13, 457);
            this.IzmeniGreskuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmeniGreskuBtn.Name = "IzmeniGreskuBtn";
            this.IzmeniGreskuBtn.Size = new System.Drawing.Size(267, 41);
            this.IzmeniGreskuBtn.TabIndex = 24;
            this.IzmeniGreskuBtn.Text = "Izmeni Otklonjenu Gresku";
            this.IzmeniGreskuBtn.UseVisualStyleBackColor = true;
            this.IzmeniGreskuBtn.Click += new System.EventHandler(this.IzmeniGreskuBtn_Click);
            // 
            // DodajGreskuBtn
            // 
            this.DodajGreskuBtn.Location = new System.Drawing.Point(13, 408);
            this.DodajGreskuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajGreskuBtn.Name = "DodajGreskuBtn";
            this.DodajGreskuBtn.Size = new System.Drawing.Size(267, 41);
            this.DodajGreskuBtn.TabIndex = 23;
            this.DodajGreskuBtn.Text = "Dodaj Otklonjenu Gresku";
            this.DodajGreskuBtn.UseVisualStyleBackColor = true;
            this.DodajGreskuBtn.Click += new System.EventHandler(this.DodajGreskuBtn_Click);
            // 
            // Form_OtklonjeneGreske_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 571);
            this.Controls.Add(this.IzbrisiGreskuBtn);
            this.Controls.Add(this.IzmeniGreskuBtn);
            this.Controls.Add(this.DodajGreskuBtn);
            this.Controls.Add(this.GreskeGrid);
            this.Name = "Form_OtklonjeneGreske_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Otklonjene greske servisa";
            this.Load += new System.EventHandler(this.Form_OtklonjeneGreske_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GreskeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GreskeGrid;
        private System.Windows.Forms.Button IzbrisiGreskuBtn;
        private System.Windows.Forms.Button IzmeniGreskuBtn;
        private System.Windows.Forms.Button DodajGreskuBtn;
    }
}