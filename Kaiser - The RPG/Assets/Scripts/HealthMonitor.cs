using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMonitor : MonoBehaviour {

    public static int HealthValue;
    public int InternalHealth;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;

    void Start () {
        HealthValue = 3;
	}
	
	void Update () {
        InternalHealth  =  HealthValue;


        if (HealthValue >= 1)
        {
            Heart1.SetActive(true);
        }
        if (HealthValue >= 2)
        {
            Heart2.SetActive(true);
        }
        if (HealthValue >= 3)
        {
            Heart3.SetActive(true);
        }
        if (HealthValue >= 4)
        {
            Heart4.SetActive(true);
        }
        if (HealthValue >= 5)
        {
            Heart5.SetActive(true);
        }

        if (HealthValue < 1)
        {
            Heart1.SetActive(false);
        }
        if (HealthValue < 2)
        {
            Heart2.SetActive(false);
        }
        if (HealthValue < 3)
        {
            Heart3.SetActive(false);
        }
        if (HealthValue < 4)
        {
            Heart4.SetActive(false);
        }
        if (HealthValue < 5)
        {
            Heart5.SetActive(false);
        }


        if(HealthValue < 1)
        {
            SceneManager.LoadScene(2);
        }
    }
}
