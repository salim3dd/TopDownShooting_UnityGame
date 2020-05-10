using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject Bullet;
    float BulletSpeed = 20f;
    void Start()
    {
        
    }
   
    void Update()
    {

        if (Input.GetButtonDown("Fire1")) {
            GameObject fire = Instantiate(Bullet, transform.position, transform.rotation);
            Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);

        }


    }
}
