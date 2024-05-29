using DatabaseAccess.DTOs;
using DatabaseAccess.Entiteti;
using NHibernate;

namespace DatabaseAccess;

public static class DataProvider
{
    public static List<BankaView> VratiSveBanke()
    {
        ISession? s = null;

        List<BankaView> banke = new();

        try
        {
            s = DataLayer.GetSession();


            IEnumerable<Banka> sveBanke= from o in s.Query<Banka>()
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
}

