using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Tooltip("Tempo em segundos")]
    public float timeRemaining = 10;
    
    public Text timerText;
    private bool timeStopped = false;

    void Update() {

        if (timeRemaining > 0) 
            timeRemaining -= Time.deltaTime;
        else {
            timeRemaining = 0;
            timeStopped = true;
            SceneManager.LoadScene("ResultadoFinal");
        }

        DisplayTime(timeRemaining);
    }

    void DisplayTime(float time) {

        if (!timeStopped)
            time += 1;

        float min = Mathf.FloorToInt(time / 60);
        float sec = Mathf.FloorToInt(time % 60);

        timerText.text = string.Format("{00:00}:{1:00}", min, sec);
    }
}