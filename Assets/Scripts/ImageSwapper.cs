using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwapper : MonoBehaviour
{
    public static ImageSwapper instance;

    public Sprite[] DisplayImage;
    public int DisplayIndex;
    public Image DisplayCurrent;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayCurrent.sprite = DisplayImage[DisplayIndex];
    }

    public void ImageChanger(int Index)
    {
        DisplayIndex = Index;
    }

    
}
