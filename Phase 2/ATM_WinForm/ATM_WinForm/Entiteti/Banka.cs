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

        //MAPIRANJE BANKA-FILIJA
        [Browsable(false)]
        public virtual IList<Filijala> Filijala { get; set; }


        //MAPIRANJE BANKA-BANKA_BR_TEL
        [Browsable(false)]
        public virtual IList<BankaBrTelefona> BrojeviTelefona { get; set; }


        //MAIRANJE BANKA-RACUN
        [Browsable(false)]
        public virtual IList<Racun> Racuni { get; set; }

        public Banka()
        {
            //MAPIRANJE BANKA-FILIJALA
            Filijala = new List<Filijala>();

            //MAPIRANJE BANKA-BANKA_BR_TEL
            BrojeviTelefona = new List<BankaBrTelefona>();

            //MAPIRANJE BANKA-RACUN
            Racuni = new List<Racun>();
        }
    }
}
