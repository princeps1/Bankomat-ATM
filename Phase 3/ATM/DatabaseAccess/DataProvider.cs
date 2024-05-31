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
            return null;
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
                                             where o.PripadaBanci.Id == bankaId
                                             select o;

            foreach (Filijala f in filijale)
            {
                BankaView banka = VratiBanku(f.PripadaBanci.Id);
                filijalaList.Add(new FilijalaView(f.Rbr_filijale, f.Adresa, f.Br_telefona, f.Radno_vreme, banka));
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
            var b = VratiBanku(f.PripadaBanci.Id);
            FilijalaView filijala = new FilijalaView(f.Rbr_filijale, f.Adresa, f.Br_telefona, f.Radno_vreme, b);

            s.Close();

            return filijala;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
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
                f.Adresa = filijala.Adresa;
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
}

