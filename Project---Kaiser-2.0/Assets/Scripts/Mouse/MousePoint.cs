using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour {

    /*
     YOU HAVE TO SET A MAIN CAMERA FOR THIS.
      */
    RaycastHit hit;

    private float RaycastLength = 500;

    public GameObject GameCursor;

    void Update () {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, RaycastLength))
        {
            //Debug.Log(hit.collider.name);
            if(hit.collider.name == "Primary Terrain")
            {
                if (Input.GetMouseButtonDown(1))
                {
                    //0 left mouse button
                    //1 right mouse button
                    //2 middle mouse button
                    GameObject GameCursorObj = Instantiate(GameCursor, hit.point, Quaternion.identity) as GameObject;
                    GameCursorObj.name = "GameCursor Instanciated";
                }

            }
        }

        Debug.DrawRay(ray.origin, ray.direction * RaycastLength, Color.green);
		
	}
}
