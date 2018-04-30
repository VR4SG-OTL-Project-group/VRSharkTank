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
    }

    public void startClock()
    {
        clockActive = true;
        pitchNumber = pitchNumber + 1;
        timeRemaining = 120;
    }

    public void stopClock()
    {
        clockActive = false;
        clock.text = "2:00";
        whiteBoard.transform.localScale = new Vector3(0, 0, 0);


        //moves the tablet down
        moveTabletDown();
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
            {
                stopClock();
                movePerson();
            }
        }
    }

    void imageChangeChecker()
    {
        if (pitchNumber == 1)
        {
            if (timeRemaining > 119 && timeRemaining < 119 + 0.03)
            {
                slideNumber = 0;
                imageChanger();
            }
            else if (timeRemaining > 111 && timeRemaining < 111 + 0.03)
            {
                slideNumber = 1;
                imageChanger();
            }
            else if (timeRemaining > 98 && timeRemaining < 98 + 0.03)
            {
                slideNumber = 2;
                imageChanger();
            }
            else if (timeRemaining > 82 && timeRemaining < 82 + 0.03)
            {
                slideNumber = 3;
                imageChanger();
            }
            if (timeRemaining > 68 && timeRemaining < 68 + 0.03)
            {
                slideNumber = 4;
                imageChanger();
            }
            else if (timeRemaining > 54 && timeRemaining < 54 + 0.03)
            {
                slideNumber = 5;
                imageChanger();
            }
            else if (timeRemaining > 46 && timeRemaining < 46 + 0.03)
            {
                slideNumber = 6;
                imageChanger();
            }
            else if (timeRemaining > 43 && timeRemaining < 43 + 0.03)
            {
                slideNumber = 7;
                imageChanger();
            }
            else if (timeRemaining > 41 && timeRemaining < 41 + 0.03)
            {
                slideNumber = 8;
                imageChanger();
            }
            else if (timeRemaining > 20 && timeRemaining < 20 + 0.03)
            {
                slideNumber = 9;
                imageChanger();
            }
        }
        else if (pitchNumber == 2)
        {
            if (timeRemaining > 119 && timeRemaining < 119 + 0.03)
            {
                slideNumber = 10;
                imageChanger();
            }
            else if (timeRemaining > 114 && timeRemaining < 114 + 0.03)
            {
                slideNumber = 11;
                imageChanger();
            }
            else if (timeRemaining > 102 && timeRemaining < 102 + 0.03)
            {
                slideNumber = 12;
                imageChanger();
            }
            else if (timeRemaining > 95 && timeRemaining < 95 + 0.03)
            {
                slideNumber = 13;
                imageChanger();
            }
            else if (timeRemaining > 83 && timeRemaining < 83 + 0.03)
            {
                slideNumber = 14;
                imageChanger();
            }
            else if (timeRemaining > 78 && timeRemaining < 78 + 0.03)
            {
                slideNumber = 15;
                imageChanger();
            }
            else if (timeRemaining > 68 && timeRemaining < 68 + 0.03)
            {
                slideNumber = 16;
                imageChanger();
            }
            else if (timeRemaining > 64 && timeRemaining < 64 + 0.03)
            {
                slideNumber = 17;
                imageChanger();
            }
            else if (timeRemaining > 59 && timeRemaining < 59 + 0.03)
            {
                slideNumber = 18;
                imageChanger();
            }
            else if (timeRemaining > 51 && timeRemaining < 51 + 0.03)
            {
                slideNumber = 19;
                imageChanger();
            }
            else if (timeRemaining > 38 && timeRemaining < 38 + 0.03)
            {
                slideNumber = 20;
                imageChanger();
                moveTabletUp();
            }
        }
        else if (pitchNumber == 3)
        {
            if (timeRemaining > 119 && timeRemaining < 119 + 0.03)
            {
                slideNumber = 21;
                imageChanger();
            }
            else if (timeRemaining > 116 && timeRemaining < 116 + 0.03)
            {
                slideNumber = 22;
                imageChanger();
            }
            else if (timeRemaining > 103 && timeRemaining < 103 + 0.03)
            {
                slideNumber = 23;
                imageChanger();
            }
            else if (timeRemaining > 93 && timeRemaining < 93 + 0.03)
            {
                slideNumber = 24;
                imageChanger();
            }
            else if (timeRemaining > 82 && timeRemaining < 82 + 0.03)
            {
                slideNumber = 25;
                imageChanger();
            }
            else if (timeRemaining > 69 && timeRemaining < 69 + 0.03)
            {
                slideNumber = 26;
                imageChanger();
            }
            else if (timeRemaining > 57 && timeRemaining < 57 + 0.03)
            {
                slideNumber = 27;
                imageChanger();
            }
            else if (timeRemaining > 50 && timeRemaining < 50 + 0.03)
            {
                slideNumber = 28;
                imageChanger();
            }
            else if (timeRemaining > 38 && timeRemaining < 38 + 0.03)
            {
                slideNumber = 29;
                imageChanger();
                moveTabletUp();
            }
        }
    }

    void imageChanger()
    {
        whiteBoard.transform.localScale = new Vector3(1, 1, 1);
        powerPoint.sprite = slide[slideNumber];
    }

    public void moveTabletUp()
    {
        //moves the tablet up
        GameObject.Find("Tablet").GetComponent<MoveTablet>().moveUp = true;
    }

    public void moveTabletDown()
    {
        GameObject.Find("Tablet").GetComponent<MoveTablet>().moveUp = false;
    }

    void movePerson()
    {
        if (pitchNumber == 1)
        {
            GameObject.Find("Finished_1").GetComponent<DisplayInvestScreen>().finishedPitchOneTwo();
        }
        else if (pitchNumber == 2)
        {
            GameObject.Find("Finished_2").GetComponent<DisplayInvestScreen>().finishedPitchOneTwo();
        }
        else if (pitchNumber == 3)
        {
            GameObject.Find("Finished_3").GetComponent<DisplayInvestScreen>().finishedPressed();
        }
    }
}

