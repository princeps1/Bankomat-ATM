using System.Collections.Generic;
using System.ComponentModel;

namespace ATM_WinForm.Entiteti
{
    public class Banka
    {
        [DisplayName("ID")]
        public virtual int Id { get; protected set; }

        [DisplayName("Ime")]
        public virtual string Ime { get; set; }

        [DisplayName("Email")]
        public virtual string Email { get; set; }

        [DisplayName("Web Adresa")]
        public virtual string Web_adresa { get; set; }

        [DisplayName("Adresa Centrale")]
        public virtual string Adresa_centrale { get; set; }

        [Browsable(false)]
        public virtual IList<Filijala> Filijala { get; set; }

        [Browsable(false)]
        public virtual IList<BankaBrTelefona> BrojeviTelefona { get; set; }

        public Banka()
        {
            Filijala = new List<Filijala>();
            BrojeviTelefona = new List<BankaBrTelefona>();
        }
    }
}
