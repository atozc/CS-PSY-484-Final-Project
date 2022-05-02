using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public static bool isGameStarted = false;

    public GameObject StartMenuUI;
    public GameObject HowToPlayUI; 

    // Update is called once per frame
    void Update()
    {

    }

    public void Start()
    {
        StartMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGameStarted = false;
    }

    public void HowToPlay()
    {
        HowToPlayUI.SetActive(true);
        StartMenuUI.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
