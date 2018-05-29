using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour {

	private AudioSource audio;
    //public GameObject menu;
    private QuestionIsPlaying isPlayingScript;


    // Use this for initialization
    void Start () {
		audio = GetComponent<AudioSource> ();
        isPlayingScript = gameObject.GetComponentInParent<QuestionIsPlaying>();
	}
	
	public void playSound() {
        if(isPlayingScript.questionPlaying)
        {
            return;
        }

		if (audio.isPlaying) {
			audio.Stop ();
		}

        isPlayingScript.questionPlaying = true;
		audio.Play ();
        StartCoroutine(resetQuestionPlaying());
	}

    private IEnumerator resetQuestionPlaying()
    {
        yield return new WaitForSeconds(audio.clip.length);
        isPlayingScript.questionPlaying = false;
    }
}
