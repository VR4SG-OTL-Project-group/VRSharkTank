using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class profit4 : MonoBehaviour
{
    Text displayText;
    public GameObject passVariables;
    private maxBudget variableAccess;
    public static float investment1;
    public static float investment2;
    public static float investment3;
    double total;
    // Use this for initialization
    void Update()
    {
        variableAccess = passVariables.GetComponent<maxBudget>();

        investment1 = variableAccess.readInvest1();
        investment2 = variableAccess.readInvest2();
        investment3 = variableAccess.readInvest3();
        total = ((Mathf.Round(investment3) * (variableAccess.readInvest3return()) * 1000) + (Mathf.Round(investment2) * (variableAccess.readInvest2return()) * 1000) + (Mathf.Round(investment1) * (variableAccess.readInvest1return()) * 1000)) - (Mathf.Round(investment1) + Mathf.Round(investment2) + Mathf.Round(investment3)) * 1000;
        displayText = GetComponent<Text>();
        if (total > 0)
        {
            displayText.color = Color.green;
        }
        else
        {

            displayText.color = Color.red;
        }
        displayText.text = "$" + Math.Abs(total).ToString();
    }

    // Update is called once per frame
    // public void updateVal(float Value)
    // {
    //     displayText.text = "$" + (Mathf.Round(Value) * 1000).ToString() + ".00";
    // }
}
