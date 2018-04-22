using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HandCard : MonoBehaviour {

    private const int SLOTS = 9;

    private List<IHandCard> mCards = new List<IHandCard>();

    public event EventHandler<HandCardEventArgs> CardAdded;

    public event EventHandler<HandCardEventArgs> CardUsed;

    public void AddCard(IHandCard card)
    {
        if(mCards.Count < SLOTS)
        {
            Collider collider = (card as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;
                mCards.Add(card);
                card.OnPickup();
            }

            if(CardAdded != null)
            {
                CardAdded(this, new HandCardEventArgs(card));
            }
        }
    }
	
}
