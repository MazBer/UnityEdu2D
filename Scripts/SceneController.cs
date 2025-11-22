using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.H))
        // {
        //     SceneManager.LoadScene(0);
        // }
        //
        // if (Input.GetKeyDown(KeyCode.G))
        // {
        //     SceneManager.LoadScene(1);
        // }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                SceneManager.LoadScene(1);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    
    public void LoadHomeScene()
    {
        int homeScene = 0;
        SceneManager.LoadScene(homeScene);
    }

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
