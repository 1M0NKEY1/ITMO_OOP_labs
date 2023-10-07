﻿using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SimpleSpace : Environment
{
    public SimpleSpace(int countOfAsteroids, int countOfMeteorites)
    {
        ClassOfObstacle1 = (int)Obstacles.Asteroids;
        ClassOfObstacle2 = (int)Obstacles.Meteorites;
        CountOfAsteroids = countOfAsteroids;
        CountOfMeteorites = countOfMeteorites;
    }

    public override bool Conditions(int engineType)
    {
        return engineType is (int)SelectEngine.TypeEngineC or (int)SelectEngine.TypeEngineE;
    }

    public override bool ExtraConditions(int engineJumpType)
    {
        return true;
    }
}