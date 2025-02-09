﻿using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;

public abstract class SSDBase : IComponent
{
    public abstract string? Name { get; }
    public abstract InputTypes? InputType { get; }
    public abstract int SSDMemory { get; }
    public abstract int MaxSpeed { get; }
    public abstract int SSDPower { get; }
}