using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text pontosText;

    private PointSystem PS;

    private Achieviments Achiev;

    public string pauseKey;
    private bool paused;

    public GameObject PauseMenuUI;

    void Start()
    {
        PS = PointSystem.Instance;
        Achiev = SaveSystem.GetInstance().Achiev;

        if(Feiticos.ScoreUI == true)
        {
            pontosText.enabled = false;
        }
        else
        {
            pontosText.enabled = true;
        }
    }

    
    void Update()
    {
        pontosText.text = PS.pontos.ToString();

        if (Input.GetKeyDown(pauseKey) || Input.GetButtonDown("Pause"))
        {
            if (paused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    private void ResumeGame()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    private void PauseGame()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void TriggerAchieviment(string title) {
        int i = Achiev.Achiev.IndexOf(title);
        if(Achiev.CheckCompletion(i)) return;
        Achiev.GiveAchiev(i);
    }
}
