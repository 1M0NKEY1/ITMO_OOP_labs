﻿namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SpaceWhales : Obstacles
{
    private int SpaceWhale { get; set; }

    public override void SetNumOfObstacle()
    {
        SpaceWhale = 3;
    }

    public override int GetNumOfObstacle()
    {
        SetNumOfObstacle();
        return SpaceWhale;
    }
}