﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class netChange2 : MonoBehaviour
{
    Text displayText;
    public GameObject passVariables;
    private maxBudget variableAccess;
    float investment;
    // Use this for initialization
	void Update()
    {
        variableAccess = passVariables.GetComponent<maxBudget>();

        investment = variableAccess.readInvest2();
        displayText = GetComponent<Text>();
        displayText.text = "$" + (Mathf.Round(investment) * (variableAccess.readInvest2return()) * 1000).ToString();
    }

    // Update is called once per frame
   // public void updateVal(float Value)
   // {
   //     displayText.text = "$" + (Mathf.Round(Value) * 1000).ToString() + ".00";
   // }
}
