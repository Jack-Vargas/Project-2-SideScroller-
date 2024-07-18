using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = -20f;
    public int damage = 2;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.GetComponent<Collider2D>().tag == "Enemy")
        {
            EStats EStats = hitInfo.GetComponent<EStats>();
            if (EStats != null)
            {
                EStats.TakeDamage(damage);
            }
        }
            Destroy(gameObject);
    }
}
