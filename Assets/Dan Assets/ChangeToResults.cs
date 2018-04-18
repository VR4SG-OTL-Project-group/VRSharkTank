using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToResults : MonoBehaviour {
	private int finishedCount;
	private GameObject investReport;
	private GameObject investScreen;

	// Use this for initialization
	void Start () {
		finishedCount = 0;
		investScreen = GameObject.Find ("InvestScreen");
		investReport = GameObject.Find ("InvestReport");
	}
	
	// Update is called once per frame
	void Update () {
		if (finishedCount >= 1) {
			investScreen.SetActive (false);
			investReport.SetActive (true);
		} else
			investReport.SetActive (false);
	}
	public void finishedPressed(){
		finishedCount++;
	}
}
