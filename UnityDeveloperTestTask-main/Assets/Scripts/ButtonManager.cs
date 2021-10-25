using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    private Button button;
    public CardView card;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonAction);
    }

    void ButtonAction()
    {
        Debug.Log(card.cardName + " open scene");
    }
}
    
