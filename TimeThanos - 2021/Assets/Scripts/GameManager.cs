using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text pontosText;

    private PointSystem PS;

    void Start()
    {
        PS = PointSystem.Instance;
    }

    
    void Update()
    {
        pontosText.text = PS.pontos.ToString();
    }
}
