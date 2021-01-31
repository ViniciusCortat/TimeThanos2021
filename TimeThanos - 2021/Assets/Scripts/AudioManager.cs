using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager sharedInstance;
    public AudioSource ui1;
    public AudioSource ui2;
    public AudioSource timeOut;

    //private AudioSource 

    void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void PlayUISound()
    {
        int i = (int)UnityEngine.Random.Range(0, 2);
        if (i == 0)
            ui1.Play();
        else
            ui2.Play();
    }

    public void PlayTimeOut()
    {
        timeOut.Play();
    }


}
