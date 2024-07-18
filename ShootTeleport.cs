using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTeleport : MonoBehaviour
{
    public Transform firePoint;
    public GameObject TeleportSeed;
    public float projectileSpeed;
    public float timeToNextShot;
    public float fireRate;

    void Update()
    {
        if (Input.GetKey(KeyCode.E) && Time.time > timeToNextShot)
        {
            timeToNextShot = Time.time + 1f / fireRate;
            GameObject tS = Instantiate(TeleportSeed, firePoint.transform.position, firePoint.transform.rotation);
            Rigidbody2D Rb = tS.GetComponent<Rigidbody2D>();
            Rb.velocity = tS.transform.forward * projectileSpeed;
        }
    }
}
