using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC3WalkIn : MonoBehaviour
{

    private Animator anim;
    public int npc3SpeechTime = 10;

    public GameObject passVariables;
    private Timer timerScript;

    private AudioSource presentation;

    void Start()
    {
        timerScript = passVariables.GetComponent<Timer>();
        presentation = GetComponent<AudioSource>();
    }

    public void WalkIn()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(WaitToEnterCoroutine());
    }

    IEnumerator WaitToEnterCoroutine()
    {
        //This is a coroutine
        yield return new WaitForSeconds(5);
        anim.Play("WalkFWD");
        yield return new WaitForSeconds(6);
        timerScript.startClock();
        presentation.Play();
        //StartCoroutine(WaitToExitCoroutine()); // Remove if questions are used
    }

    IEnumerator WaitToExitCoroutine()
    {
        //This is a coroutine

        yield return new WaitForSeconds(npc3SpeechTime);

        //anim.Play("WalkForwardTurnRight_NtrlShort 2");
    }

    public void ExitRoom() // Called when user is done asking questions
    {
        presentation.Stop();
        anim.Play("WalkForwardTurnRight_NtrlShort 2");
    }
}
