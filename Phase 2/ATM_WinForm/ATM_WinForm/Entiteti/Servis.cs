﻿using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace ATM_WinForm.Entiteti
{
    public class Servis
    {
        [DisplayName("KOD")]
        public virtual int Kod { get; protected set; }

        [DisplayName("FIRMA")]
        public virtual string Firma { get; set; }

        //MAPIRANJE SERVIS-BANKOMAT
        [Browsable(false)]
        public virtual Bankomat ServisiraniBankomat { get; set; }
    }
}