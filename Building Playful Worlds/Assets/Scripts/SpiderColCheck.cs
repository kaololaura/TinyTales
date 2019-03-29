using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderColCheck : MonoBehaviour
{
    public SpiderCollision spinAttackScript;
    private string colObject;

    private void OnCollisionEnter(Collision col)
    {
        colObject = col.gameObject.tag;
        if (colObject == "Player")
        {
            spinAttackScript.playerCollide = true;
            col.gameObject.GetComponent<PlayerScript>().TakeDamage(10);
        }
    }
}
