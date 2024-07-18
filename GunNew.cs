using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunNew : MonoBehaviour
{
    public Transform firePoint;
    public float fireRate;
    public GameObject playerProjectile;
    private float timeToNextShot;
    public float projectileSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.J) && Time.time > timeToNextShot)
        {
            timeToNextShot = Time.time + 1f / fireRate;
            GameObject projectile = Instantiate(playerProjectile, firePoint.transform.position, firePoint.transform.rotation);
            Rigidbody Rb = projectile.GetComponent<Rigidbody>();
            Rb.velocity = projectile.transform.forward * projectileSpeed;
            Destroy(projectile, 5f);
        }
    }
}
