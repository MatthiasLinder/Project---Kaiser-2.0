﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour {

    public GameObject TheSword;
    public int SwordStatus;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && SwordStatus == 0 && AttackBlocker.BlockSword == 0)
        {
            StartCoroutine(SwingSwordFunction());
        }
    }

    IEnumerator SwingSwordFunction()
    {
        SwordStatus = 1;
        TheSword.GetComponent<Animation>().Play("ElvenSwordAnimation");
        SwordStatus = 2;
        yield return new WaitForSeconds(1.0f);
        SwordStatus = 0;
    }

}
