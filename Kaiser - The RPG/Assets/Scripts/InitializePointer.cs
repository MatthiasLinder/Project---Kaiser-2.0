using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePointer : MonoBehaviour {

    public GameObject SetPointer;

	void Start ()
    {
        Pointer.PointerTarget = SetPointer;
    }
	
}
