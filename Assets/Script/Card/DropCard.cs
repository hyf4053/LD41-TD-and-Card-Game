using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCard : MonoBehaviour,IHandCard
{

    public string cardName
    {
        get
        {
            return "DropCard";
        }
    }
    public Sprite _Image;
    public Sprite Image
    {
        get { return Image; }
    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

    public void OnDrop()
    {
        throw new System.NotImplementedException();
    }
}
