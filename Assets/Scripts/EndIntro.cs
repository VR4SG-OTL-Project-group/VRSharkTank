using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndIntro : MonoBehaviour {

	private bool isPlaying = false;
	public AudioClip dialogueClip;
	public float audioLength;

	void Start () {
		playDialogueClip ();
	}

	// Update is called once per frame
	void Update () {
		
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
