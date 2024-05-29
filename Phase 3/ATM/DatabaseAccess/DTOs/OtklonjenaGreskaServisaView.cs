﻿namespace DatabaseAccess.DTOs;

public class OtklonjenaGreskaServisaView
{
    public int Id { get; protected set; }
    public string? Otklonjena_greska { get; set; }

    //MAPIRANJE OTKLONJENA GRESKA-SERVIS
    public ServisView? PripadaServisu { get; set; }


    internal OtklonjenaGreskaServisaView(int id, string greska, ServisView servis)
    {
        this.Id = id;
        this.Otklonjena_greska = greska;
        this.PripadaServisu = servis;
    }

    internal OtklonjenaGreskaServisaView() { }
}
