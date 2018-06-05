using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float PanSpeed = 80f;
    public float PanBorderThicknes = 10f;
    //public Vector2 PanLimit;
    public float ScrollSpeed = 20f;

    //public float MinimumY = 20f;
    //public float MaximumY = 120f;

    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - PanBorderThicknes)
        {
            pos.z += PanSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= PanBorderThicknes)
        {
            pos.z -= PanSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - PanBorderThicknes)
        {
            pos.x += PanSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= PanBorderThicknes)
        {
            pos.x -= PanSpeed * Time.deltaTime;
        }

        float Scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= Scroll * ScrollSpeed * 100f * Time.deltaTime;

        //pos.x = Mathf.Clamp(pos.x, -PanLimit.x, PanLimit.x);
        //pos.y = Mathf.Clamp(pos.y, MinimumY, MaximumY);
        //pos.z = Mathf.Clamp(pos.z, -PanLimit.y, PanLimit.y);

        transform.position = pos;
    }
}
