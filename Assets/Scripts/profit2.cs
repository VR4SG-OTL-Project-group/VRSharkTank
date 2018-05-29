using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profit2 : MonoBehaviour
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
        if (variableAccess.readInvest2return() - 1 > 0)
        {
            displayText.color = Color.green;
        }
        else
        {

            displayText.color = Color.red;
        }
        displayText.text = "$" + (Mathf.Round(investment) * (variableAccess.readInvest2return() - 1) * 1000).ToString();
    }

    // Update is called once per frame
   // public void updateVal(float Value)
   // {
   //     displayText.text = "$" + (Mathf.Round(Value) * 1000).ToString() + ".00";
   // }
}
