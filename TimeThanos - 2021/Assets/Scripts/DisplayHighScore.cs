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

    public TextMeshProUGUI Stats;

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
        Stats.text = $"{Achiev.PresentMushrooms()} Mushrooms\n\n";
        Stats.text += $"{Achiev.PresentCrystals()} Crystals\n\n";
        Stats.text += $"{Achiev.PresentPotions()} Potions\n\n";
        Stats.text += $"{Achiev.PresentCrystalBalls()} Crystalballs\n\n";
        Stats.text += $"{Achiev.PresentPoints()} Total Points\n\n";
        Stats.text += $"{Hs.Scores.Count} Total Games";
    }
}