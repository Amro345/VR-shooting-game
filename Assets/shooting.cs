using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletoffset;
    Rigidbody bulletRB;
    public void shoot()
    {
        GameObject bulletprefab = Instantiate(bullet, bulletoffset.position, bulletoffset.rotation);
        bulletRB = bulletprefab.GetComponent<Rigidbody>();
        bulletRB.AddForce(bulletoffset.forward * 100,ForceMode.Impulse);
    }
}
