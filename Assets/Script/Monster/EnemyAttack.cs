using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 2f;
    public int attackDamage = 1;

    GameObject player;
    GameObject tower;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;

    TowerHealth towerHealth;
    bool playerInRange,towerInRange;
    float timer;
	// Use this for initialization
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Lane1");
        playerHealth = player.GetComponent<PlayerHealth>();

        InvokeRepeating("TryGetTower",0f,0.5f);

        enemyHealth = GetComponent<EnemyHealth>();
	}

    void TryGetTower(){
        try{tower = GameObject.FindGameObjectWithTag("Tower");
        towerHealth = tower.GetComponent<TowerHealth>();}catch{}
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }

        if(other.gameObject == tower&&other.gameObject.tag=="Tower"){
            towerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
        if(other.gameObject == tower){
            towerInRange = false;
        }
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            Attack();
        }

        if(timer >= timeBetweenAttacks && towerInRange&& enemyHealth.currentHealth > 0){
            AttackTower();
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

    void AttackTower(){
        timer = 0f;
        if(towerHealth.totalHealt > 0){
            towerHealth.TakeDamage(attackDamage);
        }
    }
}
