using NHibernate;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATM_WinForm.Forme.Banka
{
    public partial class Form_Banka_SpisakBrojeva_Main : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.Entiteti.BankaBrTelefona> brojeviTelefonaLista = null;
        private readonly int bankaId = -1;
        public Form_Banka_SpisakBrojeva_Main(int bankaId)
        {
            InitializeComponent();
            this.bankaId = bankaId;
        }

        private void Form_Banka_SpisakBrojeva_Main_Load(object sender, System.EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            var banka = s.Load<ATM_WinForm.Entiteti.BankaBrTelefona>(21);

            var test = banka.BrTelefona;

            MessageBox.Show(test);

            bindingSource.DataSource = brojeviTelefonaLista;
            BankaBrTelGrid.DataSource = bindingSource;

            BankaBrTelGrid.AllowUserToAddRows = false;

            s.Close();
        }
    }
}
