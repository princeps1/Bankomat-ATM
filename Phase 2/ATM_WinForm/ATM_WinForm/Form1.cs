﻿using System;
using System.Windows.Forms;
using NHibernate;
using ATM_WinForm.Entiteti;
using ATM_WinForm.Forme.Racun;
using ATM_WinForm.Forme.Klijent;
using ATM_WinForm.Forme.Bankomat;
using static ATM_WinForm.DTOs;

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

        private void SectionBanka_Click(object sender, EventArgs e)
        {
            var BankaMainForm = new Form_Banka_Main();
            BankaMainForm.ShowDialog();

            //KlijentBasic klijent = DTOManager.DodajKlijenta(new KlijentBasic { Adresa = "awdawda", Br_tel = "dawdwadawd", Naziv = "dawdadada", Email = "dawdwadwad@dawad.com" });

            //FizickoLiceBasic fizickoLice = new FizickoLiceBasic("214214", DateTime.Now, "Mata", "Maroko", "Martic", "21421421", "PK", klijent.Id, "naziv", "13843298543254", "dawdad@dawad.com", "dwaduwk21431284jhkjdawaw");

            //DTOManager.DodajFizickoLice(new FizickoLiceBasic
            //{
            //    Adresa = "dawdad",
            //    Br_licne_karte = "dawdwad",
            //    Datum_rodjenja = DateTime.Now,
            //    Br_tel = "7284214",
            //    Ime_roditelja = "Dawkjdjadad",
            //    Email = "DWAD@ddawd.com",
            //    LIme = "dawwdad",
            //    Mesto_izdavanja = "dwqadwad",
            //    JMBG = "12345891234",
            //    Naziv = "dawdkad",
            //    Prezime = "dawad"
            //});

            //MessageBox.Show("Dodato @");
        }

        private void SectionFilijaleBtn_Click(object sender, EventArgs e)
        {
            var FilijalaMainForm = new Form_Filijala_Main();
            FilijalaMainForm.ShowDialog();
        }

        private void SectionRacuniBtn_Click(object sender, EventArgs e)
        {
            var RacuniMainForm = new Form_Racun_Main();
            RacuniMainForm.ShowDialog();
        }

        private void SectionKlijentiBtn_Click(object sender, EventArgs e)
        {
            var KlijentMainForm = new Form_Klijent_Main(); 
            KlijentMainForm.ShowDialog();
        }

        private void SectionBankomatiBtn_Click(object sender, EventArgs e)
        {
            var BankomatMainForm = new Form_Bankomat_Main();
            BankomatMainForm.ShowDialog();
        }
    }
}
