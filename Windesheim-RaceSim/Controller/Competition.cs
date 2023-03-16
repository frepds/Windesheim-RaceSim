using Model;

namespace Windesheim_RaceSim.Controller;

public class Competition
{
    public List<IParticipant> Participants { get; set; }
    public Queue<Track> Tracks { get; set; }

    public Competition(List<IParticipant> participants, Queue<Track> tracks)
    {
        Participants = participants ?? throw new ArgumentNullException(nameof(participants));
        Tracks = tracks ?? throw new ArgumentNullException(nameof(tracks));
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
