using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayResultado : MonoBehaviour
{
    
    private PointSystem Points = PointSystem.Instance;
    private HighScore Hs;
    private Achieviments Achiev;
    private Language lang;

    public TextMeshProUGUI score;
    public TextMeshProUGUI pontuacao;

    void Start()
    {
        Hs = SaveSystem.GetInstance().Hs;
        Achiev = SaveSystem.GetInstance().Achiev;
        lang = SaveSystem.GetInstance().lang;
        DisplayScore();
        Achiev.AddPoints(Points.pontos);
    }

    private void CalculaMultiplicador()
    {
        float multiplicador = 1 + (Feiticos.ChanceMod + Feiticos.DelayMod + Feiticos.LosesMod + Feiticos.ScoreUIMod + Feiticos.SpeedMod + Feiticos.TimeMod + Feiticos.TimeUIMod + Feiticos.WallMod);

        float pontuacaoTotal = Points.pontos * multiplicador;

        Points.pontos = (int)pontuacaoTotal;
    }

    private void DisplayScore() {
        score.text = "";
        CalculaMultiplicador();
        if(lang.idioma() == Language.languagetype.ENGLISH) {
            pontuacao.text = "Score: " + Points.pontos.ToString();
        }
        if(lang.idioma() == Language.languagetype.PORTUGUESE) {
            pontuacao.text = "Pontuação: " + Points.pontos.ToString();
        }
        Hs.Scores.Add(Points.pontos);
        SaveSystem.GetInstance().SaveHighScore();
        Hs.Scores.Sort();
        Hs.Scores.Reverse();
        int redId = checkForPontosInHiscores();
        int max = Hs.Scores.Count > 10? 10 : Hs.Scores.Count;
        for(int i = 0;i < max; i++) {
            if(i != redId) {
                if(lang.idioma() == Language.languagetype.ENGLISH) {
                    score.text += $"Rank {i+1} - {Hs.Scores[i]}\n";
                }
                if(lang.idioma() == Language.languagetype.PORTUGUESE) {
                    score.text += $"Posição {i+1} - {Hs.Scores[i]}\n";
                }
            }
            else {
                if(lang.idioma() == Language.languagetype.ENGLISH) {
                    score.text += $"<color=#FF0000>Rank {i+1} - {Hs.Scores[i]}</color>\n";
                }
                if(lang.idioma() == Language.languagetype.PORTUGUESE) {
                    score.text += $"<color=#FF0000>Pontuação {i+1} - {Hs.Scores[i]}</color>\n";
                }
            }
        }
    }

    private int checkForPontosInHiscores() {
        int max = Hs.Scores.Count > 9? 9 : Hs.Scores.Count-1;
        for(int i=max;i>=0;i--) {
            if(Hs.Scores[i] == Points.pontos) {
                return i;
            }
        }
        return 999;
    }
}
