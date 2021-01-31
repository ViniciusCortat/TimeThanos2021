using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animControllerMae : MonoBehaviour
{
    public GameObject player;
    private Animator anim;
    public ParticleSystem particle;

    void Start()
    {
        anim = player.GetComponent<Animator>();
        StartCoroutine(teleport());
    }

    /*void Update()
    {
        if (Input.GetKeyDown("space")){
            StartCoroutine(teleport());
        }
        
    }*/

    IEnumerator teleport()
    {
        yield return new WaitForSeconds(1);
        particle.Play();    
        yield return new WaitForSeconds(0.3f);
        player.SetActive(true);
        anim.SetTrigger("teleport");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("ResultadoFinal");
    }


}
