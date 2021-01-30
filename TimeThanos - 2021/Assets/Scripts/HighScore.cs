using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HighScore")]
public class HighScore : ScriptableObject
{
    public static int attempts;
    public int MaxDisplayAttempts;

    private List<int> Scores;

    void Start() {
        Scores = new List<int>();
        SaveSystem.GetInstance().LoadHighScore();
    }
}
