using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ATM_WinForm.Entiteti;

namespace ATM_WinForm.Mapiranja
{
    public class KlijentMapiranje : ClassMap<ATM_WinForm.Entiteti.Klijent>
    {
        public KlijentMapiranje()
        {
            Table("KLIJENT");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Br_tel, "BR_TEL");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Email, "EMAIL");

            //mapiranje veze 1:N Prodavnica-Odeljenje
            //HasMany(x => x.Filijala).KeyColumn("ID_BANKE").LazyLoad();
            //HasMany(x => x.Filijala).KeyColumn("ID_BANKE").LazyLoad().Cascade.All();

        }
    }
}
