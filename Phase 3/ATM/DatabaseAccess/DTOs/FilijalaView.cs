using System.Text.Json.Serialization;
using DatabaseAccess.Entiteti;
using Microsoft.CSharp.RuntimeBinder;

namespace DatabaseAccess.DTOs;

public class FilijalaView
{
    public int Rbr_filijale { get;  set; }
    public string? Adresa { get; set; }
    public string? Br_telefona { get; set; }
    public string? Radno_vreme { get; set; }
    public string? Ime_banke { get; set; }

    //MAPIRANJE FILIJALA-BANKA
    public BankaView? PripadaBanci { get; set; }

    //MAPIRANJE FILIJAL-BANKOMAT
    public IList<BankomatView>? Bankomati { get; set; }

    internal FilijalaView(Filijala f)
    {
        this.Rbr_filijale = f.Rbr_filijale;
        this.Adresa = f.Adresa;
        this.Br_telefona = f.Br_telefona;
        this.Radno_vreme = f.Radno_vreme;
        
        BankaView banka = new BankaView(f.PripadaBanci);
        this.PripadaBanci = banka;
        this.PripadaBanci.Ime = banka.Ime;
    }

    internal FilijalaView(int id, string adresa, string brTelefona, string radnoVreme, BankaView banka)
    {
        this.Rbr_filijale = id;
        this.Adresa = adresa;
        this.Br_telefona = brTelefona;
        this.Radno_vreme = radnoVreme;
        this.PripadaBanci = banka;
        this.Ime_banke = banka.Ime;
    }

    public FilijalaView(string adresa, string brTelefona, string radnoVreme, BankaView pripadaBanci)
    {
        this.Adresa = adresa;
        this.Br_telefona = brTelefona;
        this.Radno_vreme = radnoVreme;
        this.PripadaBanci = pripadaBanci;
        this.Ime_banke = pripadaBanci.Ime;
    }

    internal FilijalaView()
    {
        Bankomati = new List<BankomatView>();
    }

    public void SetRbr(int rbr)
    {
        this.Rbr_filijale = rbr;
    }
}
