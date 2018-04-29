using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class branchingLogicDialogue : MonoBehaviour {

	//audiosources to be played
	public AudioSource investedInPitch1Clip;
	public AudioSource investedInPitch2Clip;
	public AudioSource investedInPitch3Clip;
	public AudioSource notInvestedInPitch1Clip;
	public AudioSource notInvestedInPitch2Clip;
	public AudioSource notInvestedInPitch3Clip;

	//source to get data on what pitches were invested in
	public GameObject passVariables;

	//object to access needed data in passVariables
	private maxBudget investmentValues;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//update changes to investment values
		investmentValues = passVariables.GetComponent<maxBudget> ();

		if(Input.GetMouseButtonDown(1)){
		//if (Input.GetKeyDown (KeyCode.Space)) {
			PlayAudio();
		}
	}

	public void PlayAudio () {
		float investmentValue;

		float time1;
		float time2;

		investmentValue = investmentValues.readInvest1 ();
		if (investmentValue > 0) {
			StartCoroutine(PlayAndWait(investedInPitch1Clip,0));
			time1 = investedInPitch1Clip.clip.length;
		} else {
			StartCoroutine(PlayAndWait(notInvestedInPitch1Clip,0));
			time1 = notInvestedInPitch1Clip.clip.length;
		}

		investmentValue = investmentValues.readInvest2 ();
		if (investmentValue > 0) {
			StartCoroutine(PlayAndWait (investedInPitch2Clip, time1));
			time2 = investedInPitch2Clip.clip.length;
		} else {
			StartCoroutine(PlayAndWait (notInvestedInPitch2Clip, time1));
			time2 = notInvestedInPitch2Clip.clip.length;
		}

		investmentValue = investmentValues.readInvest3 ();
		if (investmentValue > 0) {
			StartCoroutine(PlayAndWait (investedInPitch3Clip, time1 + time2));
		} else {
			StartCoroutine(PlayAndWait (notInvestedInPitch3Clip, time1 + time2));
		}
	}

	private IEnumerator PlayAndWait(AudioSource source, float delay) {
		yield return new WaitForSeconds (delay);
		source.Play ();
	}
}
