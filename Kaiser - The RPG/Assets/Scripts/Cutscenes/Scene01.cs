using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01 : MonoBehaviour {

    public GameObject Camera1;
    //public GameObject Camera2;
    //public GameObject Camera3;
    public GameObject FadeOut;
    public GameObject FadeIn;
    public GameObject ThePlayer;
    public GameObject LifeBar;
    public GameObject Cursor;

    public GameObject KaiserPresents;
    public GameObject KAISERREICH;
    public GameObject GottMitUns;


	void Start () {
        StartCoroutine(CutSceneStart());
	}
	
	IEnumerator CutSceneStart()
    {
        yield return new WaitForSeconds(9);
        //Camera2.SetActive(true);
        //Camera1.SetActive(false);
        //FadeIn.SetActive(false);
        //yield return new WaitForSeconds(10);
        //Camera3.SetActive(true);
        //Camera2.SetActive(false);
        //yield return new WaitForSeconds(4);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        Camera1.SetActive(false);

        ThePlayer.SetActive(true);

        KaiserPresents.SetActive(false);
        KAISERREICH.SetActive(false);
        GottMitUns.SetActive(false);

        FadeIn.SetActive(true);
        FadeOut.SetActive(false);

        LifeBar.SetActive(true);
        Cursor.SetActive(true);
        //Camera3.SetActive(false);
    }
}
