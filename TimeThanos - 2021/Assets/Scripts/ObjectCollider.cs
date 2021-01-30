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
            }
            else
            {
                StartCoroutine(Colect(1.0f));
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
        PlaySound();
        Debug.Log("oi");
        Destroy(this.gameObject);
    }

    private void PlaySound(){
        foreach (Transform child in transform.parent){
            if (child.name == "audio"){
                child.GetComponent<AudioSource>().Play();
            }
        }
    }
}
