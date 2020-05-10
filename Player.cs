using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    Vector2 movement;
    Vector2 movePos;

    void Start()
    {
        
    }

   
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");      
        movement.y = Input.GetAxisRaw("Vertical");
        movePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }
    void FixedUpdate() {

        rb.MovePosition(rb.position + movement * Speed * Time.deltaTime);
        Vector2 lookto = movePos - rb.position;
        float angle = Mathf.Atan2(lookto.y, lookto.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
         
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zombie")
        {
            GameControl.Hleath -= 0.05f;
        }


    }
}
