using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsHandler : MonoBehaviour
{
    public void goToGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void goToSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
