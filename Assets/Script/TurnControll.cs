using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnControll : MonoBehaviour {
	public int power;
	public GameObject enemyManager;
	public GameObject panel;
	public Button switchTurn;
	public GameObject[] cards;

	void Awake(){
		power = 9;
	}

	void Start(){
		InvokeRepeating("AddCardToCards",0f,0.5f);
	}

	public void EndTurn(){
		enemyManager.SetActive(true);
		switchTurn.GetComponentInChildren<Text>().text = "waiting for your oppo";
		//disable player card using
		panel.SetActive(false);
	}

	void AddCardToCards(){
		cards = GameObject.FindGameObjectsWithTag("Card");
	}

	public void UsePower(){

	}

}
