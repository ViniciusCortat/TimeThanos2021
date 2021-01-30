using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Feiticos
{
    private static float speed, time, wall;
    private static float speedMod, timeMod, wallMod;

    public static float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }

    public static float SpeedMod
    {
        get
        {
            return speedMod;
        }
        set
        {
            speedMod = value;
        }
    }

    public static float Time
    {
        get
        {
            return time;
        }
        set
        {
            time = value;
        }
    }

    public static float TimeMod
    {
        get
        {
            return timeMod;
        }
        set
        {
            timeMod = value;
        }
    }

    public static float Wall
    {
        get
        {
            return wall;
        }
        set
        {
            wall = value;
        }
    }

    public static float WallMod
    {
        get
        {
            return wallMod;
        }
        set
        {
            wallMod = value;
        }
    }
}
