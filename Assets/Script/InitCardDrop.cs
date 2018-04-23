using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCardDrop : MonoBehaviour {
	//public static InitCardDrop instance;

	void Start(){
		//instance = this;
	}
	public GameObject card;
	public Transform offset;
	GameObject iG;
	public void init(Vector3 p,Quaternion r){

		Vector3 tmp = p;
		tmp.y += 1f;
		p = tmp;
		Instantiate(card,p,card.transform.rotation);
	}
	void Update(){
		/* 
		if(iG.GetComponent<PickUpCard>().isPickup){
			Destroy(iG);
		}*/
	}
}
