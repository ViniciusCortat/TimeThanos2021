using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HighScore")]
public class HighScore : ScriptableObject
{
    public static int attempts;
    public int MaxDisplayAttempts;

    public List<int> Scores;

    void Start() {
        Scores = new List<int>();
        SaveSystem.GetInstance().LoadHighScore();
    }
}
