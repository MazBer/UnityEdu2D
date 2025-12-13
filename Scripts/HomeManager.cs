using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SettingsMenu;

    private void Start()
    {
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings()
    {
        Debug.Log("Open Settings");
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void Back()
    {
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
