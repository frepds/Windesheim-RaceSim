using Model;
using NUnit.Framework;
using Windesheim_RaceSim.Controller;


[TestFixture] 
public class Model_Competition_NextTrackShould 
{
    private Competition _competition; 
    [SetUp] 
    public void SetUp()
    {
        IParticipant participant = new Driver("Driver1", 10, new Car(10,10,10,false), TeamColors.Blue);
        
        
        //_competition = new Competition(participant, new Queue<Track>());
    }
    
    [Test] 
    public void NextTrack_EmptyQueue_ReturnNull() 
    {
        var result = _competition.NextTrack(); 
        Assert.That(result, Is.Null);
    }
}