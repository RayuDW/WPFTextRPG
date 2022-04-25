using TextRPG.Engine.Models;

namespace TextRPG.Engine.ViewModels;

public class GameSession
{
    private Player CurrentPlayer { get; set; }

    public GameSession()
    {
        CurrentPlayer = new Player
        {
            Name = "Rayu",
            Gold = 100000
        };
    }
}