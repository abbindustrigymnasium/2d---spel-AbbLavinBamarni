using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftscript : MonoBehaviour
{
    Text text;
    public static float TimeLefttext = 10f;

    
    void Start()
    {
        text = GetComponent<Text> ();
    }

    void Update()
    {
        TimeLefttext  -= Time.deltaTime;
        if(TimeLefttext  < 0) 
        TimeLefttext  = 0;
        text.text = "Time's up: " + Mathf.Round (TimeLefttext);
    }
}
