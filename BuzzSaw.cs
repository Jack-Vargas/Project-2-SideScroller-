using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzSaw : MonoBehaviour
{
    public float sawSpeed;
    [SerializeField] GameObject P1;
    [SerializeField] GameObject P2;
    private GameObject nextPosition;

    void Start()
    {
        nextPosition = P1;
    }

    void Update()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, nextPosition.transform.transform.position, sawSpeed * Time.deltaTime);

        if (transform.position == P1.transform.position)
        {           
            nextPosition = P2;
        }
        else if (transform.position == P2.transform.position)
        {
            nextPosition = P1;
        }
    }
}
