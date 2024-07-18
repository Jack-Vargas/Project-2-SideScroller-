using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSeed : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public Rigidbody2D rb;

    void OnTriggerEnter2D()
        {
               GameObject Player = GameObject.FindWithTag("Player");
               Debug.Log("now");
               Player.transform.position = gameObject.transform.position;
               Destroy(gameObject);
        }

    void Start()
    {
        rb.velocity = transform.right * speed;
    }
}
