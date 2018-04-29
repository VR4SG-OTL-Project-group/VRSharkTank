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

        //startClock();
    }

    public void startClock()
    {
        clockActive = true;
        pitchNumber = pitchNumber + 1;
        timeRemaining = 120;
    }

    void stopClock()
    {
        clockActive = false;
        clock.text = "2:00";
        whiteBoard.transform.localScale = new Vector3(0, 0, 0);
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
        if (pitchNumber == 1)
        {
            if (timeRemaining > 119 && timeRemaining < 119 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 111 && timeRemaining < 111 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 98 && timeRemaining < 98 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 82 && timeRemaining < 82 + 0.02)
            {
                imageChanger();
            }
            if (timeRemaining > 68 && timeRemaining < 68 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 54 && timeRemaining < 54 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 46 && timeRemaining < 46 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 43 && timeRemaining < 43 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 41 && timeRemaining < 41 + 0.02)
            {
                imageChanger();
            }
        }
        else if (pitchNumber == 2)
        {
            if (timeRemaining > 119 && timeRemaining < 119 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 115 && timeRemaining < 115 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 104 && timeRemaining < 104 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 96 && timeRemaining < 96 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 84 && timeRemaining < 84 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 79 && timeRemaining < 79 + 0.02)
            {
                imageChanger();
            }
            else if (timeRemaining > 69 && timeRemaining < 69 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 65 && timeRemaining < 65 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 60 && timeRemaining < 60 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 52 && timeRemaining < 52 + 0.015)
            {
                imageChanger();
            }
        }
        else if (pitchNumber == 3)
        {
            if (timeRemaining > 120 - 0.015 && timeRemaining < 120)
            {
                imageChanger();
            }
            else if (timeRemaining > 116 && timeRemaining < 116 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 103 && timeRemaining < 103 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 93 && timeRemaining < 93 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 82 && timeRemaining < 82 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 70 && timeRemaining < 70 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 60 && timeRemaining < 60 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 52 && timeRemaining < 52 + 0.015)
            {
                imageChanger();
            }
            else if (timeRemaining > 38 && timeRemaining < 38 + 0.015)
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