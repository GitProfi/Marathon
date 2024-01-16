using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon;

public class Teilnehmer
{
    string _vorname;
    string _nachname;
    int _startnummer;
    int _laufzeit;

    public string GetName()
    {
        return $"{_vorname} {_nachname}";
    }

    public int GetTime()
    {
        return _laufzeit;
    }

    public int GetStartnummer()
    {
        return _startnummer;
    }

    public Teilnehmer(string vorname, string nachname, int startnummer, int laufzeit)
    {
        this._vorname = vorname;
        this._nachname = nachname;
        this._startnummer = startnummer;
        this._laufzeit = laufzeit;
    }
}

