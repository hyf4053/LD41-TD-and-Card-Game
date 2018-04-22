using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTwoMovement : MonoBehaviour {

	public Transform laneTwoPlayer;
	NavMeshAgent nav;
	public EnemyHealth enemyHealth;
	PlayerHealth playerHealth;
	
	void Awake(){
		laneTwoPlayer = GameObject.FindGameObjectWithTag("Lane2").transform;
		enemyHealth = GetComponent<EnemyHealth>();
        playerHealth = GameObject.FindGameObjectWithTag("playerManager").GetComponent<PlayerHealth>();
		nav = GetComponent<NavMeshAgent>();
	}

	void Update(){
		if(enemyHealth.currentHealth > 0 && playerHealth.healthForLaneTwo >0){
			nav.SetDestination(laneTwoPlayer.position);
		}else{
			nav.enabled = false;
		}
	}


}
