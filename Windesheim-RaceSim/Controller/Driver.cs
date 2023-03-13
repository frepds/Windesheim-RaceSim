using Model;

namespace Windesheim_RaceSim.Controller;

public class Driver : IEquipment
{
    public int Quality { get; set; }
    public int Performance { get; set; }
    public int Speed { get; set; }
    public bool IsBroken { get; set; }
    
    
}