using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControllerMae : MonoBehaviour
{
    public GameObject player;
    private Animator anim;
    public ParticleSystem particle;

    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space")){
            StartCoroutine(teleport());
        }
        
    }

    IEnumerator teleport()
    {
        particle.Play();    
        yield return new WaitForSeconds(0.3f);
        player.SetActive(true);
        anim.SetTrigger("teleport");
    }


}
