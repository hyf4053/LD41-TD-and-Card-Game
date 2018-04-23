using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

	public PlayerHealth playerHealth;
	public GameObject enemyOne, enemyTwo, enemyThree;

	public float spawnTime = 0.1f;

	public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn",spawnTime,spawnTime);
	}
	
	void Spawn(){
		if(playerHealth.currrentTotalHealt <= 0){

			//gameover function

			return;
		}

		int spawnPointIndex = Random.Range(0,spawnPoints.Length);

        if (spawnPointIndex == 0)
        {
            Instantiate(enemyOne, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
        else if (spawnPointIndex == 1)
        {
            Instantiate(enemyTwo, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
        else if (spawnPointIndex == 2)
        {
            Instantiate(enemyThree, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
	}

	public void CancalSpawn(){
		CancelInvoke();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
