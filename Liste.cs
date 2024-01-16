using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon;

public class Liste
{
    List<Teilnehmer> teilnehmerliste = new();

    public void AddTeilnehmer(Teilnehmer s)
    {
        teilnehmerliste.Add(s);
    }

public string Title
{
    get;  //auch andere Klassen dürfen auslesen
    private set; // nur die eigene Klasse darf setzen
}

public Liste(string name)
{
    this.Title = name;
}

public void Print()
    {
        Console.WriteLine("Listen Name:\t{0}", Title);
        Console.WriteLine("================================================================\n");

        for (int i = 0; i < teilnehmerliste.Count; i++)
        {
            Console.WriteLine($"Vor/Nachname: {teilnehmerliste[i].GetName()}");
            Console.WriteLine($"Startnummer: {teilnehmerliste[i].GetStartnummer()}");
            Console.WriteLine($"Laufzeit(in Minuten): {teilnehmerliste[i].GetTime()}");
            Console.WriteLine("-------------------------------------------------------");
        }
        Console.WriteLine();

    }
}
