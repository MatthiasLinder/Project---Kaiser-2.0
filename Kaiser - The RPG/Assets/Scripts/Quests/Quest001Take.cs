using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Quest001Take : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject NoticeCam;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarger;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 1f)
        {
            AttackBlocker.BlockSword = 1;
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 1f)
            {
                Screen.lockCursor = false;
                Cursor.visible = true;

                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);

                UIQuest.SetActive(true);
                NoticeCam.SetActive(true);

                ThePlayer.SetActive(false);
            }
        }
        //ActionDisplay.SetActive(false);
        //ActionText.SetActive(false);
    }

    void OnMouseExit()
    {
        AttackBlocker.BlockSword = 0;
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}