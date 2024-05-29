﻿namespace DatabaseAccess.DTOs;

public class RacunOvlascenoLiceView
{

    public int Id { get; protected set; }
    public string? ImeOvlascenogLica { get; set; }

    //MAPIRANJE BANKA_BR_TEL-BANKA
    public RacunView? PripadaRacunu { get; set; }

    internal RacunOvlascenoLiceView(int id, string imeLica, RacunView racun)
    {
        this.Id = id;
        this.ImeOvlascenogLica = imeLica;
        this.PripadaRacunu = racun;
    }

    internal RacunOvlascenoLiceView() { }
}
