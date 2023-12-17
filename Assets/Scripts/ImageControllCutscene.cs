using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageControllCutscene : MonoBehaviour
{
    [SerializeField] Image ImageBase;

    public Sprite[] CurrentSprite;
    public int CurImageIndex;

    float Count = 0;
    public float MainTimer;

    bool AllDone;

    // Start is called before the first frame update
    void Start()
    {
        ImageBase.sprite = CurrentSprite[0];
        AllDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        ImageBase.sprite = CurrentSprite[CurImageIndex];

        if (Count <= MainTimer)
        {
            Count += Time.deltaTime;

            if (Count >= MainTimer)
            {
                Count = 0;
                ImageChanger();
            }
        }

        if (AllDone == true)
        {
            gameObject.SetActive(false);
        }

    }

    public void ImageChanger()
    {
        if (CurImageIndex <= CurrentSprite.Length)
        {
            CurImageIndex++;
        }
    }

}
