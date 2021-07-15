using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameTimer : MonoBehaviour
{
    public float remainingTime;
    public bool timeIsRunning = false;
    public Text TimeText;
    // Start is called before the first frame update
    private void Start()
    {
        timeIsRunning = true;
       
    }
    void DisplayTime(float timeToDisplay)
    {
        float seconds = Mathf.FloorToInt(remainingTime / 60);
        float milliseconds = Mathf.FloorToInt(remainingTime % 60);

        TimeText.text = string.Format("{0:00}:{1:00}", seconds, milliseconds);
    }
    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
                DisplayTime(remainingTime);
            }
            else
            {
                Debug.Log("Time has run out.");
                remainingTime = 0;
                timeIsRunning = false;
                TimeText.text = "00.00";
                
            }
        }
    }
}
      