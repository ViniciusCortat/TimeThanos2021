using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public Slider slider;

    public AudioMixer music;

    void Start() {
        float volume;

        volume = PlayerPrefs.GetFloat("volume");

        music.SetFloat("volume", volume);

        slider.value = volume;
    }

    public void SetAudio(float volume) {
        //music.SetFloat("volume", volume);
        music.SetFloat("volume", Mathf.Log(volume) * 20);
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.Save();
    }
    
}
