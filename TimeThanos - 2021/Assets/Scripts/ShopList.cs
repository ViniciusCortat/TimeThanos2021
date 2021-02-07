using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopList : MonoBehaviour
{
    
    public List<GameObject> ShopItens;
    public TextMeshProUGUI PointsText;
    private List<TextMeshProUGUI> PriceText;
    private List<int> PriceValue;
    private List<Button> BuyButtons;

    private Achieviments Achiev;

    private Hats hats;

    void Start()
    {
        Achiev = SaveSystem.GetInstance().Achiev;
        hats = SaveSystem.GetInstance().hats;

        GetValuesInList();
        CheckEnoughValue();
    }

    private void GetValuesInList() {
        PriceText = new List<TextMeshProUGUI>();
        PriceValue = new List<int>();
        BuyButtons = new List<Button>();

        for(int i=0;i<ShopItens.Count;i++) {
            PriceText.Add(ShopItens[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>());
            PriceValue.Add(int.Parse(PriceText[i].text));
            BuyButtons.Add(ShopItens[i].transform.GetChild(0).GetComponent<Button>());
        }
    }

    private void CheckEnoughValue() {
        for(int i=0;i<PriceText.Count;i++) {
            if(Achiev.PresentPoints() < PriceValue[i]) {
                PriceText[i].text = $"<color=#FF0000> {PriceText[i].text} </color>";
            }
            if(hats.ObtainedHats(i)) {
                PriceText[i].text = "Obtained!";
                ShopItens[i].transform.GetChild(2).gameObject.SetActive(false);
                BuyButtons[i].gameObject.SetActive(false);
            }
        }
        PointsText.text = Achiev.PresentPoints().ToString();
    }

    public void BuyHatInShop(string name) {
        if(!hats.CheckHat(name)) {
            return;
        }
        int i = GetIndex(name);
        if(Achiev.PresentPoints() < PriceValue[i]) {
            return;
        }
        if(!hats.BuyHat(name)) {
            return;
        }
        Achiev.BuyItem(PriceValue[i]);
        SaveSystem.GetInstance().SaveHats();
        CheckEnoughValue();

    }

    private int GetIndex(string name) {
        for(int i=0;i<ShopItens.Count;i++) {
            if(ShopItens[i].name == name) {
                return i;
            }
        }
        return 999;
    }
}
