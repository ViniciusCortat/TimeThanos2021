using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PointSystem
{
    // Criando Singleton
    private static PointSystem instance = null;
    private static readonly object padlock = new object();
    PointSystem() {}
    public static PointSystem Instance {get {lock(padlock){if(instance==null){instance = new PointSystem();}return instance;}}}

    // Fim da criacao do Singleton

    private int _pontos = 0;

    public int pontos {get {return _pontos;}}

    public void GivePonto(int give) {
        _pontos += give;   
    }

    public void ResetPonto() {
        _pontos = 0;
    }


}
