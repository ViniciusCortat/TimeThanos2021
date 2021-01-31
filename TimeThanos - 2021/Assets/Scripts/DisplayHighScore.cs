using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayHighScore : MonoBehaviour
{
    
    private PointSystem Points = PointSystem.Instance;
    private HighScore Hs;
    private Achieviments Achiev;

    public TextMeshProUGUI score;

    void Start()
    {
        Hs = SaveSystem.GetInstance().Hs;
        DisplayScore();
        Achiev = SaveSystem.GetInstance().Achiev;
    }

    
    void Update()
    {
        
    }

    private void DisplayScore() {
        score.text = "";
        Hs.Scores.Sort();
        Hs.Scores.Reverse();
        int max = Hs.Scores.Count > 10? 10 : Hs.Scores.Count;
        for(int i = 0;i < max; i++) {
            score.text += $"Rank {i+1} - {Hs.Scores[i]}\n";
        }
    }
}