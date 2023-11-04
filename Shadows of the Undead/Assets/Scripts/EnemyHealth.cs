using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] public float hitPoint = 100f; 
    bool isDead = false;

    public bool IsDead ()
    {
        return isDead;
    }
    
    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnEnemyDamage");
        hitPoint -= damage;
        if(hitPoint <= 0)
            {
                Die();
            }
    }

    private void Die()
    {   
        if(isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("Die");
    }
}
