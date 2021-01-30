using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("hugo_test", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Debug.Log("SAIR");
        Application.Quit();
    }
}
