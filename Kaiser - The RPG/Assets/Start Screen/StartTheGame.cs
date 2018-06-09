using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGame : MonoBehaviour {

    public GameObject FadeOut;

    void Start()
    {
        Screen.lockCursor = false;
    }

    public void LoadInScene()
    {
        StartCoroutine(StartGame());
    }
    

    IEnumerator StartGame()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
