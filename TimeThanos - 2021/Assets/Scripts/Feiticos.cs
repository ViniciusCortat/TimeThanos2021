using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Feiticos
{
    private static float speed, time;
    private static float speedMod, timeMod;

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
}
