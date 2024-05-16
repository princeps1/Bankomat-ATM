using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM_WinForm.Forme.Banka;
using ATM_WinForm.Forme.Racun;
using NHibernate;

namespace ATM_WinForm
{
    public partial class Form_Banka_Main : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.Entiteti.Banka> banke = null;

        public Form_Banka_Main()
        {
            InitializeComponent();
            Form_Banka_AddUpdate.BankaEventi += this.BankaDodanaIliIzmenjana;
        }

        private void Form_Banka_Main_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            banke = s.Query<ATM_WinForm.Entiteti.Banka>().ToList();

            bindingSource.DataSource = banke;
            BankaGrid.DataSource = bindingSource;

            BankaGrid.AllowUserToAddRows = false;

            s.Close();
        }

        private void DodajBankuBtn_Click(object sender, EventArgs e)
        {
            var dodajIzmeniBankuForm = new Form_Banka_AddUpdate("add", null);
            dodajIzmeniBankuForm.ShowDialog();
        }

        private void BankaGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(BankaGrid.SelectedRows.Count > 0)
            {
                IzbrisiBankuBtn.Enabled = true;
                IzmeniBankuBtn.Enabled = true;
                BtnPregledFilijala.Enabled = true;
                SpisakBrojevaTelefonaBtn.Enabled = true;
                SpisakSvihRacunaBtn.Enabled = true;
            } else
            {
                IzbrisiBankuBtn.Enabled = false;
                IzmeniBankuBtn.Enabled = false;
                BtnPregledFilijala.Enabled= false;
                SpisakBrojevaTelefonaBtn.Enabled= false;
                SpisakSvihRacunaBtn.Enabled = false;
            }
        }

        private void IzbrisiBankuBtn_Click(object sender, EventArgs e)
        {

            if (BankaGrid.SelectedCells.Count > 0)
            {
                int rowIndex = BankaGrid.SelectedCells[0].RowIndex;
                if (rowIndex != -1)
                {
                    ISession s = DataLayer.GetSession();

                    var banka = BankaGrid.SelectedRows[0].DataBoundItem as ATM_WinForm.Entiteti.Banka;

                    s.Delete(banka);
                    s.Flush();
                    s.Close();

                    BankaGrid.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void BankaDodanaIliIzmenjana(object sender, BankaEventArgs e)
        {
            switch (e.TipAkcije)
            {
                case "add":
                    {
                        banke.Add(e.NovaBanka);

                        break;
                    }
                case "update": break;
                default: break;
            }

            bindingSource.ResetBindings(false);
        }

        private void IzmeniBankuBtn_Click(object sender, EventArgs e)
        {
            if (BankaGrid.SelectedCells.Count > 0)
            {
                int rowIndex = BankaGrid.SelectedCells[0].RowIndex;
                if (rowIndex != -1)
                {
                    var banka = BankaGrid.SelectedRows[0].DataBoundItem as ATM_WinForm.Entiteti.Banka;
                    var dodajIzmeniBankuForm = new Form_Banka_AddUpdate("update", banka);
                    dodajIzmeniBankuForm.ShowDialog();
                }
            }
        }

        private void BtnPregledFilijala_Click(object sender, EventArgs e)
        {
            if (BankaGrid.SelectedCells.Count > 0)
            {
                int rowIndex = BankaGrid.SelectedCells[0].RowIndex;
                if (rowIndex != -1)
                {
                    var banka = BankaGrid.SelectedRows[0].DataBoundItem as ATM_WinForm.Entiteti.Banka;
                    var FilijalaForm = new Form_Filijala_Main(banka.Id);
                    FilijalaForm.ShowDialog();
                }
            }
        }

        private void SpisakBrojevaTelefonaBtn_Click(object sender, EventArgs e)
        {
            if (BankaGrid.SelectedCells.Count > 0)
            {
                int rowIndex = BankaGrid.SelectedCells[0].RowIndex;
                if (rowIndex != -1)
                {
                    var banka = BankaGrid.SelectedRows[0].DataBoundItem as ATM_WinForm.Entiteti.Banka;
                    var SpisakBrojevaTelefonaForm = new Form_Banka_SpisakBrojeva_Main(banka.Id);
                    SpisakBrojevaTelefonaForm.ShowDialog();
                }
            }
        }

        private void SpisakSvihRacunaBtn_Click(object sender, EventArgs e)
        {
            if (BankaGrid.SelectedCells.Count > 0)
            {
                int rowIndex = BankaGrid.SelectedCells[0].RowIndex;
                if (rowIndex != -1)
                {
                    var banka = BankaGrid.SelectedRows[0].DataBoundItem as ATM_WinForm.Entiteti.Banka;
                    var SpisakSvihRacunaForm  = new Form_Racun_Main(banka.Id);
                    SpisakSvihRacunaForm.ShowDialog();
                }
            }
        }
    }
}
