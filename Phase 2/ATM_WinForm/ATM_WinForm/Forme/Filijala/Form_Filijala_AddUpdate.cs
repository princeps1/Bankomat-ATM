using ATM_WinForm.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_WinForm.Forme.Filijala
{
    public partial class Form_Filijala_AddUpdate : Form
    {
        private string type = "";
        private ATM_WinForm.Entiteti.Filijala filijala = null;
        static public event EventHandler<BankaEventArgs> FilijalaEventi;
        public Form_Filijala_AddUpdate(string type, ATM_WinForm.Entiteti.Filijala filijala)
        {
            InitializeComponent();

            this.type = type;
            this.filijala = filijala;

            switch (this.type)
            {
                case "add":
                    {
                        AkcijaFilijaleBtn.Text = "Dodaj Filijalu";

                        this.Text = "ATM - Dodaj Filijalu";

                        break;
                    }
                case "update":
                    {
                        AkcijaFilijaleBtn.Text = "Izmeni Filijalu";

                        AdresaTxtBx.Text = filijala.Adresa;
                        BrTelefonaTxtBx.Text = filijala.Br_telefona;
                        RadnoVremeTxtBx.Text = filijala.Radno_vreme;

                        this.Text = "ATM - Izmeni Filijalu";

                        break;
                    }
                default: break;
            }

        }

        private void Form_Filijala_AddUpdate_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            BankaComboBox.DataSource = s.Query<ATM_WinForm.Entiteti.Banka>().ToList();
           
            
            s.Close();
        }
    }
}
