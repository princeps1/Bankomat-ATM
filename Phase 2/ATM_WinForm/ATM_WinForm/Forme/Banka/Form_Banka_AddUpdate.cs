using System;
using System.Windows.Forms;
using NHibernate;
using System.Text.RegularExpressions;
using System.Linq;

namespace ATM_WinForm
{
    public partial class Form_Banka_AddUpdate : Form
    {
        private string type = "";
        private ATM_WinForm.Entiteti.Banka banka = null;
        static public event EventHandler<BankaEventArgs> BankaEventi;

        public Form_Banka_AddUpdate(string type, ATM_WinForm.Entiteti.Banka banka)
        {
            InitializeComponent();
               
            this.type = type;
            this.banka = banka;

            switch(this.type)
            {
                case "add":
                    {
                        AkcijaBankeBtn.Text = "Dodaj Banku";

                        this.Text = "ATM - Dodaj Banku";

                        break;
                    }
                case "update":
                    {
                        AkcijaBankeBtn.Text = "Izmeni Banku";

                        ImeTxtBx.Text = banka.Ime;
                        EmailTxtBx.Text = banka.Email;
                        WebAdresaTxtBx.Text = banka.Web_adresa;
                        AdresaCentraleTxtBx.Text = banka.Adresa_centrale;

                        this.Text = "ATM - Izmeni Banku";

                        break;
                    }
                default: break;
            }
        }

        private void AkcijaBankeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if(ImeTxtBx.Text == "" || 
                   EmailTxtBx.Text == "" || 
                   WebAdresaTxtBx.Text == "" || 
                   AdresaCentraleTxtBx.Text == ""
                   )
                {
                    MessageBox.Show("Polja ne smeju biti prazna!");
                    return;
                }

                Match emailMatch = Regex.Match(EmailTxtBx.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", RegexOptions.IgnoreCase);

                if(!emailMatch.Success)
                {
                    MessageBox.Show("Unesite validnu email adresu!");
                    return;
                }

                if (this.type == "add" || this.banka.Email != EmailTxtBx.Text)
                {
                    var isEmailExist = s.Query<ATM_WinForm.Entiteti.Banka>().Where(banka => banka.Email == EmailTxtBx.Text).ToList();

                    if (isEmailExist.Count > 0)
                    {
                        MessageBox.Show("Ova email adresa vec postoji u bazi!");
                        return;
                    }
                }

                if (this.type == "add" || this.banka.Web_adresa != WebAdresaTxtBx.Text)
                {
                    var isWebAdresaExist = s.Query<ATM_WinForm.Entiteti.Banka>().Where(banka => banka.Web_adresa == WebAdresaTxtBx.Text).ToList();

                    if (isWebAdresaExist.Count > 0)
                    {
                        MessageBox.Show("Ova web adresa vec postoji u bazi!");
                        return;
                    }
                }

                switch (this.type)
                {
                    case "add":
                        {
                            Entiteti.Banka banka = new Entiteti.Banka
                            {
                                Ime = ImeTxtBx.Text,
                                Email = EmailTxtBx.Text,
                                Web_adresa = WebAdresaTxtBx.Text,
                                Adresa_centrale = AdresaCentraleTxtBx.Text
                            };

                            s.SaveOrUpdate(banka);

                            MessageBox.Show("Uspesno ste dodali banku!");

                            BankaEventi?.Invoke(this, new BankaEventArgs("add", banka));

                            ImeTxtBx.Text = "";
                            EmailTxtBx.Text = "";
                            WebAdresaTxtBx.Text = "";
                            AdresaCentraleTxtBx.Text = "";

                            break;
                        }
                    case "update":
                        {
                            this.banka.Ime = ImeTxtBx.Text;
                            this.banka.Email = EmailTxtBx.Text;
                            this.banka.Web_adresa = WebAdresaTxtBx.Text;
                            this.banka.Adresa_centrale = AdresaCentraleTxtBx.Text;

                            s.Update(this.banka);

                            BankaEventi?.Invoke(this, new BankaEventArgs("update", banka));

                            MessageBox.Show("Uspesno ste izmenili banku!");
                            
                            break;
                        }
                    default: break;
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
