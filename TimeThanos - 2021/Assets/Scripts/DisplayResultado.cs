using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayResultado : MonoBehaviour
{
    
    private PointSystem Points = PointSystem.Instance;
    private HighScore Hs;

    public Text score;

    void Start()
    {
        SaveSystem.GetInstance().SaveHighScore();
        Hs = SaveSystem.GetInstance().Hs;
        DisplayScore();
    }

    
    void Update()
    {
        
    }

    private void DisplayScore() {
        score.text = "";
        Hs.Scores.Sort();
        for(int i = 0;i < Hs.Scores.Count; i++) {
            score.text += $"Rank {i+1} - {Hs.Scores[i]}\n";
        }
    }
}
