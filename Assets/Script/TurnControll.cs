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
	public int towerCardLength;

	public static TurnControll instance;

	public Text powerDis;

	void Awake(){
		instance = this;
		power = 9;
	}

	void Start(){
		InvokeRepeating("AddCardToCards",0f,0.5f);
	}

	public void EndTurn(){
		enemyManager.SetActive(true);
		switchTurn.GetComponentInChildren<Text>().text = "waiting for your oppo";
		//disable player card using
		//panel.SetActive(false);
		Invoke("AIEndTurn",3f);
	}

	public void AIEndTurn(){
		switchTurn.GetComponentInChildren<Text>().text = "Battle start!";
		enemyManager.GetComponent<EnemyManager>().enabled = true;
		enemyManager.GetComponent<EnemyManager>().InvokeRepeating("Spawn",0.1f,0.1f);
		Invoke("EndBattle",10f);
	}

	public void EndBattle(){
		enemyManager.GetComponent<EnemyManager>().CancalSpawn();
		enemyManager.GetComponent<EnemyManager>().enabled = false;
		enemyManager.SetActive(false);
		//panel.SetActive(true);
		power = 9;
	}

	void AddCardToCards(){
		cards = GameObject.FindGameObjectsWithTag("CardTower");
	}

	void  AddCardLength(){
		towerCardLength = cards.Length;
	}

	public bool UsePower(int i){
		if(i > power){
			return false;
		}else{
			power -= i;
			return true;
		}
	}

	void Update(){
		powerDis.text = "Power: "+power; 
	}

}
