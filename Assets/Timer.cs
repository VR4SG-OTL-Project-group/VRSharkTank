using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //variables for clock feature
    public Text clock;
    private float timeRemaining;

    //variables for powerpoint feature
    public GameObject whiteBoard;
    public Image powerPoint;
    public Sprite[] slide;
    private int slideNumber;
    private bool clockActive;
    private int pitchNumber;


    void Start()
    {
        //initializes clock feature
        clock.text = "2:00";

        //initializes powerpoint feature
        whiteBoard.transform.localScale = new Vector3(0, 0, 0);
        slideNumber = 0;
        pitchNumber = 0;
        clockActive = false;

        startClock();
    }

    void startClock()
    {
        clockActive = true;
        pitchNumber = pitchNumber + 1;
        timeRemaining = 120;
    }

    void stopClock()
    {
        clockActive = false;
        clock.text = "2:00";       
    }


    void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (clockActive)
        {
            if (timeRemaining > 0)
            {
                imageChangeChecker();

                float minutes = Mathf.Floor(timeRemaining / 60);
                float seconds = Mathf.Floor(timeRemaining % 60);
                clock.text = " " + minutes.ToString("0") + ":" + seconds.ToString("00");
            }
            else
                stopClock();
        }
    }
    
    void imageChangeChecker()
    {
        if(pitchNumber == 1)
        {
            if(timeRemaining > 115 && timeRemaining < 115.015)
            {
                imageChanger();
            }
            else if(timeRemaining > 110 && timeRemaining < 110 + 0.015)
            {
                imageChanger();
            }
        }
        else if (pitchNumber == 2)
        {
            if (timeRemaining > 50 && timeRemaining < 50 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 50 && timeRemaining < 50 + 0.02)
            {
                imageChanger();
            }
        }
        else if (pitchNumber == 3)
        {
            if (timeRemaining > 50 && timeRemaining < 50 + 0.03)
            {
                imageChanger();
            }
            else if (timeRemaining > 50 && timeRemaining < 50 + 0.03)
            {
                imageChanger();
            }
        }
    }

    void imageChanger()
    {
            whiteBoard.transform.localScale = new Vector3(1, 1, 1);
            powerPoint.sprite = slide[slideNumber];
            slideNumber++;
    }
}