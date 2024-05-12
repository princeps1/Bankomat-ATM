using ATM_WinForm.Entiteti;
using System;

public class FilijalaEventArgs : EventArgs
{
    public FilijalaEventArgs(string type, Filijala filijala)
    {
        TipAkcije = type;
        NovaFilijala = filijala;
    }

    public Filijala NovaFilijala { get; }
    public string TipAkcije { get; }
}
