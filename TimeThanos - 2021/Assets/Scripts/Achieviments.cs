using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Achieviment")]
public class Achieviments : ScriptableObject
{

    public List<string> Achiev;

    private List<bool> Completed;

    void Start() {
        Completed = new List<bool>();
        for(int i=0; i < Achiev.Count; i++) {
            Completed.Add(false);
        }

        SaveSystem.GetInstance().LoadAchieviments();
    }

    public void GiveAchiev(int id) {
        Completed[id] = true;
    }

    public bool CheckCompletion(int i) {
        return Completed[i];
    }
}
