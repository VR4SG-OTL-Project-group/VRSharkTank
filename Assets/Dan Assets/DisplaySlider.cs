using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySlider : MonoBehaviour {
    Text displayText;
	// Use this for initialization
	void Start () {
        displayText = GetComponent<Text>();
        displayText.text = "$0.00";
	}
	
	// Update is called once per frame
	public void updateVal(float Value) {
        displayText.text = "$" + (Mathf.Round(Value)*1000).ToString() + ".00";
	}
}
