using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkBench : MonoBehaviour
{
    public GameObject Menu;
    public bool menuReady = false;


    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.GetComponent<Collider2D>().tag == "Player")
        menuReady = true;
    }

    void OnTriggerExit2D()
    {
        menuReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (menuReady == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Menu.active = true;
                Time.timeScale = 0.0f;
            }
        }
        
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Menu.active = false;
            Time.timeScale = 1.0f;
        }
    }   
}
