using System.Collections.Generic;

namespace TextRPG.Engine.Models;

public class World
{
    private List<Location> locations = new List<Location>();

    internal void AddLocation(int xCord, int yCord, string name, string description, string imageName)
    {
        Location loc = new Location();
        loc.XCoordinate = xCord;
        loc.YCoordinate = yCord;
        loc.Name = name;
        loc.Description = description;
        loc.ImageName = imageName;
        
        locations.Add(loc);
    }

    public Location LocationAt(int xCoordinate, int yCoordinate)
    {
        foreach (Location loc in locations)
        {
            if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
            {
                return loc;
            }
        }
        
        return null;
    }
}