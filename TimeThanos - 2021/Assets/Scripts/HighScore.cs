using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HighScore")]
public class HighScore : ScriptableObject
{
    [SerializeField]
    public List<int> Scores = new List<int>();

    void Start() {
        SaveSystem.GetInstance().LoadHighScore();
    }
}
