using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    private string previousSceneName; // To store the name of the previous scene

    // Start is called before the first frame update
    void Start()
    {
        // // Store the name of the previous scene (main game scene) before the GameOver scene is loaded
        // previousSceneName = PlayerPrefs.GetString("LastLoadedScene", "MainGameScene"); // Default to "MainGameScene"
    }

    // Update is called once per frame
    void Update()
    {
        // Detect any key press or mouse click
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RestartGame(); // Call the restart function
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            MainMenu(); // Call the restart function
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Controls(); // Call the restart function
        }
    }

    // Function to reload the previous scene
    public void RestartGame()
    {
        SceneManager.LoadScene("FromClass");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Controls()
    {
        SceneManager.LoadScene("ControlsMenu");
    }
    
}
