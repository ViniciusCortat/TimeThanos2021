using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayResultado : MonoBehaviour
{
    
    private PointSystem Points = PointSystem.Instance;
    private HighScore Hs;
    private Achieviments Achiev;

    public TextMeshProUGUI score;
    public TextMeshProUGUI pontuacao;

    void Start()
    {
        pontuacao.text = "Pontos: " + Points.pontos.ToString();
        Hs = SaveSystem.GetInstance().Hs;
        DisplayScore();
        Achiev = SaveSystem.GetInstance().Achiev;
        Achiev.AddPoints(Points.pontos);
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
        int redId = checkForPontosInHiscores();
        int max = Hs.Scores.Count > 10? 10 : Hs.Scores.Count;
        for(int i = 0;i < max; i++) {
            if(i != redId) {
                score.text += $"Rank {i+1} - {Hs.Scores[i]}\n";
            }
            else {
                score.text += $"<color=#FF0000>Rank {i+1} - {Hs.Scores[i]}</color>\n";
            }
        }
    }

    private int checkForPontosInHiscores() {
        int max = Hs.Scores.Count > 10? 10 : Hs.Scores.Count;
        for(int i=max;i>=0;i--) {
            if(Hs.Scores[i] == Points.pontos) {
                return i;
            }
        }
        return 999;
    }
}
