using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFeitico : MonoBehaviour
{
    public Toggle speedToggle, timeToggle, wallToggle, lossToggle, timeUIToggle, scoreUIToggle, delayToggle, chanceToggle;

    /*
     * speed = Slow
     * time = Time Warp
     * wall = Petrificus totalus
     * loss = Curse of Losses
     * timeUI = Timeless confusion
     * scoreUI = Curse of the unknown
     * delay = chaneller
     * chance = Illusion curse
     */

    private void Start()
    {
        Feiticos.Speed = 1.0f;
        Feiticos.SpeedMod = 0.0f;

        Feiticos.Time = 0.0f;
        Feiticos.TimeMod = 0.0f;

        Feiticos.Wall = 0.0f;
        Feiticos.WallMod = 0.0f;

        Feiticos.Chance = 0;
        Feiticos.ChanceMod = 0.0f;

        Feiticos.Loses = false;
        Feiticos.LosesMod = 0.0f;

        Feiticos.TimeUI = false;
        Feiticos.TimeUIMod = 0.0f;

        Feiticos.ScoreUI = false;
        Feiticos.ScoreUIMod = 0.0f;

        Feiticos.Delay = false;
        Feiticos.DelayMod = 0.0f;
    }

    private void Update()
    {
        if(speedToggle.isOn == true)
        {
            
        }
    }
    public void SetSpeed()
    {
        AudioManager.sharedInstance.PlayCheckBoxUI();
        if (speedToggle.isOn == true)
        {
            Feiticos.Speed = 0.8f;
            Feiticos.SpeedMod = 0.2f;
        }
        else
        {
            Feiticos.Speed = 1.0f;
            Feiticos.SpeedMod = 0.0f;
        }
    }

    public void SetTime()
    {
        AudioManager.sharedInstance.PlayCheckBoxUI();
        if (timeToggle.isOn == true)
        {
            Feiticos.Time = -60.0f;
            Feiticos.TimeMod = 0.2f;
        }
        else
        {
            Feiticos.Time = 0.0f;
            Feiticos.TimeMod = 0.0f;
        }
    }

    public void SetWall()
    {
        AudioManager.sharedInstance.PlayCheckBoxUI();
        if (wallToggle.isOn == true)
        {
            Feiticos.Wall = 8.0f;
            Feiticos.WallMod = 0.1f;
        }
        else
        {
            Feiticos.Wall = 0.0f;
            Feiticos.WallMod = 0.0f;
        }
    }

    public void SetLoss()
    {
        AudioManager.sharedInstance.PlayCheckBoxUI();
        if (lossToggle.isOn == true)
        {
            Feiticos.Loses = true;
            Feiticos.LosesMod = 0.2f;
        }
        else
        {
            Feiticos.Loses = false;
            Feiticos.LosesMod = 0.0f;
        }
    }

    public void SetTimeUI()
    {
        AudioManager.sharedInstance.PlayCheckBoxUI();
        if (timeUIToggle.isOn == true)
        {
            Feiticos.TimeUI = true;
            Feiticos.TimeUIMod = 0.1f;
        }
        else
        {
            Feiticos.TimeUI = false;
            Feiticos.TimeUIMod = 0.0f;
        }
    }

    public void SetScoreUI()
    {
        AudioManager.sharedInstance.PlayCheckBoxUI();
        if (scoreUIToggle.isOn == true)
        {
            Feiticos.ScoreUI = true;
            Feiticos.ScoreUIMod = 0.1f;
        }
        else
        {
            Feiticos.ScoreUI = false;
            Feiticos.ScoreUIMod = 0.0f;
        }
    }

    public void SetDelay()
    {
        AudioManager.sharedInstance.PlayCheckBoxUI();
        if (delayToggle.isOn == true)
        {
            Feiticos.Delay = true;
            Feiticos.DelayMod = 0.2f;
        }
        else
        {
            Feiticos.Delay = false;
            Feiticos.DelayMod = 0.0f;
        }
    }

    public void SetChance()
    {
        AudioManager.sharedInstance.PlayCheckBoxUI();
        if (chanceToggle.isOn == true)
        {
            Feiticos.Chance = 20;
            Feiticos.ChanceMod = 0.2f;
        }
        else
        {
            Feiticos.Chance = 0;
            Feiticos.ChanceMod = 0.0f;
        }
    }
}
