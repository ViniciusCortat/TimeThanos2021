using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{
    public int pontos;
    private PointSystem PS;

    void Start() 
    {
        PS = PointSystem.Instance;
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player")) 
        {
            if(Feiticos.Delay == false)
            {
                StartCoroutine(Colect(0.0f));
                other.GetComponentInChildren<Animator>().SetTrigger("pick");
            }
            else
            {
                StartCoroutine(Colect(2.0f));
            }
        }
    }

    private IEnumerator Colect(float delay)
    {
        yield return new WaitForSeconds(delay);

        float rng = Random.Range(0, 100);

        if(rng > Feiticos.Chance)
        {
            PS.GivePonto(pontos);
        }
        
        transform.GetChild(1).gameObject.SetActive(false);
        transform.gameObject.GetComponent<BoxCollider>().enabled = false;
        PlaySound();
        
        //Destroy(this.gameObject);
    }

    private void PlaySound(){
        Transform audio = transform.Find("audio");
        audio.GetComponent<AudioSource>().Play();

    }
}
