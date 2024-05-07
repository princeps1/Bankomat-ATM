using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_WinForm.Entiteti
{
    public class Filijala
    {
        public virtual int Rbr_filijale { get; protected set; }
        
        public virtual string Adresa { get; set; }
        public virtual string Br_telefona { get; set; }
        public virtual string Radno_vreme { get; set; }

        public virtual Banka PripadaBanci{ get; set; }
    }
}
