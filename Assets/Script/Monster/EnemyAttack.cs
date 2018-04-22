using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 2f;
    public int attackDamage = 1;

    GameObject player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    bool playerInRange;
    float timer;
	// Use this for initialization
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Lane1");
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            Attack();
        }

        if (playerHealth.currrentTotalHealt <= 0)
        {
            //gameover things
        }

	}

    void Attack()
    {
        timer = 0f;

        if(playerHealth.currrentTotalHealt > 0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
