namespace DatabaseAccess.DTOs;
public class RacunView
{
    public int Br_racuna { get; protected set; }
    public DateTime Datum_otvaranja { get; set; }
    public string? Tekuci_saldo { get; set; }
    public string? Tip { get; set; }
    public string? Valuta { get; set; }


    //MAPIRANJE RACUN-BANKA
    public BankaView? JePovezan { get; set; }

    //MAPIRANJE RACUN-KLIJENT
    public KlijentView? Koristi { get; set; }

    //MAPIRANJE RACUN-KARTICA
    public IList<KarticaView>? Kartice { get; set; }

    public IList<RacunOvlascenoLiceView>? OvlascenaLica { get; set; }

    internal RacunView(int br_rac, DateTime datum, string tekuci_saldo, string tip, string valuta, BankaView banka, KlijentView klijent)
    {
        this.Br_racuna = br_rac;
        this.Datum_otvaranja = datum;
        this.Tekuci_saldo = tekuci_saldo;
        this.Tip = tip;
        this.Valuta = valuta;
        this.JePovezan = banka;
        this.Koristi = klijent;
    }

    internal RacunView()
    {
        Kartice = new List<KarticaView>();
        OvlascenaLica = new List<RacunOvlascenoLiceView>();
    }
}

