using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoor : MonoBehaviour
{

    private GameObject CurrentDoor;
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CurrentDoor != null)
            transform.position = CurrentDoor.GetComponent<Door>().GetDestination().position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.CompareTag("Door"))
        {
            CurrentDoor = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            if (collision.gameObject == CurrentDoor)
            {
                CurrentDoor = null;
            }
        }
    }
}
