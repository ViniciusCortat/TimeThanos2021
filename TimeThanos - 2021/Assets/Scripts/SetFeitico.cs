using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFeitico : MonoBehaviour
{
    public Slider speedSlider, timeSlider, wallSlider, lossSlider, timeUISlider, scoreUISlider, delaySlider, chanceSlider;

    private void Start()
    {
        Feiticos.Speed = 1.0f;
        Feiticos.SpeedMod = 1.0f;

        Feiticos.Time = 0.0f;
        Feiticos.TimeMod = 1.0f;

        Feiticos.Wall = 0.0f;
        Feiticos.WallMod = 1.0f;

        Feiticos.Chance = 0;
        Feiticos.ChanceMod = 1.0f;

        Feiticos.Loses = false;
        Feiticos.LosesMod = 1.0f;

        Feiticos.TimeUI = false;
        Feiticos.TimeUIMod = 1.0f;

        Feiticos.ScoreUI = false;
        Feiticos.ScoreUIMod = 1.0f;

        Feiticos.Delay = false;
        Feiticos.DelayMod = 1.0f;
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
        if (timeSlider.value == 1.0f)
        {
            Feiticos.Time = -20.0f;
            Feiticos.TimeMod = 1.2f;
        }
        else
        {
            Feiticos.Time = 0.0f;
            Feiticos.TimeMod = 1.0f;
        }
    }

    public void SetWall()
    {
        if(wallSlider.value == 1.0f)
        {
            Feiticos.Wall = 4.0f;
            Feiticos.WallMod = 1.2f;
        }
        else 
        {
            Feiticos.Wall = 0.0f;
            Feiticos.WallMod = 1.0f;
        }
    }

    public void SetLoss()
    {
        if(lossSlider.value == 1.0f)
        {
            Feiticos.Loses = true;
            Feiticos.LosesMod = 1.2f;
        }
        else
        {
            Feiticos.Loses = false;
            Feiticos.LosesMod = 1.0f;
        }
    }

    public void SetTimeUI()
    {
        if (timeUISlider.value == 1.0f)
        {
            Feiticos.TimeUI = true;
            Feiticos.TimeUIMod = 1.3f;
        }
        else
        {
            Feiticos.TimeUI = false;
            Feiticos.TimeUIMod = 1.0f;
        }
    }

    public void SetScoreUI()
    {
        if (scoreUISlider.value == 1.0f)
        {
            Feiticos.ScoreUI = true;
            Feiticos.ScoreUIMod = 1.1f;
        }
        else
        {
            Feiticos.ScoreUI = false;
            Feiticos.ScoreUIMod = 1.0f;
        }
    }

    public void SetDelay()
    {
        if(delaySlider.value == 1.0f)
        {
            Feiticos.Delay = true;
            Feiticos.DelayMod = 1.4f;
        }
        else
        {
            Feiticos.Delay = false;
            Feiticos.DelayMod = 1.0f;
        }
    }

    public void SetChance()
    {
        if(chanceSlider.value == 1.0f)
        {
            Feiticos.Chance = 15;
            Feiticos.ChanceMod = 1.6f;
        }
        else
        {
            Feiticos.Chance = 0;
            Feiticos.ChanceMod = 1.0f;
        }
    }
}
