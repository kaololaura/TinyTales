using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSourceAchtergrondmuziek;
    public AudioClip gameWonClip;
    public AudioClip gameOverClip;
    public AudioClip backgroundClip;
    public bool gameWon = false;
    public bool gameHasEnded = false;
    public float restartDelay = 1f;


    public void Awake()
    {
        audioSourceAchtergrondmuziek.clip = backgroundClip;
    }
    public void GameWon()
    {
        if (gameWon == false)
        {
            Debug.Log("GameWon");
            gameWon = true;
            audioSourceAchtergrondmuziek.mute = true;
            audioSource.PlayOneShot(gameWonClip);
        }
    }

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("GameOver");
            gameHasEnded = true;
            audioSourceAchtergrondmuziek.mute = true;
            audioSource.PlayOneShot(gameOverClip);
            
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
