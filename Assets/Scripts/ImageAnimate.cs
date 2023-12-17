using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAnimate : MonoBehaviour
{
    public Sprite[] DisplayImage;
    public int DisplayIndex;
    public Image DisplayCurrent;

    public float KeyTimer;
    float Count;

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
        if (DisplayIndex != DisplayImage.Length-1)
        {
            DisplayIndex++;
        }
        else DisplayIndex = 0;
       
    }

}
