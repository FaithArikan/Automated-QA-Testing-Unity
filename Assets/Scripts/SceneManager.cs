using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManager : MonoBehaviour
{
    public void OpenMainMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    public void OpenGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    public void ExitGameButton()
    {
        Application.Quit();
        Debug.Log("The game is closed");
    }
}
