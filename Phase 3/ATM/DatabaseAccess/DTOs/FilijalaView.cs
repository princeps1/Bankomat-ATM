namespace DatabaseAccess.DTOs;

public class FilijalaView
{
    public int Rbr_filijale { get; protected set; }
    public string? Adresa { get; set; }
    public string? Br_telefona { get; set; }
    public string? Radno_vreme { get; set; }
    public string? Ime_banke { get; set; }

    //MAPIRANJE FILIJALA-BANKA
    public BankaView? PripadaBanci { get; set; }

    //MAPIRANJE FILIJAL-BANKOMAT
    public IList<BankomatView>? Bankomati { get; set; }

    internal FilijalaView(int id, string adresa, string brTelefona, string radnoVreme, BankaView banka)
    {
        this.Rbr_filijale = id;
        this.Adresa = adresa;
        this.Br_telefona = brTelefona;
        this.Radno_vreme = radnoVreme;
        this.PripadaBanci = banka;
        this.Ime_banke = banka.Ime;
    }
    internal FilijalaView()
    {
        Bankomati = new List<BankomatView>();
    }
}
