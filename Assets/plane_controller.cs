using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_controller : MonoBehaviour
{
    // public float speed;
    // public float rotationSpeed;
    // public float verticalInput;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     // get the user's vertical input
    //     verticalInput = Input.GetAxis("Vertical");

    //     // move the plane forward at a constant rate
    //     transform.Translate(Vector3.right * speed * Time.deltaTime);

    //     // tilt the plane up/down based on up/down arrow keys
    //     transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput * -1);
    // }

    public float speed;            // Speed of the plane
    public float tiltAmount;       // How much the plane tilts when changing height
    public float verticalInput;    // To capture W/S input
    public float maxTilt = 45f;    // Maximum angle to tilt


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
