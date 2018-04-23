using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int totalHealt;
    public int currrentTotalHealt;

    public int healthForLaneOne,healthForLaneTwo,healthForLaneThree;

    bool isDead, damaged;

    public Text text;
    public GameObject result;

    PlayerShooting playerShooting;

	// Use this for initialization
	void Start () {
		healthForLaneOne = 10;
		healthForLaneTwo = 10;
		healthForLaneThree = 10;
        totalHealt = healthForLaneOne+healthForLaneTwo+healthForLaneThree;
        currrentTotalHealt = totalHealt;
        text.text = "HP:30";
    }

    private void Awake()
    {
        currrentTotalHealt = totalHealt;
    }

    // Update is called once per frame
    void Update () {
        if (damaged)
        {
            //screen effect
            text.text = "HP:" + totalHealt;
        }
        else
        {
            //screen effect
        }

        damaged = false;
	}

    public void TakeDamage(int amount)
    {
        Debug.Log("Taken Damage!");
        damaged = true;
        totalHealt -= amount;
        if (totalHealt <= 0)
        {
            Debug.Log("dead");
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        result.SetActive(true);
        result.GetComponentInChildren<Text>().text = "Sorry, Game Over. Try you best next time!";
        //destory object
    }
}
