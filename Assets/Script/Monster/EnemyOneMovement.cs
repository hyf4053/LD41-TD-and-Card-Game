using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyOneMovement : MonoBehaviour {

	public Transform laneOnePlayer,tower;
	NavMeshAgent nav;
	public EnemyHealth enemyHealth;
	PlayerHealth playerHealth;


    void Awake(){
	laneOnePlayer = GameObject.FindGameObjectWithTag("Lane1").transform;
	enemyHealth = GetComponent<EnemyHealth>();
    playerHealth = GameObject.FindGameObjectWithTag("Lane1").GetComponent<PlayerHealth>();
	nav = GetComponent<NavMeshAgent>();
}
	
	// Update is called once per frame
	void Update () {
        try { tower = GameObject.FindGameObjectWithTag("Tower").transform; } catch { }
       
        /*
        GameObject[] towers = GameObject.FindGameObjectsWithTag("Tower");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestTower = null;

        foreach(GameObject tower in towers)
        {
            float distanceToTower = Vector3.Distance(transform.position, tower.transform.position);
        }
        */

		if(enemyHealth.currentHealth > 0 && playerHealth.healthForLaneOne >0&&tower ==null){
            Debug.Log(true);
			nav.SetDestination(laneOnePlayer.position);
		}else{
            //nav.enabled = false;
            nav.SetDestination(tower.position);
		}
/*
		if(enemyHealth.currentHealth > 0 && playerHealth.healthForLaneTwo >0){
			nav.SetDestination(laneTwoPlayer.position);
		}else{
			nav.enabled = false;
		}

		if(enemyHealth.currentHealth > 0 && playerHealth.healthForLaneThree >0){
			nav.SetDestination(laneThreePlayer.position);
		}else{
			nav.enabled = false;
		}
		 */
	}
}
