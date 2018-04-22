using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

    public GameObject[] roadPrefabs;

    private Transform playerTransform;

    private float spawnX = 0.0f;

    private float tileLength = 126f;

    private int amnTilesOnScreen = 20;

	// Use this for initialization
	void Start () {
        playerTransform = GameObject.FindGameObjectWithTag("player").transform;
        
        for(int i = 0; i< amnTilesOnScreen; i++)
        {
            SpawnTile();
        }
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(spawnX - amnTilesOnScreen * tileLength);
		if(playerTransform.position.x > (spawnX - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
        }
	}

    void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(roadPrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.right * spawnX;
        spawnX += tileLength;
    }
}
