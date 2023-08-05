using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlerScenes : MonoBehaviour
{
    public int level = 1;
public void Menu()

    {
        SceneManager.LoadScene(0);
    }

    public void level1()
    {
        SceneManager.LoadScene(1);
    }

    public void level2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void level3()
    {
        SceneManager.LoadScene(3);
    }
}
