using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyThreeMovement : MonoBehaviour {

	public Transform laneThreePlayer;
	NavMeshAgent nav;
	public EnemyHealth enemyHealth;
	PlayerHealth playerHealth;
	// Use this for initialization
	void Awake () {
		laneThreePlayer = GameObject.FindGameObjectWithTag("Lane3").transform;
		enemyHealth = GetComponent<EnemyHealth>();
        playerHealth = GameObject.FindGameObjectWithTag("playerManager").GetComponent<PlayerHealth>();
		nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyHealth.currentHealth > 0 && playerHealth.healthForLaneThree >0){
			nav.SetDestination(laneThreePlayer.position);
		}else{
			nav.enabled = false;
		}
	}
}
