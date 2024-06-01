using DatabaseAccess.DTOs;
using DatabaseAccess.Entiteti;
using NHibernate;
using NHibernate.Stat;

namespace DatabaseAccess;

public static class DataProvider
{
    #region Banka
    public static List<BankaView> VratiSveBanke()
    {
        ISession? s = null;

        List<BankaView> banke = new();

        try
        {
            s = DataLayer.GetSession();


            IEnumerable<Banka> sveBanke = from o in s.Query<Banka>()
                                          select o;

            foreach (Banka b in sveBanke)
            {
                banke.Add(new BankaView(b));
            }
        }
        catch (Exception)
        {
            return null!;
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return banke;
    }

    public static BankaView VratiBanku(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            var b = s.Load<Banka>(id);
            BankaView banka = new BankaView(b);

            s.Close();

            return banka;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null!;
        }
    }
    public static void DodajBanku(BankaView banka)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Banka b = new()
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

    public static void IzmeniBanku(BankaView banka)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Banka b = s.Load<Banka>(banka.Id);

            if (b != null)
            {
                b.Ime = banka.Ime;
                b.Email = banka.Email;
                b.Web_adresa = banka.Web_adresa;
                b.Adresa_centrale = banka.Adresa_centrale;

                s.Update(b);

                s.Flush();
                s.Close();
            }
            else
            {
                Console.WriteLine("Banka sa ovim Id-jem ne postoji.\n");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void IzbrisiBanku(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Banka b = s.Load<Banka>(id);

            if (b != null)
            {
                s.Delete(b);

                s.Flush();
                s.Close();
            }
            else
            {
                Console.WriteLine("Banka sa ovim id-jem ne postoji!\n");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #endregion

    #region Filijala
    public static List<FilijalaView> VratiSveFilijale()
    {

        ISession? s = null;

        List<FilijalaView> filijale = new();

        try
        {
            s = DataLayer.GetSession();


            IEnumerable<Filijala> sveFilijale = from o in s.Query<Filijala>()
                                                select o;

            foreach (Filijala f in sveFilijale)
            {
                filijale.Add(new FilijalaView(f));
            }
        }
        catch (Exception)
        {
            return null!;
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return filijale;
    }

    public static List<FilijalaView> VratiSveFilijaleOdBanke(int bankaId)
    {
        List<FilijalaView> filijalaList = new List<FilijalaView>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Filijala> filijale = from o in s.Query<Filijala>()
                                             where o.PripadaBanci!.Id == bankaId
                                             select o;

            foreach (Filijala f in filijale)
            {
                BankaView banka = VratiBanku(f.PripadaBanci!.Id);
                filijalaList.Add(new FilijalaView(f.Rbr_filijale, f.Adresa, f.Br_telefona!, f.Radno_vreme!, banka));
            }

            s.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return filijalaList;
    }

    public static FilijalaView VratiFilijalu(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            var f = s.Load<Filijala>(id);
            var b = VratiBanku(f.PripadaBanci!.Id);
            FilijalaView filijala = new FilijalaView(f.Rbr_filijale, f.Adresa, f.Br_telefona!, f.Radno_vreme!, b);

            s.Close();

            return filijala;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null!;
        }
    }


    public async static Task DodajFilijalu(FilijalaView filijala, int idBanka)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();
            Banka b = await s.LoadAsync<Banka>(idBanka);

            Filijala f = new Filijala
            {
                Adresa = filijala.Adresa!,
                Radno_vreme = filijala.Radno_vreme,
                Br_telefona = filijala.Br_telefona,
                PripadaBanci = b
            };

            await s.SaveAsync(f);
            await s.FlushAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
    }

    //NE RADI
    public static void IzmeniFilijalu(FilijalaView filijala)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Filijala f = s.Load<Filijala>(filijala.Rbr_filijale);
            

            if (f != null)
            {
                f.Adresa = filijala.Adresa!;
                f.Radno_vreme = filijala.Radno_vreme;
                f.Br_telefona = filijala.Br_telefona;

                s.Update(f);

                s.Flush();
                s.Close();
            }
            else
            {
                Console.WriteLine("Filijala sa ovim rednim brojem ne postoji.\n");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    public static void IzbrisiFilijalu(int rbr)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Filijala f = s.Load<Filijala>(rbr);

            if (f != null)
            {
                s.Delete(f);

                s.Flush();
                s.Close();
            }
            else
            {
                Console.WriteLine("Filijala sa ovim id-jem ne postoji!\n");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #endregion

    #region Racun
    public static List<RacunView> VratiSveRacune()
    {

        ISession? s = null;

        List<RacunView> racuni = new();

        try
        {
            s = DataLayer.GetSession();


            IEnumerable<Racun> sveRacune = from o in s.Query<Racun>()
                                                select o;

            foreach (Racun r in sveRacune)
            {
                racuni.Add(new RacunView(r));
            }
        }
        catch (Exception)
        {
            return null!;
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return racuni;
    }


    public static List<RacunView> VratiSveRacuneOdBanke(int bankaId)
    {
        List<RacunView> racunList = new List<RacunView>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Racun> racuni = from o in s.Query<Racun>()
                                             where o.JePovezan.Id == bankaId
                                             select o;

            foreach (Racun r in racuni)
            {
                BankaView banka = VratiBanku(r.JePovezan.Id);
                racunList.Add(new RacunView(r));
            }

            s.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return racunList;
    }

    public static RacunView VratiRacun(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            var r = s.Load<Racun>(id);
            var b = VratiBanku(r.JePovezan!.Id);
            RacunView racun= new RacunView(r,b);

            s.Close();

            return racun;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null!;
        }
    }



    public static int IzbrisiRacun(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Racun r = s.Load<Racun>(id);

            if (r != null)
            {
                s.Delete(r);

                s.Flush();
                s.Close();
                return r.Br_racuna;
            }
            else
            {
                Console.WriteLine("Racun sa ovim id-jem ne postoji!\n");
                return r!.Br_racuna;
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }

    //NE RADI
    //public static void IzmeniRacun(RacunView racun)
    //{
    //    try
    //    {
    //        ISession s = DataLayer.GetSession();

    //        Racun r = s.Load<Racun>(racun.Br_racuna);


    //        if (r != null)
    //        {
    //            r.Datum_otvaranja = racun.Datum_otvaranja!;
    //            r.Tekuci_saldo = racun.Tekuci_saldo!;
    //            r.Tip = racun.Tip!;
    //            r.Valuta = racun.Valuta!;

    //            s.Update(r);

    //            s.Flush();
    //            s.Close();
    //        }
    //        else
    //        {
    //            Console.WriteLine("Racun sa ovim rednim brojem ne postoji.\n");
    //        }

    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e.Message);
    //    }

    //}
    #endregion

    #region Klijent
    public static List<KlijentView> VratiSveKlijente()
    {
        ISession? s = null;

        List<KlijentView> klijenti = new();

        try
        {
            s = DataLayer.GetSession();


            IEnumerable<Klijent> sviKlijenti= from o in s.Query<Klijent>()
                                          select o;

            foreach (Klijent k in sviKlijenti)
            {
                klijenti.Add(new KlijentView(k));
            }
        }
        catch (Exception)
        {
            return null!;
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return klijenti;
    }

    public static int IzbrisiKlijenta(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Klijent k = s.Load<Klijent>(id);

            if (k != null)
            {
                s.Delete(k);

                s.Flush();
                s.Close();
                return k.Id;
            }
            else
            {
                Console.WriteLine("Klijent sa ovim id-jem ne postoji!\n");
                return k.Id;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }

    #endregion

    #region Fizicka Lica
    public static List<FizickoLiceView> VratiSvaFizickaLica()
    {
        ISession? s = null;

        List<FizickoLiceView> fizickaLica = new();

        try
        {
            s = DataLayer.GetSession();


            IEnumerable<FizickoLice> svaFL= from o in s.Query<FizickoLice>()
                                          select o;

            foreach (FizickoLice fl in svaFL)
            {
                fizickaLica.Add(new FizickoLiceView(fl));
            }
        }
        catch (Exception)
        {
            return null!;
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return fizickaLica;
    }

    public static void DodajFizickoLice(FizickoLiceView fizickoLice)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            FizickoLice fl = new()
            {
                Id = fizickoLice.Id,
                Br_tel = fizickoLice.Br_tel,
                Email = fizickoLice.Email,
                Adresa = fizickoLice.Adresa,
                JMBG = fizickoLice.JMBG,
                Datum_rodjenja = fizickoLice.Datum_rodjenja,
                LIme = fizickoLice.LIme,
                Ime_roditelja = fizickoLice.Ime_roditelja,
                Prezime = fizickoLice.Prezime,
                Br_licne_karte = fizickoLice.Br_licne_karte,
                Mesto_izdavanja = fizickoLice.Mesto_izdavanja,
                Naziv = fizickoLice.LIme + fizickoLice.Prezime
            };

            s.SaveOrUpdate(fl);

            s.Flush();
            s.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void IzmeniFizickoLice(FizickoLiceView fizickoLice)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            FizickoLice fl = s.Load<FizickoLice>(fizickoLice.Id);
            if (fl != null)
            {
                fl.Br_tel = fizickoLice.Br_tel;
                fl.Email = fizickoLice.Email;
                fl.Adresa = fizickoLice.Adresa;
                fl.JMBG = fizickoLice.JMBG;
                fl.Datum_rodjenja = fizickoLice.Datum_rodjenja;
                fl.LIme = fizickoLice.LIme;
                fl.Ime_roditelja = fizickoLice.Ime_roditelja;
                fl.Prezime = fizickoLice.Prezime;
                fl.Br_licne_karte = fizickoLice.Br_licne_karte;
                fl.Mesto_izdavanja = fizickoLice.Mesto_izdavanja;
                fl.Naziv = fizickoLice.LIme + fizickoLice.Prezime;

                s.Update(fl);
                s.Flush();
                s.Close();
            }
            else
            {
                Console.WriteLine("Fizicko lice sa ovim id-jem ne postoji.\n");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }



    #endregion
}

