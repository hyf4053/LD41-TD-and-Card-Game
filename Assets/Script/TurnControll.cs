using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnControll : MonoBehaviour {
	public int power,powerBase;
	public GameObject enemyManager;
	public GameObject panel;
	public Button switchTurn;
	public GameObject[] cards;
	public int towerCardLength;
    public GameObject[] enemies;

    private float respawnTime = 3f;
    private int wave = 10;
    private int currentwave;
    private float currentresTime;

	public static TurnControll instance;

    public Button[] buttons;

	public Text powerDis,turnDis;

    public GameObject result;

	void Awake(){
		instance = this;
		power = 2;
        powerBase = 2;
        currentwave = 1;
        turnDis.text = "Turn: " + currentwave;
        currentresTime = respawnTime;
        InvokeRepeating("GetAllEnemise", 0f, 0.5f);
    }
    void GetAllEnemise()
    {

        enemies = GameObject.FindGameObjectsWithTag("Enemy");

    }
    void Start(){
		InvokeRepeating("AddCardToCards",0f,0.5f);
	}

    void DisableTowerCard()
    {
        buttons = panel.GetComponentsInChildren<Button>();
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].tag == "CardTower")
            {
                buttons[i].interactable = false;
            }
        }
    }

	public void EndTurn(){
		enemyManager.SetActive(true);
        switchTurn.interactable = false;
		switchTurn.GetComponentInChildren<Text>().text = "waiting for your oppo";
        InvokeRepeating("DisableTowerCard",0f,0.5f);
		//disable player card using
		//panel.SetActive(false);
		Invoke("AIEndTurn",3f);
	}

	public void AIEndTurn(){
		switchTurn.GetComponentInChildren<Text>().text = "Battle start!";
		enemyManager.GetComponent<EnemyManager>().enabled = true;
		enemyManager.GetComponent<EnemyManager>().InvokeRepeating("Spawn", currentresTime, currentresTime);
        Invoke("StopSpawn",10f);
	}

    public void StopSpawn()
    {
        enemyManager.GetComponent<EnemyManager>().CancalSpawn();
        if (currentwave < 5)
        {
            Invoke("EndBattle", 5f);
        }
        else
        {
            Invoke("EndBattle", 20f);
        }
        
    }

	public void EndBattle(){
        switchTurn.interactable = true;
		//enemyManager.GetComponent<EnemyManager>().CancalSpawn();
		enemyManager.GetComponent<EnemyManager>().enabled = false;
		enemyManager.SetActive(false);
        switchTurn.GetComponentInChildren<Text>().text = "End Turn";
        //panel.SetActive(true);
        if (power < 9)
        {
            power = powerBase + 1;
            powerBase = power;
        }
        currentwave += 1;
        turnDis.text = "Turn: " + currentwave;
        currentresTime = respawnTime - currentwave*0.29f ;
        Debug.Log("Respawn Time: "+ currentresTime);

        CancelInvoke();

        buttons = panel.GetComponentsInChildren<Button>();
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].tag == "CardTower")
            {
                buttons[i].interactable = true;
            }
        }

        if (currentwave == 10)
        {
            result.SetActive(true);
            result.GetComponentInChildren<Text>().text = "You WIN this time!" + "\n" + "Click anywhere to exit game.";
        }

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
