using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace ATM_WinForm.Entiteti
{
    public abstract class Kartica
    {
        [DisplayName("ID")]
        public virtual int Id { get; protected set; }

        [DisplayName("Datum izdavanja")]
        public virtual DateTime Datum_izdavanje { get; set; }

        [DisplayName("Datum isteka")]
        public virtual DateTime Datum_isteka { get; set; }

        [DisplayName("Dnevni limit")]
        public virtual string Dnevni_limit { get; set; }

        [Browsable(false)]
        public virtual string Tip { get; set; }

        [DisplayName("Maksimalan iznos zaduzenja")]
        public virtual string Max_iznos_zaduzenja { get; set; }

        [DisplayName("Max datum vracanja duga")]
        public virtual DateTime Max_datum_vracanja_duga { get; set; }

        //MAPIRANJE KARTICA-RACUN
        [Browsable(false)]
        public virtual Racun Odgovara { get; set; }
    }

    public class DebitnaKartica : Kartica
    {

    }

    public class KreditnaKartica : Kartica
    {
        [DisplayName("Maksimalan iznos zaduzenja")]
        public override string Max_iznos_zaduzenja { get; set; }

        [DisplayName("Max datum vracanja duga")]
        public override DateTime Max_datum_vracanja_duga { get; set; }
    }
}
