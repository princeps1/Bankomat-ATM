using ATM_WinForm.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
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

                var banka = s.Load<Banka>(bankaId);

                s.Delete(banka);

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

                var filijala = s.Load<Filijala>(filijalaId);

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
    }
}
