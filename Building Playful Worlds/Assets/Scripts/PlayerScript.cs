using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class PlayerScript : MonoBehaviour
{
    public int playerHealth;
    public Image damageImage;
    float damageDisplayTimer;
    public float damageDisplayDelay = 0.2f;
    public bool playerAttacked = false;
    public AudioSource audioSource;
    public AudioClip damageClip;
    public int potionsGathered = 0;
    public int potionsNeededToWin = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Timer()
    {
        if (damageDisplayTimer > 0)
            damageDisplayTimer -= Time.deltaTime;

        else
        {
            damageImage.gameObject.SetActive(false);
            playerAttacked = false;
        }
    }

    public void TakeDamage(int _damageAmount)
    {
        playerHealth -= _damageAmount;
        damageDisplayTimer = damageDisplayDelay;
        damageImage.gameObject.SetActive(true);
        Timer();
        playerAttacked = true;
        audioSource.PlayOneShot(damageClip);
        
        
    }

    public void Update()
    {
        if(playerAttacked == true)
        {
            Timer();
        }

        CheckPlayerDeath();
        CheckIfGameWon();
    }

    public void CheckPlayerDeath()
    {
        if (playerHealth <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    public void CheckIfGameWon()
    {
        if (potionsGathered >= potionsNeededToWin)
        {
            FindObjectOfType<GameManager>().GameWon();
        }
    }

}
