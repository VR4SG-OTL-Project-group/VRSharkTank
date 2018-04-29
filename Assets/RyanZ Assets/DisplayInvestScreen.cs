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
            GameObject.Find("Person 3").GetComponent<NPC3WalkIn>().ExitRoom();
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
        if (pitcherNumber == 1)
		    GameObject.Find ("Person 1").GetComponent<NPC1WalkIn>().ExitRoom ();
        else if (pitcherNumber == 2)
            GameObject.Find("Person 2").GetComponent<NPC2WalkIn>().ExitRoom();
        //GameObject.Find ("GreenSuitMan").GetComponent<NPC2WalkIn>().ExitRoom ();

    }
		
}
