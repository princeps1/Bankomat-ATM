using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_WinForm.Forme.Transakcije
{
    public partial class Form_Transakcije_Add : Form
    {
        private readonly string type = "";
        private readonly ATM_WinForm.DTOs.TransakcijaBasic transakcija = null;
        public Form_Transakcije_Add(string type, DTOs.TransakcijaBasic transakcija)
        {
            InitializeComponent();
            this.type = type;
            this.transakcija = transakcija;
        }
    }
}
