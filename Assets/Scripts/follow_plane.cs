using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_plane : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(7, 0, -10);

    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(plane.transform.position.x + offset.x, transform.position.y, transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

        // transform.Translate(plane.transform.position + offset) ;
    }
}
