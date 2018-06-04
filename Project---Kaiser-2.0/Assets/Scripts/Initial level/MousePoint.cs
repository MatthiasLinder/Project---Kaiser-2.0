using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour {

    RaycastHit hit;

    private float RaycastLength = 1000;

    void Update()
    {
        GameObject Tree = GameObject.Find("Tree");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, RaycastLength))
        {
            Debug.Log(hit.collider.name);
            if(hit.collider.name == "TerrainMain")
            {
                Tree.transform.position = hit.point;
            }
        }

        Debug.DrawRay(ray.origin, ray.direction * RaycastLength, Color.blue);
    }
}
