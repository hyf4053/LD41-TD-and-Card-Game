using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int totalHealt;
    public int currrentTotalHealt;

    public int healthForLaneOne,healthForLaneTwo,healthForLaneThree;

    bool isDead, damaged;
    PlayerShooting playerShooting;

	// Use this for initialization
	void Start () {
		healthForLaneOne = 10;
		healthForLaneTwo = 10;
		healthForLaneThree = 10;
        totalHealt = healthForLaneOne+healthForLaneTwo+healthForLaneThree;
        currrentTotalHealt = totalHealt;
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
        if (totalHealt <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        //destory object
    }
}
