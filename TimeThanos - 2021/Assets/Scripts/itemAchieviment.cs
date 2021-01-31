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
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Book")) {
            Achiev.AddBook();
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Plant")) {
            Achiev.AddPlant();
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Fireplace")) {
            GM.TriggerAchieviment("Fireplace");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Familiar")) {
            GM.TriggerAchieviment("Familiar");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Skull")) {
            GM.TriggerAchieviment("Skull");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Ring")) {
            GM.TriggerAchieviment("Ring");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Mirror")) {
            GM.TriggerAchieviment("Mirror");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Statue")) {
            GM.TriggerAchieviment("Statue");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("OwlTrophy")) {
            GM.TriggerAchieviment("Owl");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Hat")) {
            GM.TriggerAchieviment("Hat");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Broom")) {
            GM.TriggerAchieviment("Broom");
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Cauldron")) {
            GM.TriggerAchieviment("Cauldron");
            Destroy(other.gameObject);
        }
    }
}
