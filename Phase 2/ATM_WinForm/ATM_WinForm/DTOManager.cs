using ATM_WinForm.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static ATM_WinForm.DTOs;

namespace ATM_WinForm
{
    internal class DTOManager
    {
        #region Banke
        public static List<BankaBasic> VratiSveBanke()
        {
            List<BankaBasic> bankaList = new List<BankaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Banka> banke = s.Query<Banka>();

                foreach (Banka b in banke)
                {
                    bankaList.Add(new BankaBasic(b.Id, b.Ime, b.Email, b.Web_adresa, b.Adresa_centrale));
                }

                s.Close();

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            return bankaList;
        }

        public static BankaBasic VratiBanku(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var b = s.Load<Banka>(id);
                BankaBasic banka = new BankaBasic(b.Id, b.Ime, b.Email, b.Web_adresa, b.Adresa_centrale);

                s.Close();

                return banka;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static bool ProveraEmailBanke(string email)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                int count = s.Query<ATM_WinForm.Entiteti.Banka>().Where(banka => banka.Email == email).ToList().Count;

                s.Close();

                return count > 0;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);  

                return false;
            }
        }

        public static bool ProveraWebAdreseBanke(string webadresa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                int count = s.Query<ATM_WinForm.Entiteti.Banka>().Where(banka => banka.Web_adresa == webadresa).ToList().Count;

                s.Close();

                return count > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }

        public static void DodajBanku(BankaBasic banka)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka b = new Banka
                {
                    Ime = banka.Ime,
                    Email = banka.Email,
                    Web_adresa = banka.Web_adresa,
                    Adresa_centrale = banka.Adresa_centrale
                };

                s.SaveOrUpdate(b);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzmeniBanku(BankaBasic banka)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka b = s.Load<Banka>(banka.Id);

                b.Ime = banka.Ime;
                b.Email = banka.Email;
                b.Web_adresa = banka.Web_adresa;
                b.Adresa_centrale = banka.Adresa_centrale;

                s.Update(b);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzbrisiBanku(int bankaId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka b = s.Load<Banka>(bankaId);

                
                s.Delete(b);

                s.Flush();
                s.Close();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region BrojeviTelefona Banke
        public static List<BankaBrTelefonaBasic> VratiSveBrojeveTelefonaOdBanke(int bankaId)
        {
            Console.WriteLine(bankaId);
            List<BankaBrTelefonaBasic> brTelefonaList = new List<BankaBrTelefonaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<BankaBrTelefona> telefoni = from t in s.Query<BankaBrTelefona>()
                                                        where t.PripadaBanci.Id == bankaId
                                                        select t;


                foreach (BankaBrTelefona b in telefoni)
                {
                    BankaBasic banka = VratiBanku(b.PripadaBanci.Id);
                    brTelefonaList.Add(new BankaBrTelefonaBasic(b.Id, b.BrTelefona, banka));
                }

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return brTelefonaList;
        }

        public static void DodajBrTelefona(BankaBrTelefonaBasic brTelefona)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var banka = s.Load<Banka>(brTelefona.PripadaBanci.Id);

                BankaBrTelefona b = new BankaBrTelefona
                {
                    BrTelefona = brTelefona.BrTelefona,
                    PripadaBanci = banka
                };

                s.SaveOrUpdate(b);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzmeniBrTelefona(BankaBrTelefonaBasic brTelefona)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka banka = s.Load<Banka>(brTelefona.PripadaBanci.Id);
                BankaBrTelefona t = s.Load<BankaBrTelefona>(brTelefona.Id);

                t.BrTelefona = brTelefona.BrTelefona;
                t.PripadaBanci = banka;

                s.Update(t);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzbrisiBrojTelefonaBanke(int brojTelefonaId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BankaBrTelefona telefon = s.Load<BankaBrTelefona>(brojTelefonaId);

                s.Delete(telefon);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        #endregion

        #region Filijale

        public static List<FilijalaBasic> VratiSveFilijale()
        {
            List<FilijalaBasic> filijalaList = new List<FilijalaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Filijala> filijale = s.Query<Filijala>();

                foreach (Filijala f in filijale)
                {
                    BankaBasic banka = VratiBanku(f.PripadaBanci.Id);
                    filijalaList.Add(new FilijalaBasic(f.Rbr_filijale, f.Adresa, f.Br_telefona, f.Radno_vreme, banka));
                }

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return filijalaList;
        }

        public static List<FilijalaBasic> VratiSveFilijaleOdBanke(int bankaId)
        {
            List<FilijalaBasic> filijalaList = new List<FilijalaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Filijala> filijale = from o in s.Query<Filijala>()
                                                 where o.PripadaBanci.Id == bankaId
                                                 select o;

                foreach (Filijala f in filijale)
                {
                    BankaBasic banka = VratiBanku(f.PripadaBanci.Id);
                    filijalaList.Add(new FilijalaBasic(f.Rbr_filijale, f.Adresa, f.Br_telefona, f.Radno_vreme, banka));
                }

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return filijalaList;
        }

        public static FilijalaBasic VratiFilijalu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var f = s.Load<Filijala>(id);
                var b = VratiBanku(f.PripadaBanci.Id);
                FilijalaBasic filijala = new FilijalaBasic(f.Rbr_filijale, f.Adresa, f.Br_telefona, f.Radno_vreme, b);

                s.Close();

                return filijala;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void DodajFilijalu(FilijalaBasic filijala)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var banka = s.Load<Banka>(filijala.PripadaBanci.Id);

                Filijala f = new Filijala
                {
                    Adresa = filijala.Adresa,
                    Br_telefona = filijala.Br_telefona,
                    Radno_vreme = filijala.Radno_vreme,
                    PripadaBanci = banka
                };

                s.SaveOrUpdate(f);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzmeniFilijalu(FilijalaBasic filijala)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka banka = s.Load<Banka>(filijala.PripadaBanci.Id);
                Filijala f = s.Load<Filijala>(filijala.Rbr_filijale);

                f.Adresa = filijala.Adresa;
                f.Br_telefona = filijala.Br_telefona;
                f.Radno_vreme = filijala.Radno_vreme;
                f.PripadaBanci = banka;

                s.Update(f);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzbrisiFilijalu(int filijalaId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Filijala filijala = s.Load<Filijala>(filijalaId);

                s.Delete(filijala);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Bankomati

        public static List<BankomatBasic> VratiSveBankomate()
        {
            List<BankomatBasic> bankomatList = new List<BankomatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bankomat> bankomati = s.Query<Bankomat>();

                foreach (Bankomat b in bankomati)
                {
                    FilijalaBasic filijala = VratiFilijalu(b.InstaliranUFilijali.Rbr_filijale);
                    bankomatList.Add(new BankomatBasic(b.Id, b.Lokacija, b.Proizvodjac, b.Status, b.Datum_Poslednjeg_Servisa, filijala));
                }

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return bankomatList;
        }

        public static BankomatBasic VratiBankomat(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var b = s.Load<Bankomat>(id);

                FilijalaBasic filijala = VratiFilijalu(b.InstaliranUFilijali.Rbr_filijale);
                var bankomat = new BankomatBasic(b.Id, b.Lokacija, b.Proizvodjac, b.Status, b.Datum_Poslednjeg_Servisa, filijala);

                s.Close();

                return bankomat;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<BankomatBasic> VratiSveBankomateOdFilijale(int filijalaId)
        {
            List<BankomatBasic> bankomatList = new List<BankomatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                Filijala filijala = s.Load<Filijala>(filijalaId);

                foreach (Bankomat b in filijala.Bankomati)
                {
                    FilijalaBasic f = VratiFilijalu(filijalaId);
                    bankomatList.Add(new BankomatBasic(b.Id, b.Lokacija, b.Proizvodjac, b.Status, b.Datum_Poslednjeg_Servisa, f));
                }

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return bankomatList;
        }

        public static void DodajBankomat(BankomatBasic bankomat)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var filijala = s.Load<Filijala>(bankomat.InstaliranUFilijali.Rbr_filijale);

                Bankomat b = new Bankomat
                {
                    Lokacija = bankomat.Lokacija,
                    Proizvodjac = bankomat.Proizvodjac,
                    Status = bankomat.Status,
                    Datum_Poslednjeg_Servisa = bankomat.Datum_Poslednjeg_Servisa,
                    InstaliranUFilijali = filijala
                };

                s.SaveOrUpdate(b);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzmeniBankomat(BankomatBasic bankomat)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Učitavanje postojeće filijale
                var filijala = s.Load<Filijala>(bankomat.InstaliranUFilijali.Rbr_filijale);

                // Učitavanje postojećeg Bankomat objekta iz baze
                var existingBankomat = s.Load<Bankomat>(bankomat.Id);

                if (existingBankomat != null)
                {
                    // Ažuriranje postojećeg Bankomat objekta
                    existingBankomat.Lokacija = bankomat.Lokacija;
                    existingBankomat.Proizvodjac = bankomat.Proizvodjac;
                    existingBankomat.Status = bankomat.Status;
                    existingBankomat.Datum_Poslednjeg_Servisa = bankomat.Datum_Poslednjeg_Servisa;
                    existingBankomat.InstaliranUFilijali = filijala;

                    // Sačuvajte promene
                    s.Update(existingBankomat);
                }

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static void IzbrisiBankomat(int bankomatId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bankomat bankomat = s.Load<Bankomat>(bankomatId);

                s.Delete(bankomat);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Racuni 
        public static List<RacunBasic> VratiSveRacune()
        {
            List<RacunBasic> racunList = new List<RacunBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Racun> racuni = s.Query<Racun>();

                foreach (Racun r in racuni)
                {
                    BankaBasic banka = VratiBanku(r.JePovezan.Id);
                    KlijentBasic klijent = VratiKlijenta(r.Koristi.Id);
                    racunList.Add(new RacunBasic(r.Br_racuna, r.Datum_otvaranja, r.Tekuci_saldo, r.Tip, r.Valuta, banka, klijent));
                }

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return racunList;
        }

        public static List<RacunBasic> VratiSveRacuneOdBanke(int bankaId)
        {
            List<RacunBasic> racunList = new List<RacunBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Racun> racuni = from r in s.Query<Racun>()
                                            where r.JePovezan.Id == bankaId
                                            select r;

                foreach (Racun r in racuni)
                {
                    BankaBasic banka = VratiBanku(r.JePovezan.Id);
                    KlijentBasic klijent = VratiKlijenta(r.Koristi.Id);
                    racunList.Add(new RacunBasic(r.Br_racuna, r.Datum_otvaranja, r.Tekuci_saldo, r.Tip, r.Valuta, banka, klijent));
                }

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return racunList;
        }

        public static RacunBasic VratiRacun(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var r = s.Load<Racun>(id);
                BankaBasic banka = VratiBanku(r.JePovezan.Id);
                KlijentBasic klijent = VratiKlijenta(r.Koristi.Id);
                RacunBasic racun = new RacunBasic(r.Br_racuna, r.Datum_otvaranja, r.Tekuci_saldo, r.Tip, r.Valuta, banka, klijent);

                s.Close();

                return racun;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion

        #region Klijent
        public static KlijentBasic VratiKlijenta(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var k = s.Load<Klijent>(id);
                KlijentBasic klijent = new KlijentBasic(k.Id, k.Br_tel, k.Email, k.Adresa);

                s.Close();

                return klijent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<KlijentBasic> VratiSveKlijente()
        {
            List<KlijentBasic> klijentList = new List<KlijentBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Klijent> klijenti = s.Query<Klijent>();

                foreach (Klijent k in klijenti)
                {
                    klijentList.Add(new KlijentBasic(
                        k.Id,
                        k.Br_tel,
                        k.Email,
                        k.Adresa,
                        k.Naziv
                    ));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return klijentList;
        }

        public static List<FizickoLiceBasic> VratiSvaFizickaLica()
        {
            List<FizickoLiceBasic> fizickaLicaList = new List<FizickoLiceBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<FizickoLice> fizickaLica = s.Query<FizickoLice>();

                foreach (FizickoLice k in fizickaLica)
                {
                    fizickaLicaList.Add(new FizickoLiceBasic(
                        k.JMBG,
                        k.Datum_rodjenja,
                        k.LIme,
                        k.Ime_roditelja,
                        k.Prezime,
                        k.Br_licne_karte,
                        k.Mesto_izdavanja,
                        k.Id,
                        k.Naziv,
                        k.Br_tel,
                        k.Email,
                        k.Adresa
                    ));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return fizickaLicaList;
        }

        public static List<PravnoLiceBasic> VratiSvaPravnaLica()
        {
            List<PravnoLiceBasic> pravnaLicaList = new List<PravnoLiceBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PravnoLice> pravnaLica = s.Query<PravnoLice>();

                foreach (PravnoLice p in pravnaLica)
                {
                    pravnaLicaList.Add(new PravnoLiceBasic(
                        p.Poreski_id,
                        p.Id,
                        p.Naziv,
                        p.Br_tel,
                        p.Email,
                        p.Adresa
                    ));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return pravnaLicaList;
        }



        #endregion

        #region Kartica 
        public static List<KarticaBasic> VratiSveKarticeOdRacuna(int racunId)
        {
            List<KarticaBasic> karticaList = new List<KarticaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Kartica> kartice = from k in s.Query<Kartica>()
                                            where k.Odgovara.Br_racuna == racunId
                                            select k;

                foreach (Kartica k in kartice)
                {

                    RacunBasic racun = VratiRacun(k.Odgovara.Br_racuna);
                    karticaList.Add(new KarticaBasic(k.Id, k.Datum_izdavanje, k.Datum_isteka, k.Dnevni_limit, k.Tip, k.Max_iznos_zaduzenja, k.Max_datum_vracanja_duga, racun));
                }

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return karticaList;
        }

        public static void DodajKarticu(KarticaBasic kartica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var racun = s.Load<Racun>(kartica.Odgovara.Br_racuna);

                if(kartica.Tip == "kreditna")
                {
                    KreditnaKartica k = new KreditnaKartica
                    {
                        Datum_izdavanje = kartica.Datum_izdavanje,
                        Datum_isteka = kartica.Datum_isteka,
                        Tip = kartica.Tip,
                        Dnevni_limit = kartica.Dnevni_limit,
                        Max_iznos_zaduzenja = kartica.Max_iznos_zaduzenja,
                        Max_datum_vracanja_duga = kartica.Max_datum_vracanja_duga,
                        Odgovara = racun

                    };

                    s.SaveOrUpdate(k);
                }
                else if(kartica.Tip == "debitna"){
                    DebitnaKartica k = new DebitnaKartica
                    {
                        Datum_izdavanje = kartica.Datum_izdavanje,
                        Datum_isteka = kartica.Datum_isteka,
                        Tip = kartica.Tip,
                        Dnevni_limit = kartica.Dnevni_limit,
                        Odgovara = racun
                    };

                    s.SaveOrUpdate(k);
                }

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzmeniKarticu(KarticaBasic kartica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Učitavanje postojećeg Računa
                var racun = s.Load<Racun>(kartica.Odgovara.Br_racuna);

                // Učitavanje postojeće Kartice objekta iz baze
                var existingKartica= s.Load<Kartica>(kartica.Id);

                if (existingKartica != null)
                {
                    // Ažuriranje postojeće Kartice objekta
                    existingKartica.Datum_izdavanje = kartica.Datum_izdavanje;
                    existingKartica.Datum_isteka = kartica.Datum_isteka;
                    existingKartica.Tip = kartica.Tip;
                    existingKartica.Dnevni_limit = kartica.Dnevni_limit;

                    if (existingKartica.Tip != "kreditna")
                    {
                        existingKartica.Max_iznos_zaduzenja = kartica.Max_iznos_zaduzenja;
                        existingKartica.Max_datum_vracanja_duga = kartica.Max_datum_vracanja_duga;
                    }
                    existingKartica.Odgovara = racun;
                    // Sačuvajte promene
                    s.Update(existingKartica);
                }

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IzbrisiKarticu(int karticaId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kartica kartica = s.Load<Kartica>(karticaId);

                s.Delete(kartica);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
