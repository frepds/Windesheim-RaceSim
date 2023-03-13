using Model;

namespace Windesheim_RaceSim.Controller;

public class Competition
{
    public List<IParticipant> Participants = new List<IParticipant>(); 
    public Queue<Track> Tracks = new Queue<Track>();

    public Track NextTrack()
    {
        
    }

}

