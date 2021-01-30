using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosePart : MonoBehaviour
{
    public GameObject CorOlho;
    public GameObject CorRoupa2;
    public GameObject CorRoupa;
    public GameObject CorOculos;
    public GameObject CorPele;
    public GameObject CorCabelo;


    public void ligaCor(GameObject liga) {
        CorPele.SetActive(false);
        CorCabelo.SetActive(false);
        CorOlho.SetActive(false);
        CorRoupa2.SetActive(false);
        CorRoupa.SetActive(false);
        CorOculos.SetActive(false);
        liga.SetActive(true);
    }
}
