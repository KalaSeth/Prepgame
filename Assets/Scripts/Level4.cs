using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4 : MonoBehaviour
{
    public GameObject FinalScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowSccene()
    {
        FinalScene.SetActive(true);
    }

    public void OnclickShow()
    {
        Invoke("ShowSccene", 4);
    }


}
