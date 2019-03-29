using UnityEngine;

public class PotionScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip potionClip;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
            other.GetComponent<PlayerScript>().potionsGathered++;
            audioSource.PlayOneShot(potionClip);
        }
    }
}
