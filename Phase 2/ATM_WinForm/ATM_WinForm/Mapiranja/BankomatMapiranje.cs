using FluentNHibernate.Mapping;

namespace ATM_WinForm.Mapiranja
{
    public class BankomatMapiranje : ClassMap<ATM_WinForm.Entiteti.Bankomat>
    {
        public BankomatMapiranje()
        {
            Table("BANKOMAT");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Status, "STATUS");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.Datum_Poslednjeg_Servisa, "DATUM_POSLEDNJEG_SERVISA");

            //MAPIRANJE veze 1:N  --> BANKOMAT-FILIJALA
            References(x => x.InstaliranUFilijali).Column("RBR_FILIJALE").LazyLoad();
        }
    }
}
