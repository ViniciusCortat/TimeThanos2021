using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [TextArea]
    public string DescriptionEnglish;

    [TextArea]
    public string DescriptionPortuese;

    public TextMeshProUGUI DescriptionText;

    private Language lang;

    void Start()
    {
        lang = SaveSystem.GetInstance().lang;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(lang.idioma() == Language.languagetype.ENGLISH) {
            DescriptionText.text = DescriptionEnglish;
        }
        if(lang.idioma() == Language.languagetype.PORTUGUESE) {
            DescriptionText.text = DescriptionPortuese;
        }
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DescriptionText.text = "";
    }


}
