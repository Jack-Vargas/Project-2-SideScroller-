using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{

    public int damage = 1;
    public Transform PlayerTransform;
    public float goombaSpeed;
    public Rigidbody2D rb2D;

    void Update()
    {
        if (PlayerTransform.position.x <= gameObject.transform.position.x)
        {
            //move left
            rb2D.velocity = new Vector2(goombaSpeed * -1, rb2D.velocity.y);
        }
        else if (PlayerTransform.position.x > gameObject.transform.position.x)
        {
            //move right
            rb2D.velocity = new Vector2(goombaSpeed, rb2D.velocity.y);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Attack();
        }
    }

    void Attack()
    {
        PlayerManeger TargetScript = FindObjectOfType<PlayerManeger>();
        TargetScript.TakeDamage(damage);
    }
}
