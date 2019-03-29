
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text healthText;
    public PlayerScript playerScript;


    private void Update()
    {
        healthText.text = "Health: " + playerScript.playerHealth;
        
    }
}
