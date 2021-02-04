using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager sharedInstance;
    public AudioSource ui1;
    public AudioSource ui2;
    public AudioSource timeOut;
    public AudioSource menu;
    public AudioSource tema;
    public GameObject moveWallPrefab;

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

    public void PlayMenu()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
 
         // Retrieve the name of this scene.
        string sceneName = currentScene.name;
 
        if (sceneName != "Menu") 
            return;
        
        if (!menu.isPlaying){
            menu.Play();
        }
    }

    public void StopMenu()
    {
        menu.Stop();
    }

    public void PlayTema()
    {
        StartCoroutine(WaitToPlay());
    }

    public void StopTema() 
    {
        tema.Stop();
    }

    public void PauseTema()
    {
        tema.Pause();
    }

    public void UnpauseTema()
    {
        tema.UnPause();
    }


    IEnumerator WaitToPlay()
    {
        yield return new WaitForSeconds(3.0f);
        tema.Play();
    }

    public void PlayMoveWall(GameObject obj, float duration)
    {
       GameObject newObj = Instantiate(moveWallPrefab, obj.transform.position, Quaternion.identity);
       newObj.GetComponent<AudioSource>().Play();
       StartCoroutine(StopMoveWall(newObj, duration));
    }

    private IEnumerator StopMoveWall(GameObject obj, float duration)
    {
        yield return new WaitForSeconds(duration);
        obj.GetComponent<AudioSource>().Stop();
        Destroy(obj);
    }

}
