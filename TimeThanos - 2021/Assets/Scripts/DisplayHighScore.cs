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

    public List<TextMeshProUGUI> Stats;

    void Start()
    {
        Hs = SaveSystem.GetInstance().Hs;
        Achiev = SaveSystem.GetInstance().Achiev;
        DisplayScore();
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
        Debug.Log(Achiev.PresentMushrooms());
        Stats[0].text = $"{Achiev.PresentMushrooms()}";
        Stats[1].text = $"{Achiev.PresentCrystals()}";
        Stats[2].text = $"{Achiev.PresentPotions()}";
        Stats[3].text = $"{Achiev.PresentCrystalBalls()}";
        Stats[4].text = $"{Achiev.PresentPoints()}";
        Stats[5].text = $"{Hs.Scores.Count}";
    }
}