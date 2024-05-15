using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ATM_WinForm.Entiteti
{
    public class Klijent
    {
        [DisplayName("ID")]
        public virtual int Id { get; protected set; }

        [DisplayName("Naziv")]
        public virtual string Naziv { get; set; }

        [DisplayName("Broj telefona")]
        public virtual string Br_tel { get; set; }

        [DisplayName("Email")]
        public virtual string Email { get; set; }

        [DisplayName("Adresa")]
        public virtual string Adresa { get; set; }

    }
}
