namespace DatabaseAccess.DTOs;

public class FizickoLiceView : KlijentView
{
    public string? JMBG { get; set; }
    public DateTime Datum_rodjenja { get; set; }
    public string? LIme { get; set; }
    public string? Ime_roditelja { get; set; }
    public string? Prezime { get; set; }
    public string? Br_licne_karte { get; set; }
    public string? Mesto_izdavanja { get; set; }

    internal FizickoLiceView(string JMBG, DateTime datum_rodjenja, string lIme, string ime_roditelja, string prezime, string br_licne_karte, string mesto_izdavanja, int id, string naziv, string telefon, string email, string adresa)
        : base(id, telefon, email, adresa)
    {
        this.JMBG = JMBG;
        Datum_rodjenja = datum_rodjenja;
        LIme = lIme;
        Ime_roditelja = ime_roditelja;
        Prezime = prezime;
        Br_licne_karte = br_licne_karte;
        Mesto_izdavanja = mesto_izdavanja;
        this.Naziv = naziv;
    }

    internal FizickoLiceView() { }
}
