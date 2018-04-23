using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour {
    public int totalHealt;
    bool isDead, damaged;

    public Text text;
    // Use this for initialization
    void Start () {
        text.text = "HP:" + totalHealt + "\n" + "ATK:" + 1; 
    }
	
	// Update is called once per frame
	void Update () {

        if (damaged)
        {
            //screen effect
            text.text = "HP:"+totalHealt+"\n"+"ATK:"+1;
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

