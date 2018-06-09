using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour {

    public GameObject TheEnemy;
    public int EnemyHealth = 10;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update ()
    {
        if(EnemyHealth <= 0)
        {
            StartCoroutine(DeathSpider());
        }
	}

    IEnumerator DeathSpider()
    {
        TheEnemy.GetComponent<Animation>().Play("die");
        yield return new WaitForSeconds(0.8f);
        Destroy(gameObject);
    }
}
