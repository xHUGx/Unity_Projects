using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeanTweenAnimation : MonoBehaviour
{
    private float prevPoint;
    public float tweenTime;
    public TextMeshProUGUI textPoints;
    public void TweenStar()
    {
        transform.rotation = new Quaternion(0,0,0,0);
        transform.localScale = Vector3.one;
        
        LeanTween.scale(gameObject, Vector3.one * 2, tweenTime).setEasePunch();
        LeanTween.rotateAround(gameObject, Vector3.forward, 360f, tweenTime/3);

    }

    public void TweenPoints()
    {
        prevPoint = float.Parse(textPoints.text);
        LeanTween.scale(gameObject, Vector3.one * 2, tweenTime).setEasePunch();
        LeanTween.value(gameObject, prevPoint, prevPoint + 5, tweenTime / 3)
            .setOnUpdate(addPoints)
            .setEaseOutQuad();

    }

    public void addPoints(float value)
    {
        int intValue = (int)value;
        textPoints.text = intValue.ToString();
    }
   
}
