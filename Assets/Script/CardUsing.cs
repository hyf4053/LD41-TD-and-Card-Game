using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUsing : MonoBehaviour {

    public GameObject[] tile;
    bool cardChoose = false;
    TurnControll turnControll;
    int cardCost;
    TowerManager towerManager;
    void Start(){
        towerManager = TowerManager.instance;
        turnControll = TurnControll.instance;
    }

    public void SetTTower(){
        towerManager.SetCardToUse(towerManager.towerPrefab);
        cardCost = 2;
        if(turnControll.UsePower(cardCost)){
            cardChoose = true;
        }else{
            cardChoose = false;
            Debug.Log("Cannot afford card!");
        }
    }

    public void SetMagicCard(){
        towerManager.SetCardToUse(towerManager.magicCardPrefab);
        cardChoose = true;
    }

    public void SetToNull(){
        towerManager.SetCardToUse(null);
        cardChoose = false;
    }
    public void SetBuildingMode()
    {
        /* 
        for (int i = 0; i < tile.Length; i++)
        {
            tile[i].AddComponent<CardPlaySlot>();
            //Destroy(tile[i].GetComponent<CardPlaySlot>());
        }
        cardChoose = true;
        */
    }

    private void Update()
    {
        if (cardChoose)
        {
            this.GetComponent<Image>().enabled = false;
            bool a,b,c,d,e,f,g,h,i;
             a = tile[0].GetComponent<CardPlaySlot>().isOccupied;
             b = tile[0].GetComponent<CardPlaySlot>().isOccupied;
             c = tile[0].GetComponent<CardPlaySlot>().isOccupied;
             d = tile[0].GetComponent<CardPlaySlot>().isOccupied;
             e = tile[0].GetComponent<CardPlaySlot>().isOccupied;
             f = tile[0].GetComponent<CardPlaySlot>().isOccupied;
             g = tile[0].GetComponent<CardPlaySlot>().isOccupied;
             h = tile[0].GetComponent<CardPlaySlot>().isOccupied;
             i = tile[0].GetComponent<CardPlaySlot>().isOccupied;
         if (Input.GetMouseButtonDown(0)&&tile[0].GetComponent<CardPlaySlot>().tower == null)
        {
            SetToNull();
            Destroy(gameObject);
        }



        /* 
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
        }*/
        }
    }

}
