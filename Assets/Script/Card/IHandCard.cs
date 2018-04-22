using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IHandCard  {

	string cardName { get; }

    Sprite Image { get; }

    void OnPickup();

    void OnDrop();

}

public class HandCardEventArgs : EventArgs
{
    public HandCardEventArgs(IHandCard card)
    {
        Card = card;
    }

    public IHandCard Card;
}
