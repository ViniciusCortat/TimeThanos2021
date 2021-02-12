using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TranslateText : MonoBehaviour
{
    [TextArea]
    public string EnglishText;
    [TextArea]
    public string PortugueseText;
    private TextMeshProUGUI Myself;

    private Language lang;

    void Start()
    {
        Myself = GetComponent<TextMeshProUGUI>();
        lang = SaveSystem.GetInstance().lang;
        CheckLanguage();
    }

    
    public void CheckLanguage() {
        if(lang.idioma() == Language.languagetype.ENGLISH) {
            Myself.text = EnglishText;
        }
        if(lang.idioma() == Language.languagetype.PORTUGUESE) {
            Myself.text = PortugueseText;
        }
    }
}
