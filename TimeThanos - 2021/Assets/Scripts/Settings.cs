using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using Cinemachine;

public class Settings : MonoBehaviour
{
    public Slider slider;

    public AudioMixer music;

    public GameObject ConfirmSave;
    
    private Language lang;

    void Start() {
        float volume;

        lang = SaveSystem.GetInstance().lang;


        volume = PlayerPrefs.GetFloat("volume");

        if (volume > 0)
        {
            music.SetFloat("volume", volume);
        }

        slider.value = volume;


    }

    

    public void SetAudio(float volume) {
        //music.SetFloat("volume", volume);
        music.SetFloat("volume", Mathf.Log(volume) * 20);
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.Save();
    }

    public void ConfirmDeleteSave() {
        if(ConfirmSave.activeSelf) {
            ConfirmSave.SetActive(false);
        }
        else {
            ConfirmSave.SetActive(true);
        }
        
    }

    public void PortugueseOn() {
        lang.ChangeLanguage(Language.languagetype.PORTUGUESE);
        SaveSystem.GetInstance().SaveLanguage();
        SceneManager.LoadScene("Settings",LoadSceneMode.Single);
    }

    public void EnglishOn() {
        lang.ChangeLanguage(Language.languagetype.ENGLISH);
        SaveSystem.GetInstance().SaveLanguage();
        SceneManager.LoadScene("Settings",LoadSceneMode.Single);
    }     
}
