using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStackView : MonoBehaviour
{

    public List<CardData> cards = new List<CardData>();
    public CardView cardPrefab;
    public Transform cardContainer;
    private List<CardView> _cardViews = new List<CardView>();
    void Start()
    {
        GenerateCards();
    }

    private void GenerateCards()
    {
        foreach (var card in cards)
        {
            var cardGameObject = Instantiate(cardPrefab, cardContainer);
            cardGameObject.Initialize(card);
            _cardViews.Add(cardGameObject);
            
        }
    }
    
}
