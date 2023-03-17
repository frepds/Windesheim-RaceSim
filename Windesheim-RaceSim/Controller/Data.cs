using Model;
namespace Windesheim_RaceSim.Controller;

public static class Data
{
    public static Competition? Competition { get; set; }
    public static Race? CurrentRace { get; set; }
    

    public static void Initialize(Competition competition)
    {
        Competition = competition;
        AddParticpants();
        AddTracks();
    }

    private static void AddParticpants()
    {
        for (var i = 1; i < 100; i++)
        {
            Competition.Participants.Add(
                new Driver($"Driver{i}", MiddlePoints(),
                    new Car(LowerPoints(), HigherPoints(), HigherPoints(), RandomBool()), RandomKleur()));
        }
    }

    private static void AddTracks()
    {
        Competition?.Tracks.Enqueue(
            new Track(
                "Vierkant1",
                new[]
                {
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Straight,
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Finish
                })
        );
        Competition?.Tracks.Enqueue(
            new Track(
                "Vierkant2",
                new[]
                {
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Straight,
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Finish
                })
        );
        Competition?.Tracks.Enqueue(
            new Track(
                "Vierkant3",
                new[]
                {
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Straight,
                    SectionTypes.Straight,
                    SectionTypes.RightCorner,
                    SectionTypes.Finish
                })
        );
    }

    private static bool RandomBool()
    {
        var r = new Random();
        var i = r.Next(0, 2);
        return i == 0;
    }

    private static int LowerPoints()
    {
        var r = new Random();
        return r.Next(1, 11);
    }
    
    private static int MiddlePoints()
    {
        var r = new Random();
        return r.Next(1, 20);
    }
    
    private static int HigherPoints()
    {
        var r = new Random();
        return r.Next(1, 100);
    }
    
    
    private static TeamColors RandomKleur()
    {
        var r = new Random();
        var i = r.Next(0, 5);
        const TeamColors T = TeamColors.Red;

        return i switch
        {
            0 => T,
            1 => TeamColors.Green,
            2 => TeamColors.Yellow,
            3 => TeamColors.Grey,
            4 => TeamColors.Blue
        };
    }

    public static void NextRace()
    {
        var nextTrack = Competition?.NextTrack();
        if (Competition != null)
        {
            CurrentRace = new Race(nextTrack, Competition.Participants);
        }
    }
}
