namespace ATM_WinForm
{
    partial class Form_Filijala_Main
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
            this.FilijalaGrid = new System.Windows.Forms.DataGridView();
            this.DodajFilijaluBtn = new System.Windows.Forms.Button();
            this.IzmeniFilijaluBtn = new System.Windows.Forms.Button();
            this.IzbrisiFilijaluBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilijalaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FilijalaGrid
            // 
            this.FilijalaGrid.AllowUserToOrderColumns = true;
            this.FilijalaGrid.AllowUserToResizeRows = false;
            this.FilijalaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FilijalaGrid.ColumnHeadersHeight = 29;
            this.FilijalaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FilijalaGrid.Location = new System.Drawing.Point(13, 13);
            this.FilijalaGrid.Margin = new System.Windows.Forms.Padding(4);
            this.FilijalaGrid.MultiSelect = false;
            this.FilijalaGrid.Name = "FilijalaGrid";
            this.FilijalaGrid.ReadOnly = true;
            this.FilijalaGrid.RowHeadersWidth = 51;
            this.FilijalaGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FilijalaGrid.Size = new System.Drawing.Size(1187, 380);
            this.FilijalaGrid.TabIndex = 5;
            // 
            // DodajFilijaluBtn
            // 
            this.DodajFilijaluBtn.Location = new System.Drawing.Point(13, 401);
            this.DodajFilijaluBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajFilijaluBtn.Name = "DodajFilijaluBtn";
            this.DodajFilijaluBtn.Size = new System.Drawing.Size(267, 41);
            this.DodajFilijaluBtn.TabIndex = 6;
            this.DodajFilijaluBtn.Text = "Dodaj Filijalu";
            this.DodajFilijaluBtn.UseVisualStyleBackColor = true;
            this.DodajFilijaluBtn.Click += new System.EventHandler(this.DodajFilijaluBtn_Click);
            // 
            // IzmeniFilijaluBtn
            // 
            this.IzmeniFilijaluBtn.Enabled = false;
            this.IzmeniFilijaluBtn.Location = new System.Drawing.Point(13, 450);
            this.IzmeniFilijaluBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmeniFilijaluBtn.Name = "IzmeniFilijaluBtn";
            this.IzmeniFilijaluBtn.Size = new System.Drawing.Size(267, 41);
            this.IzmeniFilijaluBtn.TabIndex = 7;
            this.IzmeniFilijaluBtn.Text = "Izmeni Filijalu";
            this.IzmeniFilijaluBtn.UseVisualStyleBackColor = true;
            // 
            // IzbrisiFilijaluBtn
            // 
            this.IzbrisiFilijaluBtn.Enabled = false;
            this.IzbrisiFilijaluBtn.Location = new System.Drawing.Point(13, 499);
            this.IzbrisiFilijaluBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzbrisiFilijaluBtn.Name = "IzbrisiFilijaluBtn";
            this.IzbrisiFilijaluBtn.Size = new System.Drawing.Size(267, 41);
            this.IzbrisiFilijaluBtn.TabIndex = 8;
            this.IzbrisiFilijaluBtn.Text = "Izbrisi Filijalu";
            this.IzbrisiFilijaluBtn.UseVisualStyleBackColor = true;
            // 
            // Form_Filijala_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 558);
            this.Controls.Add(this.IzbrisiFilijaluBtn);
            this.Controls.Add(this.IzmeniFilijaluBtn);
            this.Controls.Add(this.DodajFilijaluBtn);
            this.Controls.Add(this.FilijalaGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_Filijala_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM -  Filijale";
            this.Load += new System.EventHandler(this.Form_Filijala_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilijalaGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FilijalaGrid;
        private System.Windows.Forms.Button DodajFilijaluBtn;
        private System.Windows.Forms.Button IzmeniFilijaluBtn;
        private System.Windows.Forms.Button IzbrisiFilijaluBtn;
    }
}