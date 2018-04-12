using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maxBudget : MonoBehaviour {
    static float budgetCap = 100000;
    static float currentInvest = 0;
    static float investment1 = 0;
    static float investment2 = 0;
    static float investment3 = 0;
    static int updateInt = 0;
    Text displayText;
    // Use this for initialization
    void Start () {
        displayText = GetComponent<Text>();
        displayText.text = "Current: $0.00";
        updateInt += 1;
    }

    public void updateInvest1(float invest1)
    {
        investment1 = invest1;
    }

    public void updateInvest2(float invest2)
    {
        investment2 = invest2;
    }

    public void updateInvest3(float invest3)
    {
        investment3 = invest3;
    }

    public float readInvest1()
    {
        return investment1;
    }

    public float readInvest2()
    {
        return investment2;
    }

    public float readInvest3()
    {
        return investment3;
    }

    // Update is called once per frame
    void Update () {
        if (updateInt < 2)
        {
            currentInvest = Mathf.Round(investment1) + Mathf.Round(investment2) + Mathf.Round(investment3);
            displayText.text = "Current: $" + Mathf.Round(currentInvest * 1000).ToString() + ".00";
            if (currentInvest > budgetCap / 1000)
            {
                displayText.color = Color.red;
            }
            else
            {
                displayText.color = Color.green;
            }
        }
	}
}
