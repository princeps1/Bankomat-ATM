using DatabaseAccess.Entiteti;
namespace DatabaseAccess.DTOs;

public class BankaView
{
    public int Id { get; protected set; }
    public string? Ime { get; set; }
    public string? Email { get; set; }
    public string? Web_adresa { get; set; }
    public string? Adresa_centrale { get; set; }
    public IList<FilijalaView>? Filijala { get; set; }
    public IList<RacunView>? Racuni { get; set; }
    public IList<BankaBrTelefonaView>? BrojeviTelefona { get; set; }

    internal BankaView(Banka b)
    {
        this.Id = b.Id;
        this.Ime = b.Ime;
        this.Email = b.Email;
        this.Web_adresa = b.Web_adresa;
        this.Adresa_centrale = b.Adresa_centrale;
    }
    internal BankaView()
    {
        Filijala = new List<FilijalaView>();
        Racuni = new List<RacunView>();
        BrojeviTelefona = new List<BankaBrTelefonaView>();
    }
}
