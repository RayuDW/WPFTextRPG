using TextRPG.Engine.Factories;
using TextRPG.Engine.Models;

namespace TextRPG.Engine.ViewModels;

public class GameSession
{
    public Player CurrentPlayer { get; set; }
    public Location CurrentLocation { get; set; }
    
    public World CurrentWorld { get; set; }

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

        WorldFactory factory = new WorldFactory();
        CurrentWorld = factory.CreateWorld();

        CurrentLocation = CurrentWorld.LocationAt(0, -1);
    }
}