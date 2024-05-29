namespace DatabaseAccess.DTOs;

public class PravnoLiceView : KlijentView
{
    public string? Poreski_id { get; set; }

    internal PravnoLiceView(string poreski_id, int id, string naziv, string telefon, string email, string adresa)
        : base(id, telefon, email, adresa)
    {
        Poreski_id = poreski_id;
        this.Naziv = naziv;
    }

    internal PravnoLiceView() { }
}
