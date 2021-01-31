using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievimentImage : MonoBehaviour
{
    public List<Image> AchievImages;

    private Achieviments Achiev;

    void Start()
    {
        Achiev = SaveSystem.GetInstance().Achiev;
        for(int i=0;i < Achiev.Achiev.Count; i++) {
            if(Achiev.CheckCompletion(i)) {
                AchievImages[i].gameObject.SetActive(true);
            }
        }
    }
}
