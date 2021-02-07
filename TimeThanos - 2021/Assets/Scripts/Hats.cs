using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hat")]
public class Hats : ScriptableObject
{
    public List<string> AvailableHats;
    [SerializeField]
    private List<bool> BoughtHats;
    [SerializeField]
    private int WearingHat = 0;
    

    public void InitHat() {
        for(int i=0;i<AvailableHats.Count;i++) {
            BoughtHats.Add(false);
        }
        WearingHat = 0;
    }

    public bool ObtainedHats(int i) {
        return BoughtHats[i];
    }

    public bool BuyHat(string hat) {
        int i = AvailableHats.IndexOf(hat);
        if(BoughtHats[i]) {
            return false;
        }
        BoughtHats[i] = true;
        return true;
    }

    public bool CheckHat(string hat) {
        int i = AvailableHats.IndexOf(hat);
        if(BoughtHats[i]) {
            return false;
        }
        return true;
    }

    public void ChangeHat(int index) {
        WearingHat = index;
    }

    public int CurrentHat() {
        return WearingHat;
    }
}
