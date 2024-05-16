﻿using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace ATM_WinForm.Entiteti
{
    public abstract class Racun
    {
        [DisplayName("Broj racuna")]
        public virtual int Br_racuna { get; protected set; }

        [DisplayName("Datum otvaranja")]
        public virtual DateTime Datum_otvaranja { get; set; }

        [DisplayName("Tekuci saldo")]
        public virtual string Tekuci_saldo { get; set; }


        [DisplayName("Tip")]
        public virtual string Tip {  get; set; }

        //MAPIRANJE RACUN-BANKA
        public virtual Banka JePovezan { get; set; }

    }

    public class DevizniRacun : Racun 
    {
        [DisplayName("Valuta")]
        public virtual string Valuta { get; set; }
    }
    public class DinarskiRacun:Racun { }
}