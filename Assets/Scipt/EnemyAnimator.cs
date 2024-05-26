using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    public Animator enemyAnimation;
    public EnemyMovement movement;

    public void Start()
    {
        enemyAnimation = GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Base"))
        {
            movement.movementSpeed = 0;
            enemyAnimation.SetBool("IsAttack", true);
        }
    }
}
