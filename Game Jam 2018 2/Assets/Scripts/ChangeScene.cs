using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void StartCreditos()
    {
        SceneManager.LoadScene("Credits");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartPause()
    {
        SceneManager.LoadScene("Pause");
    }
}