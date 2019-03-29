
using UnityEngine;
using UnityEngine.UI;

public class StartOfGameUI : MonoBehaviour
{
    public GameObject startOfGameWindow;
    private void Awake()
    {
        startOfGameWindow.SetActive(true);
    }

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ENTER WAS PRESSED");
            startOfGameWindow.SetActive(false);
        }

    }

}
