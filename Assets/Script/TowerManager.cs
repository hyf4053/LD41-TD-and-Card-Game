using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour {

    public static TowerManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
        
    }

    public GameObject towerPrefab;

    private GameObject towerToBuild;

    public GameObject GetTowerToBuild()
    {
        return towerToBuild;
    }

	// Use this for initialization
	void Start () {
        towerToBuild = towerPrefab;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
