using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy : MonoBehaviour
{
    public Transform playerTransform;
    public Transform fairyTransform;
    public float fairySpeed;
    public float fastDistance;

    // Update is called once per frame
    void Update()
    {
        float directionToPlayer = Vector2.Distance(playerTransform.position, fairyTransform.position);

       if (directionToPlayer >= fastDistance)
        {
            fairySpeed = 6;
        }
       else if (directionToPlayer < fastDistance)
        {
            fairySpeed = 3;
        }

            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, playerTransform.position, fairySpeed * Time.deltaTime);
    }

}
