using System.ComponentModel;

namespace ATM_WinForm.Entiteti
{
    public class BankaBrTelefona
    {
        [Browsable(false)]
        public virtual int Id { get; protected set; }

        [DisplayName("Broj telefona")]
        public virtual string BrTelefona { get; set; }

        [Browsable(false)]
        public virtual Banka PripadaBanci { get; set; }
    }
}
