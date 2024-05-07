using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ATM_WinForm.Entiteti;

namespace ATM_WinForm.Mapiranja
{
    public class BankaMapiranje : ClassMap<ATM_WinForm.Entiteti.Banka>
    {
        public BankaMapiranje()
        {
            Table("BANKA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Email, "EMAIL");
            Map(x => x.Web_adresa, "WEB_ADRESA");
            Map(x => x.Adresa_centrale, "ADRESA_CENTRALE");

            //mapiranje veze 1:N Prodavnica-Odeljenje
            //HasMany(x => x.Filijala).KeyColumn("ID_BANKE").LazyLoad();
            //HasMany(x => x.Filijala).KeyColumn("ID_BANKE").LazyLoad().Cascade.All();
            HasMany(x => x.Filijala).KeyColumn("ID_BANKE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
