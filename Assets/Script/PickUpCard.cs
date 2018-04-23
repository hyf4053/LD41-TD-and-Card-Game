using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpCard : MonoBehaviour {


	public RectTransform panel;
	public GameObject buttonPrefab;
	// Update is called once per frame
	public bool isPickup =  false;
	void Awake(){
		panel = GameObject.FindGameObjectWithTag("Plane").GetComponent<RectTransform>();
	}
	void Update () {
		
		if(Input.GetMouseButtonDown(0)){
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if(hit&&hitInfo.transform.gameObject.tag == "DropCard" ){
				Debug.Log("Hit: "+hitInfo.transform.gameObject.name);
				GameObject button = (GameObject)Instantiate(buttonPrefab);
				//button.name = "b";
				button.transform.SetParent(panel,false);
				isPickup = true;
				Destroy(gameObject);
			}
		}
	}
}
