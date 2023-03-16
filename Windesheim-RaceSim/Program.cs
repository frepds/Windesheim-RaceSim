using Model;
using Windesheim_RaceSim.Controller;
namespace Windesheim_RaceSim;

public class Program
{
    public static void print(string s) { Console.Write($"{s} "); }
    public static void nextLine() { Console.WriteLine(); }

    public static void Main(string[] args)
    {
        var competition = new Competition(new List<IParticipant>(), new Queue<Track>());
        Data.Initialize(competition);
        Data.NextRace();

        foreach (var p in Data.Competition.Participants)
        {
            int[] n = { p.Points, p.Equipment.Quality, p.Equipment.Speed, p.Equipment.Performance };
            var s = new string[Data.Competition.Participants.Count];
            
            for (var i = 0; i < n.Length; i++)
            {
                s[i] = n[i] < 10 ? n[i] + " " : n[i].ToString();
            }
            
            print(p.Name.Length == 7 ? $"Name: {p.Name}  |" : $"Name: {p.Name} |");

            for (var i = 0; i < n.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        print($"Points: {s[i]} |");
                        break;
                    case 1:
                        print($"Quality: {s[i]} |");
                        break;
                    case 2:
                        print($"Speed: {s[i]} |");
                        break;
                    case 3:
                        print($"Performance: {s[i]} |");
                        break;
                }
            }

            var l = p.TeamColor.ToString().Length;
            var kleur = $"Kleur: {p.TeamColor}";
            if (l < 6)
            {
                for (int i = l; i < 6; i++)
                {
                    kleur += " ";
                }
            }
            print($"Kapot: {p.Equipment.IsBroken} |");
            print($"{kleur} |");
            nextLine();
        }
        
        
        for (var i = 0; i < 101; i++)
        {
            if (Data.CurrentRace != null) {
                Console.WriteLine("De naam van de Track van de huidige Race is: " + Data.CurrentRace.Track.Name);
            }
            else {
                Console.WriteLine("Er is geen huidige Race beschikbaar.");
            }
            Thread.Sleep(400);
        }

        Console.ReadKey();
    }
}
