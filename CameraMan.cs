using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{
    public Transform playerTransform;
    public Transform cameraTransform;
    public float cameraSpeed;
    public GameObject camera;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y, -10f);
        float directionToPlayer = Vector2.Distance(playerTransform.position, cameraTransform.position);
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, playerTransform.position, cameraSpeed * Time.deltaTime);
    }
}
