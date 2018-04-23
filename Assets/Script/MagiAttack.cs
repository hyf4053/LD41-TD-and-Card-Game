using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagiAttack : MonoBehaviour {

		public int attackDamage = 4;

	public GameObject[] enemies;
	bool enemyInRange;
    //EnemyHealth[] enemyHealth;
    public EnemyHealth[] enemyHealth;

	void Awake(){
        InvokeRepeating("GetAllEnemise",0f,0.5f);
	}

   void GetAllEnemise()
    {
        
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyHealth = new EnemyHealth[enemies.Length];
        for(int i = 0; i < enemies.Length; i++)
        {
            enemyHealth.SetValue(enemies[i].GetComponent<EnemyHealth>(), i);
        }
       
    }

    void Attack()
    {
        for(int i = 0; i < enemyHealth.Length; i++)
        {
            enemyHealth[i].TakeDamage(attackDamage);
        }
    }

    // Update is called once per frame
    void Update () {
        Attack();
	}
}
