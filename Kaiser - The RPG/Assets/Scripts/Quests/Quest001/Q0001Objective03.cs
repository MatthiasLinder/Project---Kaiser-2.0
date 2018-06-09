using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q0001Objective03 : MonoBehaviour {

    public float TheDistance;
    public GameObject FakeSword;
    public GameObject RealSword;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheObjective;
    public int CloseObjective;
    public GameObject SetPointer;

    public GameObject Enemy1;
    public GameObject Enemy2;


    public GameObject ChestBlock;
    public GameObject QuestComplete;
    public GameObject ExclamationMark;

	void Update ()
    {
        TheDistance = PlayerCasting.DistanceFromTarger;
        if(CloseObjective == 3)
        {
            if (TheObjective.transform.localScale.y <= 0.0f)
            {
                CloseObjective = 0;
                TheObjective.SetActive(false);
            }
            else
            {
                TheObjective.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
            }
        }
	}

    void OnMouseOver()
    {
         if(TheDistance <= 3)
        {
            ActionText.GetComponent<Text>().text = "Take Sword";
            ActionText.SetActive(true);
            ActionDisplay.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                FakeSword.SetActive(false);
                RealSword.SetActive(true);
                ChestBlock.SetActive(true);
                CloseObjective = 3;
                ActionText.SetActive(false);
                ActionText.SetActive(false);
                ExclamationMark.SetActive(true);
                QuestComplete.SetActive(true);
                Enemy1.SetActive(true);
                Enemy2.SetActive(true);
                Pointer.PointerTarget = SetPointer;
            }
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }


}
