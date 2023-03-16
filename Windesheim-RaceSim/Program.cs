using Model;
using Windesheim_RaceSim.Controller;
namespace Windesheim_RaceSim;

public class Program
{
    public static void Main(string[] args)
    {
        for (var i = 0; i < 101; i++)
        {
            var competition = new Competition(new List<IParticipant>(){}, new Queue<Track>());
            Data.Initialize(competition); // aanroepen van Initialize methode

            Data.NextRace(); // aanroepen van NextRace methode

            if (Data.CurrentRace != null) {
                Console.WriteLine("De naam van de Track van de huidige Race is: " + Data.CurrentRace.Track.Name);
            }
            else {
                Console.WriteLine("Er is geen huidige Race beschikbaar.");
            }
            
            Thread.Sleep(100);
        }
    }
}
