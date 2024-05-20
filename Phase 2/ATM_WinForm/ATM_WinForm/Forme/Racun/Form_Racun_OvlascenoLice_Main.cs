using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_WinForm.Forme.Racun
{
    public partial class Form_Racun_OvlascenoLice_Main : Form
    {
        private readonly int racunId = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.DTOs.RacunOvlascenoLiceBasic> ovlascenaLica = null;
        public Form_Racun_OvlascenoLice_Main(int racunId)
        {
            InitializeComponent();
            this.racunId = racunId;

            LicaGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form_Racun_OvlascenoLice_Main_Load(object sender, EventArgs e)
        {
            ovlascenaLica = DTOManager.VratiSvaOvlascenaLicaOdRacuna(this.racunId);

            bindingSource.DataSource = ovlascenaLica;
            LicaGrid.DataSource = bindingSource;

            LicaGrid.AllowUserToAddRows = false;
        }
    }
}
