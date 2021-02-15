using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsAudio : MonoBehaviour
{
    private static SettingsAudio instance;

    void Start()
    {
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this) {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name != "Settings") {
            Destroy(gameObject);
        }
    }
}
