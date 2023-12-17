using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }

    public void Level0()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitAK()
    {
        Application.Quit();
    }
}
