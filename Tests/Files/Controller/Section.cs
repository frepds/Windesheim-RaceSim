using Model;

namespace Windesheim_RaceSim.Controller;

public class Section
{
    public SectionTypes SectionType { get; set; }
    
    public Section(SectionTypes sectionType)
    {
        SectionType = sectionType;
    }
}
