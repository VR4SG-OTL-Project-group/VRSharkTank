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
    private int slideChangeTime;

    void Start()
    {
        //initializes clock feature
        timeRemaining = 61;

        //initializes powerpoint feature
        whiteBoard.transform.localScale = new Vector3(0, 0, 0);
        slideNumber = 0;
        slideChangeTime = 50;
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining > 0)
        {
            imageChanger();

            float minutes = Mathf.Floor(timeRemaining / 60);
            float seconds = Mathf.Floor(timeRemaining % 60);
            clock.text = " " + minutes.ToString("0") + ":" + seconds.ToString("00");
        }
        else
            reset();
    }


    void reset()
    {
        timeRemaining = Time.deltaTime + 61;

        slideNumber = 0;
        slideChangeTime = 50;
    }

    void imageChanger()
    {
        
        if (timeRemaining > slideChangeTime && timeRemaining < slideChangeTime + 0.03)
        {
            whiteBoard.transform.localScale = new Vector3(1, 1, 1);
            powerPoint.sprite = slide[slideNumber];
            slideNumber++;
            slideChangeTime = slideChangeTime - 10;
        }
    }
}