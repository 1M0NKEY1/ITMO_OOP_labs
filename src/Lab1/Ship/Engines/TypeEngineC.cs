﻿using Itmo.ObjectOrientedProgramming.Lab1.Ship.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;

public class TypeEngineC : Engine
{
    public TypeEngineC(int fuel)
    {
        CapacityPlasmFuel = fuel;
    }

    public override int Duration(int astronomicUnits, object size)
    {
        CapacityPlasmFuel = StartEngine();
        for (int i = 1; i <= astronomicUnits; i++)
        {
            if (size is Small)
            {
                CapacityPlasmFuel -= i;
            }
            else if (size is Middle)
            {
                ++i;
                CapacityPlasmFuel -= i;
            }
            else if (size is Big)
            {
                ++i;
                ++i;
                CapacityPlasmFuel -= i;
            }
        }

        return CapacityPlasmFuel;
    }
}