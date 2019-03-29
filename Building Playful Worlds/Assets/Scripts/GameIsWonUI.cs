using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameIsWonUI : MonoBehaviour
{
    public GameObject gameWonWindow;
    private void Awake()
    {
        gameWonWindow.SetActive(false);
    }

    private void Update()
    {
        if (FindObjectOfType<GameManager>().gameWon == true)
        {
            gameWonWindow.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("ENTER WAS PRESSED");
                gameWonWindow.SetActive(false);
                FindObjectOfType<GameManager>().Restart();
            }

        }
    
    }

    
}
