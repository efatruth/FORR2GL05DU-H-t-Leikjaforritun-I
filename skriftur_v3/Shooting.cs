﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 4000f;
    
    // Uppfærsla er kölluð einu sinni í hvern ramma
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("skjOtttttttt");       
           
            //Game Object instBullet = Staðfesta (byssukúla, umbreytingarstaða, Quaternion auðkenni) sem Game Object;
            GameObject instBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(transform.forward * speed);
            Destroy(instBullet, 0.5f);//kúl eytt eftir 0.5sek
           
        }
    }
}
