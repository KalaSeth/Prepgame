using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
    public bool IsMommy;

    public bool JanuCall;
    bool End;

    float Counter;
    public float Mommytimer;

    public GameObject GameWon;
    public GameObject GameWon1;
    public GameObject GameWon2;
    public GameObject GameWon3;
    public GameObject LastTask;

    public GameObject GameLost;

    public AudioSource MAlert;
    public AudioSource HAlert;

    public AudioSource KyaKarre;    

    public Slider Momtt;
  
    private void Start()
    {
        IsMommy = false;
        JanuCall = false;
        End = false;
    }

    private void Update()
    {
        Momtt.value = Counter;
        if (IsMommy == true)
        {
            GameManager.instance.QuestDisplay(5);
            Counter -= Time.deltaTime;

            if (Counter >= 2.7f && Counter <= 3)
            {
                KyaKarre.Play();
            }

            if (Counter <= 0)
            {
                if (End == false)
                {
                    Mommyhere();
                }
              
            }
        }
    }

    public void MainTimer()
    {
        IsMommy = true;
        MAlert.Play();
        HAlert.Play();
    }

    public void StartTimer()
    {
        Invoke("MainTimer", Random.Range(10, 20));
        Counter = Random.Range(10, 20);
        Momtt.maxValue = Counter;

    }

   public void CallCheck(bool Check)
    {
        JanuCall = Check;
    }

    void Won2()
    {
        GameWon1.SetActive(true);
        GameWon2.SetActive(true);
        GameWon3.SetActive(true);
        GameWon.SetActive(false);
    }

    public void Mommyhere()
    {
        if (JanuCall == true)
        {
            HAlert.Stop();
            LastTask.SetActive(false);
            GameLost.SetActive(true);
            End = true;
        }
        else if (JanuCall == false)
        {
            HAlert.Stop();
            GameWon.SetActive(true);
            LastTask.SetActive(false);
            Invoke("Won2", 1.5f);
            End = true;
        }
    }

}
