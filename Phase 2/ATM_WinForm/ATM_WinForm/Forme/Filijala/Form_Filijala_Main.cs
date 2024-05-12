using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM_WinForm.Forme.Filijala;
using NHibernate;

namespace ATM_WinForm
{
    public partial class Form_Filijala_Main : Form
    {
        private readonly int bankaId = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.Entiteti.Filijala> filijale = null;
        public Form_Filijala_Main(int bankaId = -1)
        {
            InitializeComponent();
            this.bankaId = bankaId;

            Form_Filijala_AddUpdate.FilijalaEventi += this.FilijalaDodanaIliIzmenjana;
        }

        private void Form_Filijala_Main_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            if(this.bankaId == -1)
            {
                filijale = s.Query<ATM_WinForm.Entiteti.Filijala>().ToList();
            }
            else
            {
                var banka = s.Get<ATM_WinForm.Entiteti.Banka>(this.bankaId);
                filijale = banka.Filijala.ToList();
            }

            bindingSource.DataSource = filijale;
            FilijalaGrid.DataSource = bindingSource;

            FilijalaGrid.AllowUserToAddRows = false;

            s.Close();
        }

        private void DodajFilijaluBtn_Click(object sender, EventArgs e)
        {
            var dodajIzmeniFilijaluForm = new Form_Filijala_AddUpdate("add", null, this.bankaId);
            dodajIzmeniFilijaluForm.ShowDialog();
        }

        private void FilijalaDodanaIliIzmenjana(object sender, FilijalaEventArgs e)
        {
            switch (e.TipAkcije)
            {
                case "add":
                    {
                        filijale.Add(e.NovaFilijala);

                        break;
                    }
                case "update": break;
                default: break;
            }

            bindingSource.ResetBindings(false);
        }
    }
}
