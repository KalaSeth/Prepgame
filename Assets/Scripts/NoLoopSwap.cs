using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NoLoopSwap : MonoBehaviour
{
    public Sprite[] DisplayImage;
    public int DisplayIndex;
    public Image DisplayCurrent;

    public float KeyTimer;
    float Count;

    private void Start()
    {
        Invoke("SwitchMain", 10);
    }

    void SwitchMain()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        DisplayCurrent.sprite = DisplayImage[DisplayIndex];

        if (Count <= KeyTimer)
        {
            Count += Time.deltaTime;
            if (Count >= KeyTimer)
            {
                Count = 0;
                ImageLooper();
            }
        }
    }

    public void ImageLooper()
    {
        if (DisplayIndex != DisplayImage.Length - 1)
        {
            DisplayIndex++;
        }
       

    }

}
