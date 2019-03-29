using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverWindow;
    private void Awake()
    {
        gameOverWindow.SetActive(false);
    }

    private void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            gameOverWindow.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("ENTER WAS PRESSED");
                gameOverWindow.SetActive(false);
                FindObjectOfType<GameManager>().Restart();
            }

        }

    }


}