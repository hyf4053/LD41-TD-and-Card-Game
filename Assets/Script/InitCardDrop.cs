using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCardDrop : MonoBehaviour {
	//public static InitCardDrop instance;

	void Start(){
		//instance = this;
	}
	public GameObject card;
    public GameObject magiCard;
    public GameObject magiTowerCard;
    int spawnCardMax = 10;
    int i = 0;
    public Transform offset;
	GameObject iG;
	public void init(Vector3 p,Quaternion r){
		Vector3 tmp = p;
		tmp.y += 1f;
		p = tmp;

        if (randomMagiDrop())
        {
            Instantiate(magiCard, p, magiCard.transform.rotation);
        
        } else if (randomMagiTDrop()) {
            Instantiate(magiTowerCard, p, magiTowerCard.transform.rotation);
          
        }
        else if (randomTowerDrop())
        {
            Instantiate(card, p, card.transform.rotation);
   
        }
        else
        {

            return;
        }
		
	}

    bool randomTowerDrop()
    {
        float randTower = Random.value;
        Debug.Log(randTower);
        if (randTower<=0.9f)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    bool randomMagiTDrop()
    {
        float randTower = Random.value;
        if (randTower<=0.95f)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    bool randomMagiDrop()
    {
        float randTower = Random.value;
        if (randTower <= 0.99f)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

	void Update(){
	
	}
}
