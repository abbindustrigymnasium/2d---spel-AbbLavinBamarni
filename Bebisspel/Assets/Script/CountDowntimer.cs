using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDowntimer : MonoBehaviour
{
    float currentTime = 82f;
    float startingTime = 10f;

    public Text CountdownText;
    
    void start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("0");


        if(currentTime <= 0) {
            currentTime = 0;
        }

        if (currentTime <= 82) {
            CountdownText.color = Color.red;
        }

        if (currentTime <= 40) {
            CountdownText.color = Color.black;
        }


        if(currentTime <= 20) {
            CountdownText.color = Color.blue;
        }
    
    }
}
