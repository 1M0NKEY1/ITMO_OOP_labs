﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class NeutrinoFog : Environment
{
    private readonly IList<Obstacles> _obstacles = new List<Obstacles>();

    public NeutrinoFog(IList<Obstacles> classOfObstacle)
    {
        foreach (Obstacles obstacle in classOfObstacle)
        {
            if (obstacle is NeutrinoFogObstacles)
            {
                _obstacles.Add(obstacle);
            }
        }
    }

    public override bool Stage(StarShip? ship, int astronomicUnits)
    {
        if (ship == null) return false;

        if (ship.ClassOfEngine is not TypeEngineE) return false;

        if (ship.ClassOfDeflectors != null && ship.ClassOfDeflectors.DefenceTurnOff())
        {
            if (ship.ClassOfHull != null && ship.ClassOfHull.Defence())
            {
                ship.Destroy();
                if (ship.Destroyed) return false;

                for (int i = 0; i < _obstacles.Count; i++)
                {
                    ship.ClassOfHull?.Damage(_obstacles.Count, _obstacles, i);
                }
            }
        }

        for (int i = 0; i < _obstacles.Count; i++)
        {
            ship.ClassOfDeflectors?.Damage(_obstacles.Count, _obstacles, i);
        }

        if (ship.ClassOfDeflectors != null && ship.ClassOfDeflectors.DefenceTurnOff()) return false;

        if (ship.ClassOfSize != null) ship.ClassOfEngine?.Duration(astronomicUnits, ship.ClassOfSize);

        return true;
    }
}