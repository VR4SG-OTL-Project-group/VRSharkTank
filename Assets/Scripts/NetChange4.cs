using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NetChange4 : MonoBehaviour
{
    Text displayText;
    public GameObject passVariables;
    private maxBudget variableAccess;
    float investment1;
    float investment2;
    float investment3;
    // Use this for initialization
    void Update()
    {
        variableAccess = passVariables.GetComponent<maxBudget>();

        investment3 = variableAccess.readInvest3();
        investment2 = variableAccess.readInvest2();
        investment1 = variableAccess.readInvest1();
        displayText = GetComponent<Text>();
        displayText.text = "$" + ((Mathf.Round(investment3) * (variableAccess.readInvest3return()) * 1000) + (Mathf.Round(investment2) * (variableAccess.readInvest2return()) * 1000) + (Mathf.Round(investment1) * (variableAccess.readInvest1return()) * 1000)).ToString();
    }

    // Update is called once per frame
    // public void updateVal(float Value)
    // {
    //     displayText.text = "$" + (Mathf.Round(Value) * 1000).ToString() + ".00";
    // }
}
