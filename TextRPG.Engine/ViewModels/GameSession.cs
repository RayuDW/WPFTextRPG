using TextRPG.Engine.Models;

namespace TextRPG.Engine.ViewModels;

public class GameSession
{
    public Player CurrentPlayer { get; set; }

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
    }
}