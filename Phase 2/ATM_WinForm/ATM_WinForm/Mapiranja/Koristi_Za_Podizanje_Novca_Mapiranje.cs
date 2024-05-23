using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ATM_WinForm.Entiteti;

namespace ATM_WinForm.Mapiranja
{
    //public class Koristi_Za_Podizanje_Novca_Mapiranje : ClassMap<ATM_WinForm.Entiteti.Koristi_Za_Podizanje_Novca>
    //{
    //    public Koristi_Za_Podizanje_Novca_Mapiranje()
    //    {
    //        Table("KORISTI_ZA_PODIZANJE_NOVCA");

    //        Id(x => x.ID_Transakcije, "ID_TRANSAKCIJE").GeneratedBy.TriggerIdentity();

    //        //MAPIRANJE 1:N  --> KORISTI ZA PODIZANJE NOVCA-BANKOMAT
    //        References(x => x.ID_Bankomata).Column("ID_BANKOMATA").LazyLoad();

    //        //MAPIRANJE 1:N  --> KORISTI ZA PODIZANJE NOVCA-KARTICA
    //        References(x => x.ID_Kartice).Column("ID_KARTICE").LazyLoad();

    //        //MAPIRANJE 
    //        References(x => x.ID_Transakcije).Column("ID_TRANSAKCIJE").LazyLoad();
    //    }
    //}
}
