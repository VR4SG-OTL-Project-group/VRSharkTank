using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInvestScreen : MonoBehaviour {

	private int finishedCount;
	private int doubleClick;
	private GameObject questionMenu;
	private GameObject investScreen;
	public int pitcherNumber;
	// Use this for initialization
	void Start () {
		finishedCount = 0;
		doubleClick = 0;
		investScreen = GameObject.Find ("InvestScreen");
		questionMenu = GameObject.Find ("QuestionMenuObject_"+pitcherNumber);
	}
	
	// Update is called once per frame
	void Update () {
		if (finishedCount >= 1) {
			questionMenu.SetActive (false);
			investScreen.SetActive (true);
		} else
			investScreen.SetActive (false);
	}
	public void finishedPressed(){
		finishedCount++;
	}

	public void finishedPitchOneTwo(){
		doubleClick++;
		questionMenu.SetActive (false);
		GameObject.Find ("QuestionMenuObject_" + (pitcherNumber + 1)).SetActive (true);
		GameObject.Find ("Person 1").GetComponent<NPC1WalkIn>().ExitRoom ();
		//GameObject.Find ("GreenSuitMan").GetComponent<NPC2WalkIn>().ExitRoom ();

	}
		
}
