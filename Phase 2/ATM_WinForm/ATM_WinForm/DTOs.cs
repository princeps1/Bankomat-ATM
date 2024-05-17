using System.Collections.Generic;
using System.ComponentModel;

namespace ATM_WinForm
{
    public class DTOs
    {
        public class BankaBasic
        {
            [DisplayName("ID")]
            public int Id { get; protected set; }

            [DisplayName("Ime")]
            public string Ime { get; set; }

            [DisplayName("Email")]
            public string Email { get; set; }

            [DisplayName("Web Adresa")]
            public string Web_adresa { get; set; }

            [DisplayName("Adresa Centrale")]
            public string Adresa_centrale { get; set; }

            [Browsable(false)]
            public virtual IList<FilijalaBasic> Filijala { get; set; }

            public BankaBasic(int id, string ime, string email, string webAdresa, string adresaCentrale)
            {
                this.Id = id;
                this.Ime = ime;
                this.Email = email;
                this.Web_adresa = webAdresa;
                this.Adresa_centrale = adresaCentrale;
            }
            public BankaBasic()
            {
                Filijala = new List<FilijalaBasic>();
            }
        }

        public class FilijalaBasic
        {
            [DisplayName("Redni broj")]
            public virtual int Rbr_filijale { get; protected set; }

            [DisplayName("Adresa")]
            public virtual string Adresa { get; set; }

            [DisplayName("Broj telefona")]
            public virtual string Br_telefona { get; set; }

            [DisplayName("Radno vreme")]
            public virtual string Radno_vreme { get; set; }

            //MAPIRANJE FILIJALA-BANKA
            [Browsable(false)]
            public virtual BankaBasic PripadaBanci { get; set; }

            public FilijalaBasic(int id, string adresa, string brTelefona, string radnoVreme, BankaBasic banka)
            {
                this.Rbr_filijale = id;
                this.Adresa = adresa;
                this.Br_telefona = brTelefona;
                this.Radno_vreme = radnoVreme;
                this.PripadaBanci = banka;
            }
            public FilijalaBasic()
            {

            }
        }
    }
}
