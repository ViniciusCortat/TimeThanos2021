using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Feiticos
{
    private static float speed, time, wall, chance;
    private static bool loses, timeUI, scoreUI, delay;
    private static float speedMod, timeMod, wallMod, losesMod, timeUIMod, scoreUIMod, delayMod, chanceMod;

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

    public static bool Loses
    {
        get
        {
            return loses;
        }
        set
        {
            loses = value;
        }
    }

    public static float LosesMod
    {
        get
        {
            return losesMod;
        }
        set
        {
            losesMod = value;
        }
    }

    public static bool TimeUI
    {
        get
        {
            return timeUI;
        }
        set
        {
            timeUI = value;
        }
    }

    public static float TimeUIMod
    {
        get
        {
            return timeUIMod;
        }
        set
        {
            timeUIMod = value;
        }
    }

    public static bool ScoreUI
    {
        get
        {
            return scoreUI;
        }
        set
        {
            scoreUI = value;
        }
    }

    public static float ScoreUIMod
    {
        get
        {
            return scoreUIMod;
        }
        set
        {
            scoreUIMod = value;
        }
    }

    public static bool Delay
    {
        get
        {
            return delay;
        }
        set
        {
            delay = value;
        }
    }

    public static float DelayMod
    {
        get
        {
            return delayMod;
        }
        set
        {
            delayMod = value;
        }
    }

    public static float Chance
    {
        get
        {
            return chance;
        }
        set
        {
            chance = value;
        }
    }

    public static float ChanceMod
    {
        get
        {
            return chanceMod;
        }
        set
        {
            chanceMod = value;
        }
    }
}
