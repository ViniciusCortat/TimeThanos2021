using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using Cinemachine;

public class Settings : MonoBehaviour
{
    public Slider slider;

    public AudioMixer music;

    public float defaultSensibilityValue = 400;
    public Text sensibilityValue;
    public CinemachineFreeLook cinemachine;
    public Slider sensibilitySlider;
    public GameObject ConfirmSave;
    
    private Language lang;

    void Start() {
        float volume;
        float sensibility;

        lang = SaveSystem.GetInstance().lang;


        volume = PlayerPrefs.GetFloat("volume");
        sensibility = PlayerPrefs.GetFloat("sensibility");

        if(sensibility == 0.0f)
        {
            sensibility = defaultSensibilityValue;
        }

        if (volume > 0)
        {
            music.SetFloat("volume", volume);
        }

        slider.value = volume;


        if (cinemachine != null)
        {
            cinemachine.m_XAxis.m_MaxSpeed = sensibility;
            sensibilityValue.text = sensibility.ToString("F2");
            sensibilitySlider.value = sensibility;
        }
    }

    public void SetSensibilityValue()
    {
        sensibilityValue.text = (sensibilitySlider.value / 100).ToString("F2");
        cinemachine.m_XAxis.m_MaxSpeed = sensibilitySlider.value;
        PlayerPrefs.SetFloat("sensibility", sensibilitySlider.value);
        PlayerPrefs.Save();
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
    }

    public void EnglishOn() {
        lang.ChangeLanguage(Language.languagetype.ENGLISH);
        SaveSystem.GetInstance().SaveLanguage();
    }     
}
