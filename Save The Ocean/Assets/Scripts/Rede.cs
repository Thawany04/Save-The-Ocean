using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rede : MonoBehaviour
{
    private int damege = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Submarino>().damege(damege);
        }
    }
}
