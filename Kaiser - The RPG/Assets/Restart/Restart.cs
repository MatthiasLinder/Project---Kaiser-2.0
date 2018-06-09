using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    void Start()
    {
        Screen.lockCursor = false;
    }

    public void GameRestart()
    {
        StartCoroutine(RestartGame());
    }


    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }
}
