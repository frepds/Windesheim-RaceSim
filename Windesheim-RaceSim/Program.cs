using Model;
using Windesheim_RaceSim.Controller;
namespace Windesheim_RaceSim;

public class Program
{
    public static void Main(string[] args)
    {
        var competition = new Competition(new List<IParticipant>(){}, new Queue<Track>());
        Data.Initialize(competition);
        Data.NextRace(); 
        for (var i = 0; i < 101; i++)
        {
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


//using Model;
// using NUnit.Framework;
// using Windesheim_RaceSim.Controller;
//
//
// [TestFixture] 
// public class Model_Competition_NextTrackShould 
// {
//     private Competition _competition; 
//
//     [SetUp] 
//     public void SetUp()
//     {
//         _competition = new Competition(new List<IParticipant>(), new Queue<Track>());
//     }
//
//     [Test] 
//     public void NextTrack_EmptyQueue_ReturnNull() 
//     {
//         var result = _competition.NextTrack(); 
//         Assert.IsNull(result);
//     }
// }