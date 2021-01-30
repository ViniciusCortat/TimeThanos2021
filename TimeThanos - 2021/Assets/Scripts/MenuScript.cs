using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game_Demo", LoadSceneMode.Single);
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("ResultadoFinal", LoadSceneMode.Single);
    }

    public void GoMenu() {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Settings() {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

    public void Customize() {
        SceneManager.LoadScene("Customizar", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Debug.Log("SAIR");
        Application.Quit();
    }
}
