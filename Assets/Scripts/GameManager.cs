using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text QuestLog;

    public string[] QuestEventText;
    public int QuestIndex;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        QuestLog.text = QuestEventText[QuestIndex];
    }

    public void QuestDisplay(int Index)
    {
        QuestIndex = Index;
    }
}
