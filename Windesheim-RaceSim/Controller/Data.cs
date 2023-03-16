﻿using Model;

namespace Windesheim_RaceSim.Controller;

public static class Data
{
    public static Competition? Competition { get; set; }
    public static Race? CurrentRace { get; set; }
    
    public static void Initialize(Competition competition)
    {
        CurrentRace = CurrentRace;
        AddParticpants();
        AddTracks();
    }

    public static void AddParticpants()
    {
        
        Competition.Participants.Add(
            new Driver("Driver1", 10, 
                new Car(10,20,40, false), TeamColors.Blue));
        Competition.Participants.Add(
            new Driver("Driver2", 10, 
                new Car(10,20,40, false), TeamColors.Green));
        Competition.Participants.Add(
            new Driver("Driver3", 10, 
                new Car(10,20,40, false), TeamColors.Grey));
        Competition.Participants.Add(
            new Driver("Driver4", 10, 
                new Car(10,20,40, false), TeamColors.Red));
        Competition.Participants.Add(
            new Driver("Driver5", 10, 
                new Car(10,20,40, false), TeamColors.Yellow));
    }

    public static void AddTracks()
    {
        Competition.Tracks.Enqueue(
            new Track(
                "Vierkant", 
                new []
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

    public static void NextRace()
    {
        Track currentTrack = Competition?.NextTrack() ?? throw new ArgumentNullException();
        
        
    }
}
