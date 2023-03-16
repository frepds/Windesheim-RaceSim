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
        // Original
        // Competition.Participants.Add(
        //     new Driver("Driver1", new Random().Next(1,20),
        //         new Car(10, 20, 40, false), TeamColors.Blue));
        
        var r = new Random();
        Competition.Participants.Add(
            new Driver("Driver1", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver2", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver3", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver4", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver5", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        
        //Extra
        Competition.Participants.Add(
            new Driver("Driver6", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver7", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver8", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver9", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver10", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver11", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver12", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver13", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver14", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver15", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver16", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver17", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver18", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver19", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
        Competition.Participants.Add(
            new Driver("Driver20", r.Next(1,20),
                new Car(r.Next(1,11), r.Next(1,100), r.Next(1,100), false), RandomKleur()));
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
