using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDialogue : MonoBehaviour {


	public AudioClip dialogueClip;

	// Update is called once per frame
	void Update () {
		/*if(Input.GetMouseButtonDown(0)){
		//if (Input.GetKeyDown (KeyCode.Space)) {
			DialogueManager.Instance.beginDialogue (dialogueClip);
		}*/
	}

	public void playDialogueClip(){
		DialogueManager.Instance.beginDialogue (dialogueClip);
	}


}
