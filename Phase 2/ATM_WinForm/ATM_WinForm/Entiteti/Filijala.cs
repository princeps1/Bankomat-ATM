using System.Collections.Generic;
using System.ComponentModel;

namespace ATM_WinForm.Entiteti
{
    public class Filijala
    {
        [DisplayName("ID")]
        public virtual int Rbr_filijale { get; protected set; }

        [DisplayName("Adresa")]
        public virtual string Adresa { get; set; }

        [DisplayName("Broj telefona")]
        public virtual string Br_telefona { get; set; }

        [DisplayName("Radno vreme")]
        public virtual string Radno_vreme { get; set; }

        [Browsable(false)]
        public virtual Banka PripadaBanci{ get; set; }
    }
}
