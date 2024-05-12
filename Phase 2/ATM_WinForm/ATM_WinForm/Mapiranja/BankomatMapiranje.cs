using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ATM_WinForm.Entiteti;

namespace ATM_WinForm.Mapiranja
{
    public class BankomatMapiranje : ClassMap<ATM_WinForm.Entiteti.Bankomat>
    {
        public BankomatMapiranje()
        {
            Table("BANKOMATI");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Status, "STATUS");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.Datum_Poslednjeg_Servisa, "DATUM_POSLEDNJEG_SERVISA");

            //MAPIRANJE 1:N  --> FILIJALA-BANKOMAT
            References(x => x.InstaliranUFilijali).Column("RBR_FILIJALE").LazyLoad();
        }
    }
}
