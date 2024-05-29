namespace DatabaseAccess.DTOs;

public class ServisView
{
    public int Kod { get; protected set; }
    public string? Firma { get; set; }

    //MAPIRANJE SERVIS-BANKOMAT
    public BankomatView? ServisiraniBankomat { get; set; }

    //MAPIRANJE SERVIS-OTKLONJENE GRESKE
    public IList<OtklonjenaGreskaServisaView>? OtklonjeneGreske { get; set; }

    internal ServisView(int kod, string firma, BankomatView bankomat)
    {

        this.Kod = kod;
        this.Firma = firma;
        this.ServisiraniBankomat = bankomat;
    }

    internal ServisView()
    {
        //MAPIRANJE SERVIS-OTKLONJENE GRESKE
        OtklonjeneGreske = new List<OtklonjenaGreskaServisaView>();
    }
}
