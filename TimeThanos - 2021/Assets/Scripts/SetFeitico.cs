using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFeitico : MonoBehaviour
{
    public Slider speedSlider, timeSlider, wallSlider;

    private void Start()
    {
        Feiticos.Speed = 1.0f;
        Feiticos.SpeedMod = 1.0f;

        Feiticos.Time = 0.0f;
        Feiticos.TimeMod = 1.0f;

        Feiticos.Wall = 0.0f;
        Feiticos.WallMod = 1.0f;
    }
    public void SetSpeed()
    {
        if (speedSlider.value == 1.0f)
        {
            Feiticos.Speed = 0.5f;
            Feiticos.SpeedMod = 1.5f;
        }
        else
        {
            Feiticos.Speed = 1.0f;
            Feiticos.SpeedMod = 1.0f;
        }
    }

    public void SetTime()
    {
        if (timeSlider.value == 3.0f)
        {
            Feiticos.Time = -30.0f;
            Feiticos.TimeMod = 1.3f;
        }
        else if (timeSlider.value == 2.0f)
        {
            Feiticos.Time = -20.0f;
            Feiticos.TimeMod = 1.2f;
        }
        else if (timeSlider.value == 1.0f)
        {
            Feiticos.Time = -10.0f;
            Feiticos.TimeMod = 1.1f;
        }
        else
        {
            Feiticos.Time = 0.0f;
            Feiticos.TimeMod = 1.0f;
        }
    }

    public void SetWall()
    {
        if(wallSlider.value == 3.0f)
        {
            Feiticos.Wall = 6.0f;
            Feiticos.WallMod = 1.3f;
        }
        else if(wallSlider.value == 1.0f)
        {
            Feiticos.Wall = 4.0f;
            Feiticos.WallMod = 1.2f;
        }
        else if (wallSlider.value == 1.0f)
        {
            Feiticos.Wall = 2.0f;
            Feiticos.WallMod = 1.1f;
        }
        else 
        {
            Feiticos.Wall = 0.0f;
            Feiticos.WallMod = 1.0f;
        }
    }
}
