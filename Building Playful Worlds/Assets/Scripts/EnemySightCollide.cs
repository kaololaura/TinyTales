using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySightCollide : MonoBehaviour
{
    public EnemySightScript spinScript;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        { 
            spinScript.playerInSight = true;
        }
    }
}
