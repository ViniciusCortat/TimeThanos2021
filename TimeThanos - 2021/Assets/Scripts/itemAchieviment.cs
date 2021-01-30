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
        }
        if(other.CompareTag("Book")) {
            Achiev.AddBook();
        }
        if(other.CompareTag("Plant")) {
            Achiev.AddPlant();
        }
        if(other.CompareTag("Painting")) {
            Achiev.AddPaintings();
        }
        if(other.CompareTag("Mushroom")) {
            Achiev.AddMush();
        }
        if(other.CompareTag("Crystal")) {
            Achiev.AddCrystals();
        }
        if(other.CompareTag("CrystalBall")) {
            Achiev.AddCrystalBalls();
        }
        if(other.CompareTag("Potion")) {
            Achiev.AddPotion();
        }
        if(other.CompareTag("Fireplace")) {
            GM.TriggerAchieviment("Fireplace");
        }
        if(other.CompareTag("Familiar")) {
            GM.TriggerAchieviment("Familiar");
        }
        if(other.CompareTag("Skull")) {
            GM.TriggerAchieviment("Skull");
        }
        if(other.CompareTag("Ring")) {
            GM.TriggerAchieviment("Ring");
        }
        if(other.CompareTag("Mirror")) {
            GM.TriggerAchieviment("Mirror");
        }
        if(other.CompareTag("Statue")) {
            GM.TriggerAchieviment("Statue");
        }
        if(other.CompareTag("OwlTrophy")) {
            GM.TriggerAchieviment("OwlTrophy");
        }
    }
}
