using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text pontosText;

    private PointSystem PS;

    private Achieviments Achiev;

    void Start()
    {
        PS = PointSystem.Instance;
        Achiev = SaveSystem.GetInstance().Achiev;
    }

    
    void Update()
    {
        pontosText.text = PS.pontos.ToString();
    }

    public void TriggerAchieviment(string title) {
        int i = Achiev.Achiev.IndexOf(title);
        if(Achiev.CheckCompletion(i)) return;
        Achiev.GiveAchiev(i);
    }
}
