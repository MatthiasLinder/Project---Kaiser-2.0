using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParentObject : MonoBehaviour {

    void DestroytObject()
    {
        Destroy(this.gameObject.transform.parent.gameObject);
    }
}
