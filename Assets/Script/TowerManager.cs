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
    public GameObject magicCardPrefab;
    public GameObject trapCardPrefab;
    
    private GameObject towerToBuild;

    public GameObject GetTowerToBuild()
    {
        return towerToBuild;
    }

	public void SetCardToUse(GameObject card){
        towerToBuild = card;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
