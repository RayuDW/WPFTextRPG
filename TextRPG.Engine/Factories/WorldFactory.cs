using TextRPG.Engine.Models;

namespace TextRPG.Engine.Factories;

internal class WorldFactory
{
    internal World CreateWorld()
    {
        World newWorld = new World();

        newWorld.AddLocation(-2, -1, "Farmer's Field",
            "Rows of corn growing here. But will they also satisfy the giant creatures beneath us?",
            "/TextRPG.Engine;component/Images/FarmFields.png");

        newWorld.AddLocation(-1, -1, "Farmer's House",
            "This is the house of your neighbor, Farmer Ted.",
            "/TextRPG.Engine;component/Images/Farmhouse.png");

        newWorld.AddLocation(0, -1, "Home",
            "This is your home. Go and cuddle someone!",
            "/TextRPG.Engine;component/Images/Home.png");

        newWorld.AddLocation(-1, 0, "Trading Shop",
            "The shop of Susan, the trader.",
            "/TextRPG.Engine;component/Images/Trader.png");

        newWorld.AddLocation(0, 0, "Town square",
            "You see a fountain here.",
            "/TextRPG.Engine;component/Images/TownSquare.png");

        newWorld.AddLocation(1, 0, "Town Gate",
            "There is a gate here, protecting the town from giant spiders.",
            "/TextRPG.Engine;component/Images/TownGate.png");

        newWorld.AddLocation(2, 0, "Spider Forest",
            "The trees in this forest are covered with spider webs.",
            "/TextRPG.Engine;component/Images/SpiderForest.png");

        newWorld.AddLocation(0, 1, "Herbalist's hut",
            "You see a small hut, with plants drying from the roof.",
            "/TextRPG.Engine;component/Images/HerbalistsHut.png");

        newWorld.AddLocation(0, 2, "Herbalist's garden",
            "There are many plants here, with snakes hiding behind them.",
            "/TextRPG.Engine;component/Images/HerbalistsGarden.png");

        return newWorld;
    }
}