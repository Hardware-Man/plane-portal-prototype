using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpawn : MonoBehaviour
{
    public GameObject spawn_orange;
    public GameObject spawn_blue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject orangePortal = GameObject.FindGameObjectWithTag("orange-portal");

            if (!orangePortal)
            {
                spawn_orange = Instantiate(spawn_orange, new Vector3(mousePos.x, mousePos.y, 0), Quaternion.identity);
            }

            orangePortal.transform.position = new Vector3(mousePos.x, mousePos.y, 1);
        }
        if(Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject bluePortal = GameObject.FindGameObjectWithTag("blue-portal");

            if (!bluePortal)
            {
                spawn_blue = Instantiate(spawn_blue, new Vector3(mousePos.x, mousePos.y, 0), Quaternion.identity);
            }

            bluePortal.transform.position = new Vector3(mousePos.x, mousePos.y, 1);
        }
    }
}
