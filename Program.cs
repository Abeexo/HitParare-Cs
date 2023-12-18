using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitparade
{
public class Hit
{
    public string Title { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Author}";
    }
}

public class HitParade
{
    private List<Hit> hits;

    public HitParade()
    {
        hits = new List<Hit>();
    }

    public void AddHit(Hit hit)
    {
        hits.Add(hit);
    }

    public void AddHitAtPosition(Hit hit, int position)
    {
        hits.Insert(position, hit);
    }

    public void RemoveHitAtPosition(int position)
    {
        hits.RemoveAt(position);
    }

    public void SwapHits(int position1, int position2)
    {
        Hit temp = hits[position1];
        hits[position1] = hits[position2];
        hits[position2] = temp;
    }

   public void DisplayHits()
{
    Console.WriteLine(); // Aggiunge una riga vuota prima dell'output
    for (int i = 0; i < hits.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {hits[i]}");
    }

}

    public void DisplayHitsWithTitle(string searchWord)
    {
    for (int i = 0; i < hits.Count; i++)
    {
        if (hits[i].Title.Contains(searchWord))
        {
            Console.WriteLine();
            Console.WriteLine($"{i + 1}. {hits[i]}");
        } else {
            Console.WriteLine();
            Console.WriteLine("Nessuna hit contiene la parola ricercata");
        }
    }
}
}
public class GestioneHitParade{
    private HitParade hitParade;

    public GestioneHitParade()
    {
        hitParade = new HitParade();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Scegli un'opzione:");
            Console.WriteLine("1. Visualizza la classifica attuale");
            Console.WriteLine("2. Aggiungi una nuova hit");
            Console.WriteLine("3. Inserisci una nuova hit in una certa posizione");
            Console.WriteLine("4. Rimuovi una hit in una certa posizione");
            Console.WriteLine("5. Scambia due hit in certe posizioni");
            Console.WriteLine("6. Visualizza tutte le hit che contengono una certa parola nel titolo");
            Console.WriteLine("7. Esci");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    hitParade.DisplayHits();
                    break;
                case 2:
                    AddNewHit();
                    break;
                case 3:
                    AddNewHitAtPosition();
                    break;
                case 4:
                    hitParade.RemoveHitAtPosition(3);
                    break;
                case 5:
                    hitParade.SwapHits(3,5);
                    break;
                case 6:
                    Console.WriteLine();
                    Console.Write("Inserisci la parola da cercare nel titolo: ");
                    string searchWord = Console.ReadLine();
                    hitParade.DisplayHitsWithTitle(searchWord);
                    break;
                case 7:
                    return;
            }
        }
    }

   

    private void AddNewHit()
    {
        Console.Write("Inserisci il titolo della nuova hit: ");
        string title = Console.ReadLine();
        Console.Write("Inserisci l'autore della nuova hit: ");
        string author = Console.ReadLine();

        Hit hit = new Hit { Title = title, Author = author };
        hitParade.AddHit(hit);
    }

    private void AddNewHitAtPosition()
    {
        Console.Write("Inserisci il titolo della nuova hit: ");
        string title = Console.ReadLine();
    }

}
class Program
{
    static void Main(string[] args)
    {
        GestioneHitParade gestioneHitParade = new GestioneHitParade();
        gestioneHitParade.Run();
    }
}
}
       


