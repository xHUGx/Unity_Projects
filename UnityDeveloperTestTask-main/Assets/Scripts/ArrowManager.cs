using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowManager : MonoBehaviour
{
    private Scrollbar scrollBar;
    private CanvasGroup leftArrowCanvas;
    private CanvasGroup rightArrowCanvas;

    [SerializeField] private Image leftArrow;
    [SerializeField] private Image rightArrow;
    // Start is called before the first frame update
    void Start()
    {
        scrollBar = GameObject.Find("Scrollbar Horizontal").GetComponent<Scrollbar>();
        leftArrowCanvas = leftArrow.GetComponent<CanvasGroup>();
        rightArrowCanvas = rightArrow.GetComponent<CanvasGroup>();
    }

    private void Update()
    {
        if (scrollBar.value > 0.7)
        {
            rightArrowCanvas.alpha = 1 - scrollBar.value;
            leftArrowCanvas.alpha = 1;
        }
        else if (scrollBar.value < 0.3)
        {
            leftArrowCanvas.alpha = scrollBar.value;
            rightArrowCanvas.alpha = 1;
        }
        else if (scrollBar.value > 0.3 && scrollBar.value < 0.7)
        {
            leftArrowCanvas.alpha = 1;
            rightArrowCanvas.alpha = 1;
        }

    }

    // Update is called once per frame
    
}
