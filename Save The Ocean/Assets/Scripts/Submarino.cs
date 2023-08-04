using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarino : MonoBehaviour
{
    public int velocity;

    public int vida = 3;

    private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    
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

    public void damege(int dmg)
    {
        vida -= dmg;
        Controler.intance.updatevida(vida);
        
        if(transform.rotation.y == 0)
        {
            transform.position += new Vector3(-0.7f, 0, 0);
        }

        if(transform.rotation.y == 180)
        {
            transform.position += new Vector3(0.7f, 0, 0);
        }
    }
    /*private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Inimigo")
        {
            damege();
        }
    }*/
    
}
