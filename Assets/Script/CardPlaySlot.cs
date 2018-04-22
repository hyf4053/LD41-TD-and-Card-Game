
using UnityEngine;

public class CardPlaySlot : MonoBehaviour {

    public GameObject N,S,W,E;
    public bool upSlot, downSlot, leftSlot, rightSlot;
    public Color hoverColor,startcolor;
    public Vector3 offset;
    public GameObject tower;
    
    private Renderer rend;
    // Use this for initialization
    void Start () {
        upSlot = false;
        downSlot = false;
        leftSlot = false;
        rightSlot = false;
        SlotClear();
        rend = GetComponentInChildren<Renderer>();
        startcolor = rend.material.color;
        hoverColor = Color.gray;
        offset.x = 0;
        offset.y = 0.3f;
        offset.z = 0;
    }

    private void OnMouseDown()
    {
        if(tower != null)
        {
            Debug.Log("We can't build here ! - TODO: display on screen");
            return;
        }

        //Build a turret
        GameObject towerToBuild = TowerManager.instance.GetTowerToBuild();
        tower = (GameObject)Instantiate(towerToBuild, transform.position+ offset, transform.rotation);

    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startcolor;
    }

    void SlotClear()
    {
        //TODO: Clean all slot
    }



	// Update is called once per frame
	void Update () {
		
	}
}
