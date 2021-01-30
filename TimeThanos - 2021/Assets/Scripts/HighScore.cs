using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HighScore")]
public class HighScore : ScriptableObject
{
    public static int attempts;
    public List<int> Scores = new List<int>();

    void Start() {
        //Scores = new List<int>();
        SaveSystem.GetInstance().LoadHighScore();
    }
}
