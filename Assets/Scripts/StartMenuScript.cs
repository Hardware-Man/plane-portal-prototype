using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Detect any key press or mouse click
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame(); // Call the restart function
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Controls(); // Call the restart function
        }

    }

    // Function to reload the previous scene
    public void StartGame()
    {
        SceneManager.LoadScene("yy");
    }

    public void Controls()
    {
        SceneManager.LoadScene("ControlsMenu");
    }
}
