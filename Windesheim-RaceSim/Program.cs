using Windesheim_RaceSim.Controller;

namespace Windesheim_RaceSim;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 101; i++)
        {
            
            Data.Initialize(); // aanroepen van Initialize methode

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
