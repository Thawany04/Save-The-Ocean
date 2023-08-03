using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler : MonoBehaviour
{
    public static Controler intance;

    public int lixos;

    public Text TextLixo;
    
    
    public GameObject chave;
    
    void Awake()
    {
        intance = this;
    }
    void Update()
    {
        coletarchave();
    }

    public void updateLixos(int value)
    {
        lixos += value;
        TextLixo.text = lixos.ToString();
    }
    
    
    void coletarchave()
    {
        if (lixos == 9)
        {
            chave.gameObject.SetActive(true);
        }
    }
}
