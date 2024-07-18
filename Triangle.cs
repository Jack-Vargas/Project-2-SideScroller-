using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public GameObject Door; 

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hi");
        Destroy(Door);
    }
}
