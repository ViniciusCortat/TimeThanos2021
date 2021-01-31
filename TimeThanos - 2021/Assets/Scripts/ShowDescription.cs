using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string Descriptions;

    public TextMeshProUGUI DescriptionText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        DescriptionText.text = Descriptions;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DescriptionText.text = "";
    }


}
