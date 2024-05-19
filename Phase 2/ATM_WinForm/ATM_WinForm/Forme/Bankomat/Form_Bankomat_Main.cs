using ATM_WinForm.Forme.Filijala;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATM_WinForm.Forme.Bankomat
{
    public partial class Form_Bankomat_Main : Form
    {
        private readonly int filijalaId = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.DTOs.BankomatBasic> bankomati = null;
        public Form_Bankomat_Main(int filijalaId = -1)
        {
            InitializeComponent();
            this.filijalaId = filijalaId;

            BankomatGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form_Bankomat_Main_Load(object sender, EventArgs e)
        {
            if (this.filijalaId == -1)
            {
                bankomati = DTOManager.VratiSveBankomate();
            }
            else
            {
                bankomati = DTOManager.VratiSveBankomateOdFilijale(this.filijalaId);
            }

            bindingSource.DataSource = bankomati;
            BankomatGrid.DataSource = bindingSource;

            BankomatGrid.AllowUserToAddRows = false;
        }

        private void DodajBankomatBtn_Click(object sender, EventArgs e)
        {
            var dodajIzmeniBankomatForm = new Form_Bankomat_AddUpdate("add", null, this.filijalaId);
            dodajIzmeniBankomatForm.ShowDialog();
        }
    }
}
