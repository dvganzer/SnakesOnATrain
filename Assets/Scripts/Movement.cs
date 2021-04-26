﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public  float speed = 10f;
    public float jumpVelocity = 9f;
    public Rigidbody2D rb;
    Vector2 move;
    public Animator animator;
   public GameObject player;
    public GameObject ladder;
   
    void Update()
    {
        rb = transform.GetComponent<Rigidbody2D>();

        move.x = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Horizontal", move.x);
       
        animator.SetFloat("Speed", move.sqrMagnitude);

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool("Shoot", true);
            speed = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Shoot", false);
            speed = 10f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            rb.velocity =  Vector2.up * jumpVelocity;
            Debug.Log("Jump");

        }
       
    }
    private void FixedUpdate()
    {
       rb.AddForce(move * speed);
       

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == ladder)
        {
            jumpVelocity = 14f;
        }
        else if(collision.gameObject != ladder)
        {
            jumpVelocity = 9f;
        }
    }


}
