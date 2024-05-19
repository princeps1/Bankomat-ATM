using ATM_WinForm.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ATM_WinForm
{
    public class DTOs
    {
        public class BankaBasic
        {
            [DisplayName("ID")]
            public int Id { get; protected set; }

            [DisplayName("Ime")]
            public string Ime { get; set; }

            [DisplayName("Email")]
            public string Email { get; set; }

            [DisplayName("Web Adresa")]
            public string Web_adresa { get; set; }

            [DisplayName("Adresa Centrale")]
            public string Adresa_centrale { get; set; }

            [Browsable(false)]
            public virtual IList<FilijalaBasic> Filijala { get; set; }

            [Browsable(false)]
            public virtual IList<RacunBasic> Racuni { get; set; }

            [Browsable(false)]
            public virtual IList<BankaBrTelefonaBasic> BrojeviTelefona { get; set; }

            public BankaBasic(int id, string ime, string email, string webAdresa, string adresaCentrale)
            {
                this.Id = id;
                this.Ime = ime;
                this.Email = email;
                this.Web_adresa = webAdresa;
                this.Adresa_centrale = adresaCentrale;
            }
            public BankaBasic()
            {
                Filijala = new List<FilijalaBasic>();
                Racuni = new List<RacunBasic>();
                BrojeviTelefona = new List<BankaBrTelefonaBasic>();
            }
        }

        public class FilijalaBasic
        {
            [DisplayName("Redni broj")]
            public virtual int Rbr_filijale { get; protected set; }

            [DisplayName("Adresa")]
            public virtual string Adresa { get; set; }

            [DisplayName("Broj telefona")]
            public virtual string Br_telefona { get; set; }

            [DisplayName("Radno vreme")]
            public virtual string Radno_vreme { get; set; }

            [DisplayName("Ime banke")]
            public virtual string Ime_banke { get; set; }

            //MAPIRANJE FILIJALA-BANKA
            [Browsable(false)]
            public virtual BankaBasic PripadaBanci { get; set; }

            //MAPIRANJE FILIJAL-BANKOMAT
            [Browsable(false)]
            public virtual IList<BankomatBasic> Bankomati { get; set; }

            public FilijalaBasic(int id, string adresa, string brTelefona, string radnoVreme, BankaBasic banka)
            {
                this.Rbr_filijale = id;
                this.Adresa = adresa;
                this.Br_telefona = brTelefona;
                this.Radno_vreme = radnoVreme;
                this.PripadaBanci = banka;
                this.Ime_banke = banka.Ime;
            }
            public FilijalaBasic()
            {
                Bankomati = new List<BankomatBasic>();
            }
        }

        public class BankomatBasic
        {
            [DisplayName("ID")]
            public virtual int Id { get; protected set; }

            [DisplayName("Lokacija")]
            public string Lokacija { get; set; }

            [DisplayName("Proizvodjac")]
            public virtual string Proizvodjac { get; set; }

            [DisplayName("Status")]
            public virtual string Status { get; set; }

            [DisplayName("Datum poslednjeg servisa")]
            public virtual string Datum_Poslednjeg_Servisa { get; set; }

            [Browsable(false)]
            public virtual FilijalaBasic InstaliranUFilijali { get; set; }

            public BankomatBasic(int id, string lokacija, string proizvodjac, string status, string datum, FilijalaBasic filijala)
            {
                this.Id = id;
                this.Lokacija = lokacija;
                this.Proizvodjac = proizvodjac;
                this.Status = status;
                this.Datum_Poslednjeg_Servisa = datum;
                this.InstaliranUFilijali = filijala;
            }

            public BankomatBasic() { }
        }

        public class RacunBasic
        {
            [DisplayName("Broj racuna")]
            public virtual int Br_racuna { get; protected set; }

            [DisplayName("Datum otvaranja")]
            public virtual DateTime Datum_otvaranja { get; set; }

            [DisplayName("Tekuci saldo")]
            public virtual string Tekuci_saldo { get; set; }


            [Browsable(false)]
            public virtual string Tip { get; set; }

            [DisplayName("Valuta")]
            public virtual string Valuta { get; set; }


            //MAPIRANJE RACUN-BANKA
            [Browsable(false)]
            public virtual BankaBasic JePovezan { get; set; }

            //MAPIRANJE RACUN-KLIJENT
            [Browsable(false)]
            public virtual KlijentBasic Koristi { get; set; }

            public RacunBasic(int br_rac, DateTime datum, string tekuci_saldo, string tip, string valuta, BankaBasic banka, KlijentBasic klijent)
            {
                this.Br_racuna = br_rac;
                this.Datum_otvaranja = datum;
                this.Tekuci_saldo = tekuci_saldo;
                this.Tip = tip;
                this.Valuta = valuta;
                this.JePovezan = banka;
                this.Koristi = klijent;
            }
        }

        public class KlijentBasic
        {
            [DisplayName("ID")]
            public virtual int Id { get; protected set; }

            [DisplayName("Naziv")]
            public virtual string Naziv { get; set; }

            [DisplayName("Broj telefona")]
            public virtual string Br_tel { get; set; }

            [DisplayName("Email")]
            public virtual string Email { get; set; }

            [DisplayName("Adresa")]
            public virtual string Adresa { get; set; }

            //MAIRANJE KLIJENT-RACUN
            [Browsable(false)]
            public virtual IList<RacunBasic> Racuni { get; set; }

            public KlijentBasic(int id, string telefon, string email, string adresa,string naziv="")
            {
               
                this.Id = id;
                this.Br_tel = telefon;
                this.Email = email;
                this.Adresa = adresa;
                this.Naziv = naziv;
            }

            public KlijentBasic()
            {
                //MAIRANJE KLIJENT-RACUN
                Racuni = new List<RacunBasic>();
            }
        }

        public class PravnoLiceBasic : KlijentBasic
        {
            [DisplayName("Poreski ID")]
            public virtual string Poreski_id { get; set; }

            public PravnoLiceBasic(string poreski_id, int id, string naziv, string telefon, string email, string adresa)
                : base(id, telefon, email, adresa)
            {
                Poreski_id = poreski_id;
                this.Naziv = naziv;
            }
        }

        public class FizickoLiceBasic : KlijentBasic
        {
            [DisplayName("JMBG")]
            public virtual string JMBG { get; set; }

            [DisplayName("Datum rodjenja")]
            public virtual DateTime Datum_rodjenja { get; set; }

            [DisplayName("Ime")]
            public virtual string LIme { get; set; }

            [DisplayName("Ime roditelja")]
            public virtual string Ime_roditelja { get; set; }

            [DisplayName("Prezime")]
            public virtual string Prezime { get; set; }

            [DisplayName("Broj licne karte")]
            public virtual string Br_licne_karte { get; set; }

            [DisplayName("Mesto izdavanja")]
            public virtual string Mesto_izdavanja { get; set; }

            public FizickoLiceBasic(string JMBG, DateTime datum_rodjenja, string lIme, string ime_roditelja, string prezime, string br_licne_karte, string mesto_izdavanja, int id, string naziv, string telefon, string email, string adresa)
                : base(id, telefon, email, adresa)
            {
                this.JMBG = JMBG;
                Datum_rodjenja = datum_rodjenja;
                LIme = lIme;
                Ime_roditelja = ime_roditelja;
                Prezime = prezime;
                Br_licne_karte = br_licne_karte;
                Mesto_izdavanja = mesto_izdavanja;
                this.Naziv = naziv;
            }
        }



        public class BankaBrTelefonaBasic
        {
            [Browsable(false)]
            public virtual int Id { get; protected set; }

            [DisplayName("Broj telefona")]
            public virtual string BrTelefona { get; set; }


            //MAPIRANJE BANKA_BR_TEL-BANKA
            [Browsable(false)]
            public virtual BankaBasic PripadaBanci { get; set; }
        }
    }
}