using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDamage : MonoBehaviour
{
    public GameManager Manager;

    public GameObject Postprocess;
    public void Start()
    {
      

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Postprocess.gameObject.SetActive(true);
            Invoke("offProcess", 2f);
            EnemyType Enemy = other.gameObject.GetComponent<EnemyType>();

            if (Enemy.enemy == EnemyCateg.Enemy1)
            {
                Manager.currentHealth -= 20;
            }

            if (Enemy.enemy == EnemyCateg.Enemy2)
            {
                Manager.currentHealth -= 35;
            }
            if (Enemy.enemy == EnemyCateg.Enemy3)
            {
                Manager.currentHealth -= 50;
            }
        }
        
    }

   public void offProcess()
    {
        Postprocess.gameObject.SetActive(false);
    }
}
