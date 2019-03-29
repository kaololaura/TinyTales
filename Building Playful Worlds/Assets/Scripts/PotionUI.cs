
using UnityEngine;
using UnityEngine.UI;

public class PotionUI : MonoBehaviour
{
    public Text potionText;
    public PlayerScript playerScript;

    private void Update()
    {
        potionText.text = "Potions: " + playerScript.potionsGathered;

    }
}
