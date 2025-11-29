using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Javelin : WeaponAttack
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 5f;

    public override void Attack()
    {
        GameObject bulletGo = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
        bulletGo.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }

}
