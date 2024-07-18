using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
       
        if (hitInfo.GetComponent<CapsuleCollider2D>().tag == "Player")//if you want to call for either of 2 tags on the same if statement do something like collision.gameObject.tag == "Target" || collision.gameObject.tag == "Enemy" 
        {
            Timer TargetScript = FindObjectOfType<Timer>();
                TargetScript.StopTime();           
        }
    }
}
