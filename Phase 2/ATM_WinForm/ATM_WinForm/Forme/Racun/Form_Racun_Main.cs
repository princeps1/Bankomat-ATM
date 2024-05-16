using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM_WinForm.Forme.Racun;
using NHibernate;

namespace ATM_WinForm.Forme.Racun
{
    public partial class Form_Racun_Main : Form
    {
        private readonly int bankaId = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.Entiteti.Racun> racuni = null;
        public Form_Racun_Main(int bankaId = -1)
        {
            InitializeComponent();
            this.bankaId = bankaId;
        }

        private void Form_Racun_Main_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            if (this.bankaId == -1)
            {
                racuni = s.Query<ATM_WinForm.Entiteti.Racun>().ToList();
            }
            else
            {
                var banka = s.Get<ATM_WinForm.Entiteti.Banka>(this.bankaId);
                racuni = banka.Racuni.ToList();
            }

            bindingSource.DataSource = racuni;
            RacunGrid.DataSource = bindingSource;

            RacunGrid.AllowUserToAddRows = false;

            s.Close();
        }

        private void RacunGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (RacunGrid.SelectedRows.Count > 0)
            {
                IzbrisiRacunBtn.Enabled = true;
                IzmeniRacunBtn.Enabled = true;
            }
            else
            {
                IzbrisiRacunBtn.Enabled = false;
                IzmeniRacunBtn.Enabled = false;
            }
        }
    }
}
