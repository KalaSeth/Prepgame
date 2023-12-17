using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
    public bool IsMommy;

    public bool JanuCall;

    float Counter;
    public float Mommytimer;

    public GameObject GameWon;
    public GameObject GameWon1;
    public GameObject GameLost;
    public GameObject GameLost1;

    private void Start()
    {
        IsMommy = false;
        JanuCall = false;
    }

    private void Update()
    {
        if (IsMommy == true)
        {
            Counter -= Time.deltaTime;

            if (Counter <= 0)
            {
                Mommyhere();
            }
        }
    }

    public void StartTimer()
    {
        IsMommy = true;
        Counter = Random.Range(10, 20);

    }

    void WonUI()
    {
        GameWon1.SetActive(true);
    }
    void lOSTUI()
    {
        GameLost1.SetActive(true);
    }

    public void Mommyhere()
    {
        if (JanuCall == true)
        {
            GameLost.SetActive(true);
            Invoke("lOSTUI", 1.5f);
        }
        else if (JanuCall == false)
        {
            GameWon.SetActive(true);
            Invoke("WonUI", 1.5f);
        }
    }

}
