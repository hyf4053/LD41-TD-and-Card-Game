using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int currentHealth;
    bool isDead, damaged;
    public GameObject cardDrop;

    //public InitCardDrop initCardDrop;
    // Use this for initialization
    void Start () {
		currentHealth = 5;
        cardDrop = GameObject.FindGameObjectWithTag("CardDropControll");
        //initCardDrop = InitCardDrop.instance;
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
        //Debug.Log("Taken Damage!");
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
        //Instantiate(cardDrop[0],gameObject.transform,gameObject.transform);
        cardDrop.GetComponent<InitCardDrop>().init(this.transform.position,this.transform.rotation);
        Destroy(gameObject);
        //destory object
    }
}
