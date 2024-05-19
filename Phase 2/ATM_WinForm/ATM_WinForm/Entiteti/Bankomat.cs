using System.Collections.Generic;
using System.ComponentModel;
using System;

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
        public virtual string Status { get; set; }

        [DisplayName("Datum poslednjeg servisa")]
        public virtual DateTime Datum_Poslednjeg_Servisa { get; set; }


        //MAPIRANJE BANKOMAT-FILIJALA
        [Browsable(false)]
        public virtual Filijala InstaliranUFilijali { get; set; }

    }
}
