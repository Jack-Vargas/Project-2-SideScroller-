using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EStats : MonoBehaviour
{
    public int health;
    public GameObject gear;
    public int dropNum;



    void Update()
    {
        if (health <= 0) 
        {
            Drop();
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void Drop()
    {
        int dropNum = Random.Range (0, 2);
        if (dropNum == 1)
        {
            Instantiate(gear, gameObject.transform.position, gameObject.transform.rotation);
        }
    }

}
