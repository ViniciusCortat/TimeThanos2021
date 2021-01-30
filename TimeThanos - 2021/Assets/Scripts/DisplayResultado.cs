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
        SaveSystem.GetInstance().SaveHighScore();
        pontuacao.text = "Pontos: " + Points.pontos.ToString();
        Hs = SaveSystem.GetInstance().Hs;
        DisplayScore();
    }

    
    void Update()
    {
        
    }

    private void DisplayScore() {
        score.text = "";
        Hs.Scores.Sort();
        int max = Hs.Scores.Count > Hs.MaxDisplayAttempts? Hs.MaxDisplayAttempts : Hs.Scores.Count;
        for(int i = 0;i < max; i++) {
            score.text += $"Rank {i+1} - {Hs.Scores[i]}\n";
        }
    }
}
