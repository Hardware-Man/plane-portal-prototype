using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float speed = 20;
    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
    }
}
