﻿using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;

public class TypeEngineE : Engine
{
    public TypeEngineE(int fuel)
    {
        CapacityPlasmFuel = fuel;
    }

    public override int Duration(int astronomicUnits, int size)
    {
        CapacityPlasmFuel = StartEngine();
        for (int i = 1; i <= astronomicUnits; i *= 2)
        {
            if (CapacityPlasmFuel <= 0)
            {
                throw new CustomExceptions("Plasm fuel tank is empty");
            }

            switch (size)
            {
                case (int)SelectSize.Small:
                    CapacityPlasmFuel -= i;
                    break;
                case (int)SelectSize.Middle:
                    ++i;
                    CapacityPlasmFuel -= i;
                    break;
                case (int)SelectSize.Big:
                    ++i; ++i;
                    CapacityPlasmFuel -= i;
                    break;
                default:
                    throw new CustomExceptions("No such type of size");
            }
        }

        return CapacityPlasmFuel;
    }
}