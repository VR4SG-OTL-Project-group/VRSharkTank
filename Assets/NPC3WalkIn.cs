using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC3WalkIn : MonoBehaviour
{

    private Animator anim;
    public int npc3SpeechTime = 10;

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
        StartCoroutine(WaitToExitCoroutine()); // Remove if questions are used
    }

    IEnumerator WaitToExitCoroutine()
    {
        //This is a coroutine

        yield return new WaitForSeconds(npc3SpeechTime);

        //anim.Play("WalkForwardTurnRight_NtrlShort 2");
    }

    public void ExitRoom() // Called when user is done asking questions
    {
        anim.Play("WalkForwardTurnRight_NtrlShort 2");
    }
}
