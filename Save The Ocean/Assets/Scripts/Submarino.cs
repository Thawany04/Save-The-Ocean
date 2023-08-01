using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarino : MonoBehaviour
{
    public int velocity;

    private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        float movement = Input.GetAxis("Vertical");
        rig.velocity = new Vector2(movement * velocity, rig.velocity.y);

        float DeS = Input.GetAxis("Horizontal");
        rig.velocity = new Vector3(DeS * velocity, rig.velocity.x);
        
        if (DeS > 0)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if (DeS < 0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
    
}
