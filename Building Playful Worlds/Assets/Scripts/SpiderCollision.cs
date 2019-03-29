using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderCollision : MonoBehaviour
{
    public bool playerCollide;
    public int playerHealth;
    public Transform player;

    public float AttackDelay = 1;
    bool canAttack = true;
    float attackTimer;

    void Start()
    {
        attackTimer = 0;

    }


    void Update()
    {
        if (playerCollide == true && canAttack)
        {
            playerHealth -= 5;
            attackTimer = AttackDelay;
            canAttack = false;
            playerCollide = false;
        }

        else
        {

        }

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
}