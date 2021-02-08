using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHat : MonoBehaviour
{
    public List<GameObject> HatList;
    private Hats hats;

    private GameObject Cabelo_inteiro;
    private GameObject Cabelo_3;
    private GameObject Oculos;
    private GameObject Cabelo_2;
    private GameObject Franja;
    private GameObject Chapeu;

    void Start()
    {
        hats = SaveSystem.GetInstance().hats;
        Cabelo_inteiro = gameObject.transform.GetChild(0).GetChild(2).gameObject;
        Cabelo_2 = gameObject.transform.GetChild(0).GetChild(3).gameObject;
        Cabelo_3 = gameObject.transform.GetChild(0).GetChild(4).gameObject;
        Chapeu = gameObject.transform.GetChild(0).GetChild(7).gameObject;
        Franja = gameObject.transform.GetChild(0).GetChild(9).gameObject;
        Oculos = gameObject.transform.GetChild(0).GetChild(10).gameObject;
        ActivateHat();
    }

    public void ActivateHat() {
        for(int i=0;i<HatList.Count;i++) {
            HatList[i].SetActive(false);
        }
        CheckHatCondition();
        if(hats.CurrentHat() != -1) {
            HatList[hats.CurrentHat()].SetActive(true);
        }
    }

    public void CheckHatCondition() {
        int hn = hats.CurrentHat();
        Cabelo_inteiro.SetActive(true);
        Cabelo_3.SetActive(true);
        Oculos.SetActive(true);
        Chapeu.SetActive(false);
        Cabelo_2.SetActive(false);
        Franja.SetActive(false);

        if(hn == 0) {
            Cabelo_inteiro.SetActive(false);
            Cabelo_3.SetActive(true);
            Oculos.SetActive(true);
            Chapeu.SetActive(true);
            Cabelo_2.SetActive(true);
            Franja.SetActive(true);
        }
        if(hn == 4) {
            Cabelo_inteiro.SetActive(true);
            Oculos.SetActive(true);
            Chapeu.SetActive(false);
            Cabelo_2.SetActive(false);
            Cabelo_3.SetActive(false);
            Franja.SetActive(false);
        }
        if(hn == 6 || hn == 20 || hn == 22) {
            Chapeu.SetActive(false);
            Cabelo_2.SetActive(false);
            Cabelo_3.SetActive(false);
            Oculos.SetActive(false);
            Franja.SetActive(false);
            Cabelo_inteiro.SetActive(false);
        }
        if(hn == 10 || hn == 19 || hn == 21) {
            Chapeu.SetActive(true);
            Cabelo_2.SetActive(true);
            Cabelo_3.SetActive(true);
            Oculos.SetActive(true);
            Franja.SetActive(true);
            Cabelo_inteiro.SetActive(false);
        }
        if(hn == 13) {
            Cabelo_inteiro.SetActive(true);
            Cabelo_3.SetActive(true);
            Chapeu.SetActive(false);
            Cabelo_2.SetActive(false);
            Franja.SetActive(false);
            Oculos.SetActive(false);
        }
        if(hn == 16 || hn == 17 || hn == 23) {
            Chapeu.SetActive(false);
            Cabelo_2.SetActive(true);
            Cabelo_3.SetActive(true);
            Oculos.SetActive(true);
            Franja.SetActive(true);
            Cabelo_inteiro.SetActive(false);
        }
        if(hn == 18) {
            Cabelo_inteiro.SetActive(true);
            Cabelo_3.SetActive(true);
            Oculos.SetActive(true);
            Chapeu.SetActive(false);
            Cabelo_2.SetActive(false);
            Franja.SetActive(false);
        }
        if(hn == 24) {
            Cabelo_3.SetActive(true);
            Oculos.SetActive(true);
            Chapeu.SetActive(false);
            Cabelo_2.SetActive(false);
            Franja.SetActive(false);
            Cabelo_inteiro.SetActive(false);
        }
    }
}
