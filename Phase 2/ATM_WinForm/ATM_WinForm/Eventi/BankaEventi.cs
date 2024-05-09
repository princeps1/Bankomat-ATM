using ATM_WinForm.Entiteti;
using System;

public class BankaEventArgs : EventArgs
{
    public BankaEventArgs(string type, Banka banka)
    {
        TipAkcije = type;
        NovaBanka = banka;
    }

    public Banka NovaBanka { get; }
    public string TipAkcije { get; }
}
