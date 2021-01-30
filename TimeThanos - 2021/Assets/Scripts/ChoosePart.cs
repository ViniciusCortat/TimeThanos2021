using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePart : MonoBehaviour
{
    public GameObject CorPele;
    public GameObject CorCabelo;
    public GameObject CorChapeu;


    public void ligaChapeu() {
        CorPele.SetActive(false);
        CorCabelo.SetActive(false);
        CorChapeu.SetActive(true);
    }

    public void ligaCabelo() {
        CorPele.SetActive(false);
        CorCabelo.SetActive(true);
        CorChapeu.SetActive(false);
    }

    public void ligaPele() {
        CorPele.SetActive(true);
        CorCabelo.SetActive(false);
        CorChapeu.SetActive(false);
    }
}
