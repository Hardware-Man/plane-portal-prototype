using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plane_controller : MonoBehaviour
{
    public float speed;            // Speed of the plane
    public float tiltAmount;       // How much the plane tilts when changing height
    public float verticalInput;    // To capture W/S input
    public float maxTilt = 45f;    // Maximum angle to tilt

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);

        // Check if the plane collided with a wall
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Collision with Wall detected!");

            // PlayerPrefs.SetString("LastLoadedScene", SceneManager.GetActiveScene().name);
            // PlayerPrefs.Save();

            // Attempt to load the Game Over scene
            Debug.Log("Loading Game Over Scene...");
            SceneManager.LoadScene("GameOver");
        }

        if (collision.gameObject.tag == "finish-line")
        {
            Debug.Log("Collision with finish line detected!");

            // Attempt to load the Game Over scene
            Debug.Log("Loading you win Scene...");
            SceneManager.LoadScene("YouWin");
        }
    }

    void Update()
    {
        // Get the user's vertical input (W = 1, S = -1)
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Move the plane up/down based on W/S keys
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

        // Tilt the plane based on vertical input (rotate along the Z-axis for 2D tilt effect)
        float tilt = Mathf.Clamp(verticalInput * tiltAmount, -maxTilt, maxTilt); // Limit the tilt angle
        transform.rotation = Quaternion.Euler(0, 0, tilt);

    }
}
