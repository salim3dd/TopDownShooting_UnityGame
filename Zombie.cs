using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    Transform PlayerPos;
    float enemySpeed = 2.5f;
    Rigidbody2D rb;
    Vector2 movement;
    void Start()
    {
        PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
        Vector3 direction = PlayerPos.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

    }
    void FixedUpdate() {
        rb.MovePosition((Vector2)transform.position + (movement * enemySpeed * Time.deltaTime));
    }
}
