using Model;

namespace Windesheim_RaceSim.Controller;

public class Track
{
    public string Name { get; set; }
    public LinkedList<Section> Sections { get; set; }

    public Track(string name, SectionTypes[] sections)
    {
        Name = name;
        foreach (var sectie in sections)
        {
            Section section = new Section(sectie);
            Sections?.AddLast(section);
        }
    }
    

}

