using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{
    public int pontos;
    private PointSystem PS;
    private bool colided;
    private GameObject timer;

    private Achieviments Achiev;

    void Start() 
    {
        PS = PointSystem.Instance;
        timer = GameObject.Find("Timer Text");
        Achiev = SaveSystem.GetInstance().Achiev;
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player") && !colided) 
        {
            colided = true;

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

        if(Feiticos.Loses)
        {
            timer.GetComponent<Timer>().timeRemaining -= 2;
        }

        if(gameObject.CompareTag("Mushroom")) {
            Achiev.AddMush();
        }
        if(gameObject.CompareTag("Crystal")) {
            Achiev.AddCrystals();
        }
        if(gameObject.CompareTag("CrystalBall")) {
            Achiev.AddCrystalBalls();
        }
        if(gameObject.CompareTag("Potion")) {
            Achiev.AddPotion();
        }
     
        transform.GetChild(1).gameObject.SetActive(false);
        transform.gameObject.GetComponent<BoxCollider>().enabled = false;
        PlaySound();
    }

    private void PlaySound(){
        Transform audio = transform.Find("audio");
        audio.GetComponent<AudioSource>().Play();

    }
}
