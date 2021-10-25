using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class CardView : MonoBehaviour
{
    /*
    public Image backgroundImage;
    public TextMeshProUGUI text;

    public void Initialize(CardData data)
    {
        backgroundImage.sprite = data.backgroundImage;
        text.text = "10";
    }
    */
    //public CardData card;

    public TextMeshProUGUI currentLevelText;
    public TextMeshProUGUI amountLevelText;

    public string cardName;
    public Image backgroundSprite;
    public Image backEllipseSprite;
    public Image titleSprite;
    public Image creatureSprite;
    public Image portalSprite;
    public Image slashSprite;

    public void Initialize(CardData card)
    {
        cardName = card.name;
        currentLevelText.text = card.currentLevel.ToString();
        amountLevelText.text = card.amountLevel.ToString();
        backgroundSprite.sprite = card.backgroundImage;
        backEllipseSprite.sprite = card.BackEllipse;
        titleSprite.sprite = card.Title;
        creatureSprite.sprite = card.creature;
        portalSprite.sprite = card.portal;
        slashSprite.sprite = card.slash;
    }
}
