using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class netChange : MonoBehaviour
{
    Text displayText;
    public GameObject passVariabless;
    private maxBudget variableAccess;
    float investment;
    // Use this for initialization
    void Update()
    {
        variableAccess = passVariabless.GetComponent<maxBudget>();

        investment = variableAccess.readInvest1();
        displayText = GetComponent<Text>();
        displayText.text = "$" + (Mathf.Round(investment) * (variableAccess.readInvest1return()) * 1000).ToString() + ".00";
    }

    // Update is called once per frame
   // public void updateVal(float Value)
   // {
   //     displayText.text = "$" + (Mathf.Round(Value) * 1000).ToString() + ".00";
   // }
}
