using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float launchVelocity = 2000f;
    [SerializeField] float fireRate = 0.5f;

    float nextFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * launchVelocity);
            Destroy(newBullet, 3f);
        }
    }
}
