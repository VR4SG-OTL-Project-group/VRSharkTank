using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class branchingLogicDialogue : MonoBehaviour {

    //audiosources to be played
    public AudioClip intro;
	public AudioClip investedInPitch1Clip;
	public AudioClip investedInPitch2Clip;
	public AudioClip investedInPitch3Clip;
	public AudioClip notInvestedInPitch1Clip;
	public AudioClip notInvestedInPitch2Clip;
	public AudioClip notInvestedInPitch3Clip;

    bool playIntro = true;
    bool play1 = false;
    bool play2 = false;
    bool play3 = false;
	//source to get data on what pitches were invested in
	//public GameObject passVariables;

	//object to access needed data in passVariables
	private maxBudget investmentValues;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//update changes to investment values
		//investmentValues = passVariables.GetComponent<maxBudget> ();

		if(Input.GetMouseButtonDown(1)){
		//if (Input.GetKeyDown (KeyCode.Space)) {
			PlayAudio();
		}
	}

	public void PlayAudio () {
		float investmentValue;

		float time1;
		float time2;

        if (playIntro)
        {
            DialogueManager.Instance.beginDialogue(intro);
            StartCoroutine(PlayAndWait(intro.length));
        }
        else if (play1)
        {
            investmentValue = profit4.investment1; //investmentValues.readInvest1 ();
            if (investmentValue > 0)
            {
                DialogueManager.Instance.beginDialogue(investedInPitch1Clip);
                StartCoroutine(PlayAndWait(investedInPitch1Clip.length));
                //time1 = investedInPitch1Clip.clip.length;
            }
            else
            {
                DialogueManager.Instance.beginDialogue(notInvestedInPitch1Clip);
                StartCoroutine(PlayAndWait(notInvestedInPitch1Clip.length));

                //StartCoroutine(PlayAndWait(notInvestedInPitch1Clip,0));
                //time1 = notInvestedInPitch1Clip.clip.length;
            }
        }
        else if (play2)
        {
            investmentValue = profit4.investment2;//investmentValues.readInvest2 ();
            if (investmentValue > 0)
            {
                DialogueManager.Instance.beginDialogue(investedInPitch2Clip);
                StartCoroutine(PlayAndWait(investedInPitch2Clip.length));

                //StartCoroutine(PlayAndWait (investedInPitch2Clip, time1));
                //time2 = investedInPitch2Clip.clip.length;
            }
            else
            {
                DialogueManager.Instance.beginDialogue(notInvestedInPitch2Clip);
                StartCoroutine(PlayAndWait(notInvestedInPitch2Clip.length));
                //StartCoroutine(PlayAndWait (notInvestedInPitch2Clip, time1));
                //time2 = notInvestedInPitch2Clip.clip.length;
            }
        }
        else if (play3)
        {
            investmentValue = profit4.investment3;//investmentValues.readInvest3 ();
            if (investmentValue > 0)
            {
                DialogueManager.Instance.beginDialogue(investedInPitch3Clip);
                //StartCoroutine(PlayAndWait (investedInPitch3Clip, time1 + time2));
            }
            else
            {
                DialogueManager.Instance.beginDialogue(notInvestedInPitch3Clip);

                //StartCoroutine(PlayAndWait (notInvestedInPitch3Clip, time1 + time2));
            }
            SceneManager.LoadScene("StartMenu");
        }
    }

	private IEnumerator PlayAndWait(float delay) {
        yield return new WaitForSeconds (delay);
        if(playIntro)
        {
            playIntro = false;
            play1 = true;
        }      
        else if (play1)
        {
            play1 = false;
            play2 = true;
        }else if (play2)
        {
            play2 = false;
            play3 = true;
        }else if (play3)
        {
            play3 = false;
        }
        else
        {
            //SceneManager.LoadScene("StartMenu");
        }
        PlayAudio();
	}
}
