using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFeitico : MonoBehaviour
{
    public Slider speedSlider;
    public Slider timeSlider;

    private void Start()
    {
        Feiticos.Speed = 1.0f;
        Feiticos.SpeedMod = 1.0f;

        Feiticos.Time = 0.0f;
        Feiticos.TimeMod = 0.0f;
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
}
