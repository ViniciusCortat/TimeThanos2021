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
    public AudioSource puff;
    public AudioSource menu;
    public AudioSource tema;
    public AudioSource ui3;
    public GameObject moveWallPrefab;
    private bool gameOn = false;

    private GameObject wallObj = null;
    private float wallDist = 0;
    private float wallDuration = 0;

    public AudioMixerSnapshot wallFadeOut;
    public AudioMixerSnapshot normal;

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
    public void PlayUISound()
    {
        int i = (int)UnityEngine.Random.Range(0, 2);
        if (i == 0)
            ui1.Play();
        else
            ui2.Play();
    }

    public void PlayCheckBoxUI()
    {
        ui3.Play();
    }

    public void PlayTimeOut()
    {
        timeOut.Play();
        StartCoroutine(WaitToPlayPuff());
    }

    IEnumerator WaitToPlayPuff()
    {
        yield return new WaitForSeconds(1.1f);
        puff.Play();
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
        gameOn = true;
        StartCoroutine(WaitToPlay());
    }

    public void StopTema() 
    {
        gameOn = false;
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

    public void RequestMoveWall(GameObject obj, float duration)
    {
        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            float dist = Vector3.Distance(player.transform.position, obj.transform.position);
            //Debug.Log("Distance to other: " + dist);
            if (wallObj == null)
            {
                wallObj = obj;
                wallDuration = duration;
                wallDist = dist;
            }
            else if (dist < wallDist)
            {
                wallObj = obj;
                wallDuration = duration;
                wallDist = dist;
            }
        }
        
    }

    void FixedUpdate()
    {
        if (wallObj != null)
        {
            PlayMoveWall(wallObj, wallDuration);
            wallObj = null;
            wallDuration = 0.0f;
            wallDist = 0.0f;
        }
    }

    private void PlayMoveWall(GameObject obj, float duration)
    {
       GameObject newObj = Instantiate(moveWallPrefab, obj.transform.position, Quaternion.identity);
       newObj.GetComponent<AudioSource>().Play();
       StartCoroutine(StopMoveWall(newObj, duration));
       wallFadeOut.TransitionTo(duration);
    }

    private IEnumerator StopMoveWall(GameObject obj, float duration)
    {
        yield return new WaitForSeconds(duration);
        normal.TransitionTo(0.0f);
        if (gameOn)
        {
            if (obj != null)
            {
                obj.GetComponent<AudioSource>().Stop();
                Destroy(obj);
            }
        }
    }

}
