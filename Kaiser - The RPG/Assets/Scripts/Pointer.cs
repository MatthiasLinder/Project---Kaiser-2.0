using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

    public static GameObject PointerTarget;

	void Update ()
    {
        transform.LookAt(PointerTarget.transform);
    }
}
