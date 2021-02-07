using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHat : MonoBehaviour
{
    public List<GameObject> HatList;
    private Hats hats;
    private List<GameObject> CaveiraEquipped;

    void Start()
    {
        hats = SaveSystem.GetInstance().hats;
        CaveiraEquipped = new List<GameObject>();
        CaveiraEquipped.Add(gameObject.transform.GetChild(0).GetChild(2).gameObject);
        CaveiraEquipped.Add(gameObject.transform.GetChild(0).GetChild(3).gameObject);
        CaveiraEquipped.Add(gameObject.transform.GetChild(0).GetChild(2).gameObject);
        CaveiraEquipped.Add(gameObject.transform.GetChild(0).GetChild(2).gameObject);
        ActivateHat();
        
    }

    public void ActivateHat() {
        for(int i=0;i<HatList.Count;i++) {
            HatList[i].SetActive(false);
        }
        HatList[hats.CurrentHat()].SetActive(true);
        if(hats.CurrentHat() == 4) {
            
        }
    }
}
