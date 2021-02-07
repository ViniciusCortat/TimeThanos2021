using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObtainedHats : MonoBehaviour
{
    public List<GameObject> ButtonList;
    public GameObject Player;

    private Hats hats;

    void Start()
    {
        hats = SaveSystem.GetInstance().hats;
        for(int i=0;i<ButtonList.Count;i++) {
            if(!hats.ObtainedHats(i)) {
                ButtonList[i].SetActive(false);
            }
        }
        
    }

    public void ChooseHat(int index) {
        hats.ChangeHat(index);
        SaveSystem.GetInstance().SaveHats();
        Player.GetComponent<PlayerHat>().ActivateHat();
    }
}
