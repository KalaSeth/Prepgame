using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3 : MonoBehaviour
{
    public GameObject Gamewon;
    public GameObject GameLost;
    public GameObject Lasttask;

    public Slider RGSlider;

    public AudioSource Alert;
    public AudioSource HAlert;

    float counter;
    public float maintime;

    public bool IsDancing;
    bool Startmomy;
    
    // Start is called before the first frame update
    void Start()
    {
        IsDancing = false;
        Startmomy = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Startmomy == true)
        {
            counter -= Time.deltaTime;
            

            if (counter <= 0)
            {
                GameCheck();

            }

        }
    }

    void Maintt()
    {
        counter = 4;
    }
    void momystarter()
    {
        Alert.Play();
        HAlert.Play();
        Startmomy = true;
        Maintt();
    }

    void GameCheck()
    {
        HAlert.Stop();
       if (IsDancing == true)
        {
            GameLost.SetActive(true);
            Lasttask.SetActive(false);
        }
        else if (IsDancing == false)
        {
            Gamewon.SetActive(true);
            Lasttask.SetActive(false);
        }
       
        CancelInvoke();
        Startmomy = false;
    }

    public void DCheck(bool Check)
    {
        IsDancing = Check;

        Invoke("momystarter", Random.Range(10,15));
    }
}
