using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Create card")]
public class CardData : ScriptableObject
{
    public string cardName;
    public int currentLevel;
    public int amountLevel;

    public Sprite backgroundImage;
    public Sprite BackEllipse;
    public Sprite Title;
    public Sprite creature;
    public Sprite portal;
    public Sprite slash;
    }
