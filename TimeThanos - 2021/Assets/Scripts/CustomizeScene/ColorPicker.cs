using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Events;

[Serializable]
public class ColorEvent : UnityEvent<Color> { }
public class ColorPicker : MonoBehaviour
{
    RectTransform Rect;
    public ColorEvent OnColorPreview;
    public ColorEvent OnColorSelect;
    public Material mat;
    Texture2D ColorTexture;

    void Start() {
        Rect = GetComponent<RectTransform>();

        ColorTexture = GetComponent<Image>().mainTexture as Texture2D;
    }

    void Update() {
        if (RectTransformUtility.RectangleContainsScreenPoint(Rect, Input.mousePosition)) {
            Vector2 delta;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(Rect, Input.mousePosition, null, out delta);

            float width = Rect.rect.width;
            float height = Rect.rect.height;
            delta += new Vector2(width * .5f, height * .5f);
            float x = Mathf.Clamp(delta.x / width, 0f, 1f);
            float y = Mathf.Clamp(delta.y / height, 0f, 1f);
            int texX = Mathf.RoundToInt(x * ColorTexture.width);
            int texY = Mathf.RoundToInt(y * ColorTexture.height);
            
            Color color = ColorTexture.GetPixel(texX, texY);
            
            //OnColorPreview?.Invoke(color);

            if (Input.GetMouseButtonDown(0)) {
                //OnColorSelect?.Invoke(color);
                mat.SetColor("Color_6A162E48",color);
                if(mat.name == "cabelo") {
                    ChoosePart.matCab = mat;
                }
                if(mat.name == "capa") {
                    ChoosePart.matCapa = mat;
                }
                if(mat.name == "chapeu") {
                    ChoosePart.matChapeu = mat;
                }
                if(mat.name == "oculos-aro") {
                    ChoosePart.matOculos = mat;
                }
                if(mat.name == "olho") {
                    ChoosePart.matOlho = mat;
                }
                if(mat.name == "pele") {
                    ChoosePart.matPele = mat;
                }
            }
        }
    }
}
