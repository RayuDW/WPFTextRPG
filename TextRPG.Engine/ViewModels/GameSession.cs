using TextRPG.Engine.Models;

namespace TextRPG.Engine.ViewModels;

public class GameSession
{
    public Player CurrentPlayer { get; set; }
    public Location CurrentLocation { get; set; }

    public GameSession()
    {
        CurrentPlayer = new Player
        {
            Name = "Rayu",
            CharacterClass = "Fighter",
            HitPoints = 10,
            Gold = 100000,
            ExperiencePoints = 0,
            Level = 1
        };

        CurrentLocation = new Location
        {
            XCoordinate = 0,
            YCoordinate = -1,
            Name = "Home",
            Description = "This is your home! Go and cuddle someone!",
            ImageName = "/TextRPG.Engine;component/Images/Home.png"
        };
    }
}