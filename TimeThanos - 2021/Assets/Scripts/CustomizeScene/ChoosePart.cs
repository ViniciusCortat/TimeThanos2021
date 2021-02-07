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
    public Material Cab;
    public Material Capa;
    public Material Chapeu;
    public Material Oculos;
    public Material Olho;
    public Material Pele;

    public static Material matCab;
    public static Material matCapa;
    public static Material matChapeu;
    public static Material matOculos;
    public static Material matOlho;
    public static Material matPele; 

    public void ligaCor(GameObject liga) {
        CorPele.SetActive(false);
        CorCabelo.SetActive(false);
        CorOlho.SetActive(false);
        CorRoupa2.SetActive(false);
        CorRoupa.SetActive(false);
        CorOculos.SetActive(false);
        liga.SetActive(true);
    }

    public void Reset() {
        Cab.SetColor("Color_6A162E48",new Color32(82,137,172, 0));
        Capa.SetColor("Color_6A162E48",new Color32(40,3,82, 0));
        Chapeu.SetColor("Color_6A162E48",new Color32(0,0,0, 0));
        Oculos.SetColor("Color_6A162E48",new Color32(255,255,255, 0));
        Olho.SetColor("Color_6A162E48",new Color32(0,0,0, 0));
        Pele.SetColor("Color_6A162E48",new Color32(245,125,71, 0));
        matCab = Cab;
        matCapa = Capa;
        matChapeu = Chapeu;
        matOculos = Oculos;
        matOlho = Olho;
        matPele = Pele;
    }

    public void Randomizar() {
        Cab.SetColor("Color_6A162E48",new Color32((byte)Random.Range(1,256),(byte)Random.Range(1,256),(byte)Random.Range(1,256), 0));
        Capa.SetColor("Color_6A162E48",new Color32((byte)Random.Range(1,256),(byte)Random.Range(1,256),(byte)Random.Range(1,256), 0));
        Chapeu.SetColor("Color_6A162E48",new Color32((byte)Random.Range(1,256),(byte)Random.Range(1,256),(byte)Random.Range(1,256), 0));
        Oculos.SetColor("Color_6A162E48",new Color32((byte)Random.Range(1,256),(byte)Random.Range(1,256),(byte)Random.Range(1,256), 0));
        Olho.SetColor("Color_6A162E48",new Color32((byte)Random.Range(1,256),(byte)Random.Range(1,256),(byte)Random.Range(1,256), 0));
        Pele.SetColor("Color_6A162E48",new Color32((byte)Random.Range(1,256),(byte)Random.Range(1,256),(byte)Random.Range(1,256), 0));
        matCab = Cab;
        matCapa = Capa;
        matChapeu = Chapeu;
        matOculos = Oculos;
        matOlho = Olho;
        matPele = Pele;
    }

    public void OpenHatInterface(GameObject hatmenu) {
        hatmenu.SetActive(true);
    }

    public void CloseHatInterface(GameObject hatmenu) {
        hatmenu.SetActive(false);
    }

    
}
