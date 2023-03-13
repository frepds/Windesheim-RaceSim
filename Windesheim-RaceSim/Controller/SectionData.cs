using Model;

namespace Windesheim_RaceSim.Controller;

public class SectionData
{
    public IParticipant Left { get; set; }
    public IParticipant Right { get; set; }
    public int DistanceLeft { get; set; }
    public int DistanceRight { get; set; }
}

