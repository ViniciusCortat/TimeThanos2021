using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayResultado : MonoBehaviour
{
    
    private PointSystem Points = PointSystem.Instance;
    private HighScore Hs;

    public Text score;
    public Text pontuacao;

    void Start()
    {
        pontuacao.text = "Pontos: " + Points.pontos.ToString();
        Hs = SaveSystem.GetInstance().Hs;
        DisplayScore();
    }

    
    void Update()
    {
        
    }

    private void DisplayScore() {
        score.text = "";
        Hs.Scores.Add(Points.pontos);
        SaveSystem.GetInstance().SaveHighScore();
        Hs.Scores.Sort();
        Hs.Scores.Reverse();
        int max = Hs.Scores.Count > 10? 10 : Hs.Scores.Count;
        for(int i = 0;i < max; i++) {
            score.text += $"Rank {i+1} - {Hs.Scores[i]}\n";
        }
    }
}
