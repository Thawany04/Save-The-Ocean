using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lixos : MonoBehaviour
{
    public int lixo;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Submarino")
        {
            Controler.intance.updateLixos(lixo);
            Destroy(gameObject);
        }
    }

}
