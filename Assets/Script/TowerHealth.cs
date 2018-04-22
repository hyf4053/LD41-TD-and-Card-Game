using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHealth : MonoBehaviour {
    public int totalHealt;
    bool isDead, damaged;
    // Use this for initialization
    void Start () {
		
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
        Destroy(gameObject);
        //destory object
    }
}

