using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Transition : MonoBehaviour
{
    public Image image;
    public float tweenTime;

    public void FadeIn()
    {
        LeanTween.value(gameObject, 0.1f, 1f, tweenTime).setOnUpdate((float val) =>
        {
            Color c = image.color;
            c.a = val;
            image.color = c;
        });

    }
    public void FadeOut()
    {
        LeanTween.value(gameObject, 1f, 0, tweenTime).setOnUpdate((float val) =>
        {
            Color c = image.color;
            c.a = val;
            image.color = c;
            if (val == 0) 
            {
                gameObject.SetActive(false);
            }
        });
    }
}
