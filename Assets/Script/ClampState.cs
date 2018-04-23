using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampState : MonoBehaviour {

    public Text stateLabel;
	
	// Update is called once per frame
	void Update () {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        stateLabel.transform.position = namePos;
	}
}
