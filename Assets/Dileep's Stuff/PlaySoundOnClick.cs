using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour {

	private AudioSource audio;


	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	public void playSound() {
		if (audio.isPlaying) {
			audio.Stop ();
		}

		audio.Play ();
	}
}
