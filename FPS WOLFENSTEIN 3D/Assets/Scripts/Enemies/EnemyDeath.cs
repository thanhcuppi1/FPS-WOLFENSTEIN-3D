using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;
 
    void DamageEnemy(int damageAmout)
    {
        enemyHealth -= damageAmout;
    }

    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("Death");
            enemyAI.SetActive(false);
            theEnemy.GetComponent<LookPlayer>().enabled = false;
            GlobalScore.scoreValue += 1000;
        }
    }
}
