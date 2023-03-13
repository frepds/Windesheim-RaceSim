namespace Windesheim_RaceSim.Controller;

public static class Data
{
    private static Competition Competition;

    public static void Initialize(Competition competition)
    {
        Competition = competition;
    }

    public static void Aanmaken()
    {
        Competition.Participants.Add(new Driver("Driver1", new Car(19, 10, 20, false), IParticipant.TeamColors.Red));
        Competition.Participants.Add(new Driver("Driver2", new Car(18, 10, 19, false), IParticipant.TeamColors.Green));
        Competition.Participants.Add(new Driver("Driver3",new Car(16, 10, 17, false), IParticipant.TeamColors.Blue));
        Competition.Participants.Add(new Driver("Driver4",new Car(20, 10, 14, false), IParticipant.TeamColors.Yellow));
        Competition.Participants.Add(new Driver("Driver5",new Car(20, 10, 14, false), IParticipant.TeamColors.Yellow));
    }
    
}