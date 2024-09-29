using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public float distance = 0.2f;
    public bool isOrange = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.gameObject.tag != "Player") return;

        Vector2 destination;
        GameObject portalDestObj;

        if (isOrange) portalDestObj = GameObject.FindGameObjectWithTag("blue-portal");
        else portalDestObj = GameObject.FindGameObjectWithTag("orange-portal");

        if(!portalDestObj) return;

        destination = portalDestObj.GetComponent<Transform>().position;

        if (Vector2.Distance(transform.position, entity.transform.position) > distance)
        {
            entity.transform.position = destination;
        }
    }
}
