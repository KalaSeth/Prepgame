using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VidPlayer : MonoBehaviour
{
    public static VidPlayer instance;
    public string IntroPlayer;
    public float Dt;

    public GameObject UImode;

    private void Start()
    {
        Invoke("VidEnder", Dt);
        PlayerVid();
    }

    void VidEnder()
    {
        UImode.SetActive(true);
        Destroy(gameObject);
    }

    public void PlayerVid()
    {
        VideoPlayer Intro = GetComponent<VideoPlayer>();

        if (Intro)
        {
            string Intropath = System.IO.Path.Combine(Application.streamingAssetsPath, IntroPlayer);
            Intro.url = Intropath;
            Intro.Play();
        }
    }
}
