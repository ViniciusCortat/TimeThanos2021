using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Language")]
public class Language : ScriptableObject
{
    public enum languagetype {
        ENGLISH,
        PORTUGUESE,
        SPANISH
    }
    [SerializeField]
    private languagetype lang;

    public languagetype idioma() {
        return lang;
    }

    public void InitLanguage() {
        lang = languagetype.ENGLISH;
    }
}