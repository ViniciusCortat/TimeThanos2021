using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class itemAchieviment : MonoBehaviour
{

    private Achieviments Achiev;

    void Start() {
        Achiev = SaveSystem.GetInstance().Achiev;
    }

    void Update()
    {
        
    }
}
