using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM_WinForm.Entiteti;
using ATM_WinForm.Forme.Racun;
using NHibernate;

namespace ATM_WinForm.Forme.Racun
{
    public partial class Form_Racun_Main : Form
    {
        private readonly int bankaId = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.DTOs.RacunBasic> racuni = null;
        public Form_Racun_Main(int bankaId = -1)
        {
            InitializeComponent();
            this.bankaId = bankaId;

            RacunGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Form_Racun_Main_Load(object sender, EventArgs e)
        {
            if (this.bankaId == -1)
            {
                racuni = DTOManager.VratiSveRacune();
            }
            else
            {
                racuni = DTOManager.VratiSveRacuneOdBanke(this.bankaId);
            }

            bindingSource.DataSource = racuni;
            RacunGrid.DataSource = bindingSource;

            RacunGrid.AllowUserToAddRows = false;
        }

        private void RacunGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (RacunGrid.SelectedRows.Count > 0)
            {
                IzbrisiRacunBtn.Enabled = true;
                IzmeniRacunBtn.Enabled = true;
                PrikaziKorisnikaBtn.Enabled = true;
            }
            else
            {
                IzbrisiRacunBtn.Enabled = false;
                IzmeniRacunBtn.Enabled = false;
                PrikaziKorisnikaBtn.Enabled = false;
            }
        }
             
           
        private void PrikaziKorisnikaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Dobijanje selektovanog reda
                DataGridViewRow selectedRow = RacunGrid.SelectedRows[0];

                // Dobijanje objekta Racun iz selektovanog reda
                DTOs.RacunBasic racun = (DTOs.RacunBasic)selectedRow.DataBoundItem;


                Klijent klijent = s.Get<Klijent>(racun.Koristi.Id);


                MessageBox.Show($"Naziv klijenta:  {klijent.Naziv}\nBroj telefona: {klijent.Br_tel}\nEmail:{klijent.Email}");
                
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


    }
}
