using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class Cutscene : MonoBehaviour
{
    public VideoClip video;
    public string pauseKey;

    private void Awake()
    {
        StartCoroutine(WaitVideoOver());
    }

    private void Update()
    {
        if(Input.GetKeyDown(pauseKey) || Input.GetButtonDown("Pause"))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
    private IEnumerator WaitVideoOver()
    {
        yield return new WaitForSeconds((float)video.length);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

}