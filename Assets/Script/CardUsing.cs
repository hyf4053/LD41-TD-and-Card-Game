using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUsing : MonoBehaviour {

    public GameObject[] tile;
    bool cardChoose = false;

    public void SetBuildingMode()
    {
        for (int i = 0; i < tile.Length; i++)
        {
            tile[i].AddComponent<CardPlaySlot>();
            //Destroy(tile[i].GetComponent<CardPlaySlot>());
        }
        cardChoose = true;
    }

    private void Update()
    {
        if (cardChoose)
        {
            this.GetComponent<Image>().enabled = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < tile.Length; i++)
            {
                if (tile[i].GetComponent<CardPlaySlot>().tower == null)
                {
                    Destroy(tile[i].GetComponent<CardPlaySlot>());
                }
                else { }
            }
            Destroy(this);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < tile.Length; i++)
            {
                if (tile[i].GetComponent<CardPlaySlot>().tower == null)
                {
                    Destroy(tile[i].GetComponent<CardPlaySlot>());
                }
                else { }
            }

            this.GetComponent<Image>().enabled = true;
            cardChoose = false;
        }
    }

}
