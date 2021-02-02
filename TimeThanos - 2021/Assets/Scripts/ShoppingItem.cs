using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingItem : MonoBehaviour
{
    
    public int Price;
    public Toggle BuyToggle;

    private Achieviments Achiev;

    void Start()
    {
        Achiev = SaveSystem.GetInstance().Achiev;
    }
}
