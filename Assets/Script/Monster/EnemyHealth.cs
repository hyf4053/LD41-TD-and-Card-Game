using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int currentHealth;
    bool isDead, damaged;
    // Use this for initialization
    void Start () {
		currentHealth = 5;
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
        currentHealth -= amount;
        if (currentHealth <= 0 && !isDead)
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
