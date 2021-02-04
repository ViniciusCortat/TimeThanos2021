using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI pontosTextTMP;

    private PointSystem PS;

    private Achieviments Achiev;

    public string pauseKey;
    private bool paused;

    public GameObject PauseMenuUI;

    public Material Cab;
    public Material Capa;
    public Material Chapeu;
    public Material Oculos;
    public Material Olho;
    public Material Pele;

    void Start()
    {
        PS = PointSystem.Instance;
        Achiev = SaveSystem.GetInstance().Achiev;

        if(Feiticos.ScoreUI == true)
        {
            pontosTextTMP.enabled = false;
        }
        else
        {
            pontosTextTMP.enabled = true;
        }

        Cab = ChoosePart.matCab;
        Capa = ChoosePart.matCapa;
        Chapeu = ChoosePart.matChapeu;
        Oculos = ChoosePart.matOculos;
        Olho = ChoosePart.matOlho;
        Pele = ChoosePart.matPele;
    }

    
    void Update()
    {
        pontosTextTMP.text = PS.pontos.ToString();

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
        AudioManager.sharedInstance.UnpauseTema();
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    private void PauseGame()
    {
        AudioManager.sharedInstance.PauseTema();
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
