using System.Collections.Generic;
using System.ComponentModel;
public enum Status
{
    operativan,
    neoperativan
}

namespace ATM_WinForm.Entiteti
{
    public class Bankomat
    {
        [DisplayName("ID")]
        public virtual int Id { get; protected set; }

        [DisplayName("Lokacija")]
        public virtual string Lokacija { get; set; }

        [DisplayName("Proizvodjac")]
        public virtual string Proizvodjac { get; set; }

        [DisplayName("Status")]
        public virtual Status Status { get; set; }

        [DisplayName("Datum poslednjeg servisa")]
        public virtual string Datum_Poslednjeg_Servisa { get; set; }


        //MAPIRANJE BANKOMAT-FILIJALA
        [Browsable(false)]
        public virtual Filijala InstaliranUFilijali { get; set; }
    }
}
