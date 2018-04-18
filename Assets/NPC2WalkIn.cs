using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2WalkIn : MonoBehaviour {

    private Animator anim;
    public int npc2SpeechTime = 10;

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

        yield return new WaitForSeconds(npc2SpeechTime);

        anim.Play("WalkForwardTurnRight_NtrlShort 2");
        if (this.gameObject != GameObject.Find("RedSuitMan"))
        {
            GameObject npc3 = GameObject.Find("RedSuitMan");
            npc3.GetComponent<NPC2WalkIn>().WalkIn();
        }
    }

    public void ExitRoom() // Called when user is done asking questions
    {
        anim.Play("WalkForwardTurnRight_NtrlShort 2");
        if (this.gameObject != GameObject.Find("RedSuitMan"))
        {
            GameObject npc3 = GameObject.Find("RedSuitMan");
            npc3.GetComponent<NPC2WalkIn>().WalkIn();
        }
    }
}
