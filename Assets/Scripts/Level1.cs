using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{
    public GameObject LevelWon;
    public GameObject LevelWonMain;
    public GameObject LevelLost;
    public GameObject LevelLost1;
    public GameObject LevelUI;

    public bool IsStudy;
    bool Mommycoming;
    bool StartMommy;

    public float BoobitaTimer;
    float CountDalBable;
    int MommyCount;

    [SerializeField] Slider MommySlider;
    float MommySliderVal;
    float MommyRandomVal;

    public AudioSource MummyCall;
    public AudioSource MummyKhus;
    public AudioSource MummyGussa;
    public AudioSource BetaNoStudy;

    public AudioSource Alert1;
    public AudioSource AlertHeart;

    // Start is called before the first frame update
    void Start()
    {
        CountDalBable = 0;
        MommyCount = 0;
        IsStudy = true;

        MommySlider.maxValue = BoobitaTimer;
        MommySlider.value = 0;
        MommyRandomVal = 0;
        Mommycoming = false;
        StartMommy = false;
        MommySlider.gameObject.SetActive(false);
        Invoke("MommyLoop", 30);
    }

    // Update is called once per frame
    void Update()
    {
        MommySlider.value = CountDalBable;

        if (StartMommy == true)
        {
            MainCount();
        }

        if (Mommycoming == true)
        {
            CountDalBable += Time.deltaTime;
           
            if (CountDalBable >= BoobitaTimer - 3 && CountDalBable <= BoobitaTimer - 2.7f)
            {
                MummyCall.Play();
            }

            if (CountDalBable >= BoobitaTimer)
            {
                MommySpawner();
                Mommycoming = false;
            }
        }
    }

    public void Studyhuhu()
    {
        IsStudy = true;
    }

    public void StudyNoNo()
    {
        IsStudy = false;
    }

    public void StartLv()
    {
        StartMommy = true;
        BetaNoStudy.Play();
       
    }

    public void MainCount()
    {
        if (MommySliderVal < MommyRandomVal)
        {
            MommySliderVal += Time.deltaTime;
            
            if (MommySliderVal >= MommyRandomVal)
            {
                GameManager.instance.QuestDisplay(1);
                Alert1.Play();
                AlertHeart.Play();
                Mommycoming = true;
            }
        }
    }

    public void MommyLoop()
    {
        MommyRandomVal = Random.Range(20, 40);

       
        // MommySlider.value = MommySliderVal;
        
    }

    public void Pass()
    {
        LevelWon.SetActive(true);
    }
    
    public void Lost()
    {
        LevelLost1.SetActive(true);
    }

    public void MommySpawner()
    {
        if (IsStudy == true)
        {
            LevelWonMain.SetActive(true);
            LevelUI.SetActive(false);
            Invoke("Pass", 1);
        }

        if (IsStudy != true)
        {
            LevelLost.SetActive(true);
            LevelUI.SetActive(false);
            Invoke("Lost", 1);
        }
    }
}
