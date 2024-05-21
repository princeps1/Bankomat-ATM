using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATM_WinForm.Forme.Klijent
{
    public partial class Form_Klijent_Main : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.DTOs.KlijentBasic> klijent = null;
        List<ATM_WinForm.DTOs.PravnoLiceBasic> pravnoLice = null;
        List<ATM_WinForm.DTOs.FizickoLiceBasic> fizickoLice = null;
        public Form_Klijent_Main()
        {
            InitializeComponent();

            this.KlijentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.KlijentComboBox.SelectedIndex = 0;

            KlijentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            KlijentGrid.ClearSelection();
        }

        private void Form_Klijent_Main_Load(object sender, EventArgs e)
        {
            klijent = DTOManager.VratiSveKlijente();

            bindingSource.DataSource = klijent;
            KlijentGrid.DataSource = bindingSource;

            KlijentGrid.AllowUserToAddRows = false;
        }

        private void PopuniPodacima()
        {
            klijent.Clear();
            klijent = DTOManager.VratiSveKlijente();
            bindingSource.DataSource = klijent;
            KlijentGrid.DataSource = bindingSource;
        }

        //pravna lica - 1
        private void KlijentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if(this.KlijentComboBox.SelectedIndex.ToString() == "1")
            {

                    pravnoLice = DTOManager.VratiSvaPravnaLica();

                    bindingSource.DataSource = pravnoLice;
                    KlijentGrid.DataSource = bindingSource;

                    KlijentGrid.AllowUserToAddRows = false;
            }
            else if(this.KlijentComboBox.SelectedIndex.ToString() == "2")
            {
                fizickoLice = DTOManager.VratiSvaFizickaLica();

                bindingSource.DataSource = fizickoLice;
                KlijentGrid.DataSource = bindingSource;

                KlijentGrid.AllowUserToAddRows = false;
            }
            else
            {
                klijent = DTOManager.VratiSveKlijente();

                bindingSource.DataSource = klijent;
                KlijentGrid.DataSource = bindingSource;

                KlijentGrid.AllowUserToAddRows = false;
            }
        }

        private void PrikaziKomentareBtn_Click(object sender, EventArgs e)
        {
            if (KlijentGrid.SelectedCells.Count > 0)
            {
                int rowIndex = KlijentGrid.SelectedCells[0].RowIndex;
                if (rowIndex != -1)
                {
                    var klijent = KlijentGrid.SelectedRows[0].DataBoundItem as ATM_WinForm.DTOs.KlijentBasic;
                    var ListaKomentaraForm = new Form_Klijent_Komentari_Main(klijent.Id);
                    ListaKomentaraForm.ShowDialog();
                    bindingSource.ResetBindings(false);
                }
            }
        }

        private void DodajKlijentaBtn_Click(object sender, EventArgs e)
        {

        }

        private void IzmeniKlijentaBtn_Click(object sender, EventArgs e)
        {

        }

        private void IzbrisiKlijentaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
