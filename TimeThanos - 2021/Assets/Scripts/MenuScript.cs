using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private PointSystem PS;

    private void Start()
    {
        PS = PointSystem.Instance;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game_Demo", LoadSceneMode.Single);
        PS.ResetPonto();
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("ResultadoFinal", LoadSceneMode.Single);
    }

    public void GoMenu() {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        Time.timeScale = 1f;
    }

    public void Settings() {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

    public void Customize() {
        SceneManager.LoadScene("Customizar", LoadSceneMode.Single);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        Time.timeScale = 1f;
        PS.ResetPonto();
    }

    public void QuitGame()
    {
        Debug.Log("SAIR");
        Application.Quit();
    }

    public void NewGame() {
        SaveSystem.GetInstance().NewGame();
    }
}
