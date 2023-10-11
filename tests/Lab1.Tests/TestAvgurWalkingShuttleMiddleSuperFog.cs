﻿using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestAvgurWalkingShuttleMiddleSuperFog
{
    private static readonly NumOfSuperFog _numOfSuperFog = new();
    public static bool IsFinishedRoute(int ship)
    {
        var route = new Route(false, 300, 300);
        return route.Step(ship, _numOfSuperFog.GetNumOfEnvironment(), 0, 0, 300);
    }

    [Theory]
    [InlineData(1, 5)]
    public void AllNumbersAreOddWithInlineData(int walkingShuttle, int avgur)
    {
        Assert.False(IsFinishedRoute(walkingShuttle));
        Assert.False(IsFinishedRoute(avgur));
    }
}