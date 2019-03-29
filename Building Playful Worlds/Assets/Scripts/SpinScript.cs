using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    private string colObject;

    public int damageAmount = 5;

    public float AttackDelay = 1;

    public float SpiderHealth = 60f;

    bool canAttack = true;
    float attackTimer;

    void Start()
    {
        attackTimer = 0;

    }


    void Update()
    {

        if (!canAttack)
            Timer();

    }

    void Timer()
    {
        if (attackTimer > 0)
            attackTimer -= Time.deltaTime;

        else
        {
            canAttack = true;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        colObject = col.gameObject.tag;
        if (colObject == "Player")
        {
            TryToAttackPlayer(col.gameObject.GetComponent<PlayerScript>());
        }
    }

    void TryToAttackPlayer(PlayerScript _playerScript)
    {
        if (canAttack)
        {
            _playerScript.TakeDamage(damageAmount);
            attackTimer = AttackDelay;
            canAttack = false;
        }
    }

    public void TakeDamage(float amount)
    {
        SpiderHealth -= amount;
        if (SpiderHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
