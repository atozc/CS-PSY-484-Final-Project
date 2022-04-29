using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;

    public GameObject pauseMenuUI;
    public GameObject HowToPlayUI; 

    // Update is called once per frame
    void Update()
    {

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void Instructions()
    {
        HowToPlayUI.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("My Virtual Zoo");
        Resume();
    }
    public void Back()
    {
        pauseMenuUI.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
