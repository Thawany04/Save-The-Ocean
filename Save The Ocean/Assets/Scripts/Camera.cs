using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float suavidade;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Submarino").transform;
    }

    void LateUpdate()
    {
        if (player.position.x >= -5 && player.position.x <= 68.52f)
        {
            Vector3 following = new Vector3(player.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, following, suavidade * Time.deltaTime);
        }
    }
}
