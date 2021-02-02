using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class itemAchieviment : MonoBehaviour
{

    private Achieviments Achiev;

    public GameManager GM;

    void Start() {
        Achiev = SaveSystem.GetInstance().Achiev;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Map")) {
            Achiev.AddMaps();
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Book")) {
            Achiev.AddBook();
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Plant")) {
            Achiev.AddPlant();
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Fireplace")) {
            GM.TriggerAchieviment("Fireplace");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Familiar")) {
            GM.TriggerAchieviment("Familiar");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Skull")) {
            GM.TriggerAchieviment("Skull");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Ring")) {
            GM.TriggerAchieviment("Ring");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Mirror")) {
            GM.TriggerAchieviment("Mirror");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Statue")) {
            GM.TriggerAchieviment("Statue");
           GetComponentInChildren<Animator>().SetTrigger("pick");
           PlayAudioAndDisable(other);
        }
        if(other.CompareTag("OwlTrophy")) {
            GM.TriggerAchieviment("Owl");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Hat")) {
            GM.TriggerAchieviment("Hat");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Broom")) {
            GM.TriggerAchieviment("Broom");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
        if(other.CompareTag("Cauldron")) {
            GM.TriggerAchieviment("Cauldron");
            GetComponentInChildren<Animator>().SetTrigger("pick");
            PlayAudioAndDisable(other);
        }
    }

    private void PlayAudioAndDisable(Collider other)
    {

        GameObject obj = other.gameObject;
        obj.GetComponent<BoxCollider>().enabled = false;
        foreach (Transform child in obj.transform)
        {
            if (child.name == "audio")
                child.gameObject.GetComponent<AudioSource>().Play();
            else
                child.gameObject.SetActive(false);
        }
    }
}
