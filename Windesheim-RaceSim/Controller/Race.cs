using Model;

namespace Windesheim_RaceSim.Controller;

public class Race
{
    public Track Track { get; set; }
    public List<IParticipant> Participants { get; set; }
    public DateTime StartTime { get; set; }
    private Random _random { get; set; }
    private Dictionary<Section, SectionData> _positions;

    public SectionData GetSectionData(Section section)
    {
        var s = new SectionData();
        if (_positions.ContainsKey(section))
        {
            s = _positions[section];
        }
        else // Toevoegen
        {
            _positions.Add(section, new SectionData());
        }
        return s;
    }

    public Race(Track track, List<IParticipant> participants)
    {
        Track = track ?? throw new ArgumentNullException(nameof(track));
        Participants = participants ?? throw new ArgumentNullException(nameof(participants));
        _random = new Random(DateTime.Now.Millisecond);
    }

    public void RandomizeEquipment()
    {
        foreach (var p in Participants)
        {
            p.Equipment.Quality = _random.Next(1, 100);
            p.Equipment.Performance = _random.Next(1, 100);
        }
    }
}
