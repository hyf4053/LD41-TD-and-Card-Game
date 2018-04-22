using UnityEngine;
using UnityEngine.UI;

public class UIScripts : MonoBehaviour {

    public BuildManager bm;
    public Button tower;
    bool buildOpen = true;
	
    public void ActiveteBuilding(Button pressedBtn)
    {
        bm.ActivateBuildingmode();
        switch (pressedBtn.name)
        {
            case "BuildTower":
                bm.SelectBuilding(0);
                break;
        }
    }
    // Update is called once per frame
    void Update () {
      
	}
}
