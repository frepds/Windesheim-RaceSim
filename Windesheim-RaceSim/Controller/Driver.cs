using Model;
namespace Windesheim_RaceSim.Controller;

public class Driver : IParticipant
{
    public string Name { get; set; }
    public int Points { get; set; }
    public IEquipment Equipment { get; set; }
    public TeamColors TeamColor { get; set; }

    public Driver(string name, int points, IEquipment equipment, TeamColors teamColor)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Points = points;
        Equipment = equipment ?? throw new ArgumentNullException(nameof(equipment));
        TeamColor = teamColor;
    }
}
