using Model;

namespace Windesheim_RaceSim.Controller;

public class Competition
{
    public List<IParticipant> Participants { get; set; }
    public Queue<Track> Tracks { get; set; }

    public Competition()
    {
        Participants = new List<IParticipant>();
        Tracks = new Queue<Track>();
    }
    
    public Track NextTrack()
    {
        foreach (var track in Tracks)
        {
            var s = Tracks.FirstOrDefault();
            Tracks.Dequeue();
            if (s != null) return s;
        }
        return null;
    }
}
