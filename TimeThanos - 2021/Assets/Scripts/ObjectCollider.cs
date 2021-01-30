using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{
    public int pontos;
    
    private PointSystem PS;
    void Start() 
    {
        PS = PointSystem.Instance;
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E)) {
            PS.GivePonto(pontos);
            Destroy(this.gameObject);
        }
    }
}
