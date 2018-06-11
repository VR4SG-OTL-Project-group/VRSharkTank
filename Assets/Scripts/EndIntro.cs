using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndIntro : MonoBehaviour {

	private bool isPlaying = false;
	public AudioClip dialogueClip;
	public float audioLength;
	// Update is called once per frame
	void Update () {
		/*if(Input.GetMouseButtonDown(0)){
		//if (Input.GetKeyDown (KeyCode.Space)) {
			DialogueManager.Instance.beginDialogue (dialogueClip);
		}*/
	}

	public void playDialogueClip(){
		if (!isPlaying) {
			DialogueManager.Instance.beginDialogue (dialogueClip);
			isPlaying = true;
			StartCoroutine (finishAudioClip ());
		}
	}

	private IEnumerator finishAudioClip(){
		yield return new WaitForSeconds (audioLength);
		SceneManager.LoadScene ("PitchPresentations");
	}

}
