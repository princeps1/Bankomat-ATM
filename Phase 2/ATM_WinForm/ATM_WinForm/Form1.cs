using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ATM_WinForm.Entiteti;

namespace ATM_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdReadBank_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o banci za zadatim brojem
                ATM_WinForm.Entiteti.Banka b = s.Load<ATM_WinForm.Entiteti.Banka>(1);

                MessageBox.Show(b.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreateBank_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Banka p = new Entiteti.Banka();

                //p = s.Load<Entiteti.Prodavnica>(81);

                p.Ime = "Postanska stedionica";
                p.Email = "info@postanskabank.rs";
                p.Web_adresa = "https://www.posted.co.rs/";
                p.Adresa_centrale = "Bulevar dr Zorana Đinđića 15v";


                //s.Save(p);
                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdReadBankName_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Filijala o = s.Load<Filijala>(12);

                MessageBox.Show(o.PripadaBanci.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdReadFilijaleList_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                ATM_WinForm.Entiteti.Banka b = s.Load<ATM_WinForm.Entiteti.Banka>(1);

                foreach (Filijala f in b.Filijala)
                {
                    MessageBox.Show(f.Adresa + " " + f.Br_telefona);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
