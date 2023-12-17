using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelOb : MonoBehaviour
{
    public float DelTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DelTime);
    }
}
