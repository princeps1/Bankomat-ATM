using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ATM_WinForm.Entiteti;

namespace ATM_WinForm.Mapiranja
{
    public class FilijalaMapiranje : ClassMap<ATM_WinForm.Entiteti.Filijala>
    {
        public FilijalaMapiranje()
        {
            //Mapiranje tabele
            Table("FILIJALA");

            //mapiranje primarnog kljuca
            Id(x => x.Rbr_filijale, "RBR_FILIJALE").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Br_telefona, "BR_TELEFONA");
            Map(x => x.Radno_vreme, "RADNO_VREME");

            //MAPIRANJE 1:N  --> BANKA-FILIJALA
            References(x => x.PripadaBanci).Column("ID_BANKE").LazyLoad();

            //mapiranje veze 1:N Prodavnica-Odeljenje
            //HasMany(x => x.Filijala).KeyColumn("ID_BANKE").LazyLoad();
            //HasMany(x => x.Filijala).KeyColumn("ID_BANKE").LazyLoad().Cascade.All();
            HasMany(x => x.Bankomati).KeyColumn("RBR_FILIJALE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
