using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAchieviment : MonoBehaviour
{
    
    private Achieviments Achiev;

    void Start()
    {
        Achiev = SaveSystem.GetInstance().Achiev;
    }

    
    void Update()
    {
        
    }
}
