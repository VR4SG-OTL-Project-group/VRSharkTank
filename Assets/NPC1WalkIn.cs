using System.Collections;
using UnityEngine;


public class NPC1WalkIn : MonoBehaviour
{

    private Animator anim;
    public int npc1SpeechTime = 10;

	private bool nextNpc = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("WalkFWD");
        StartCoroutine(WaitCoroutine()); // Remove if questions are used
    }

    IEnumerator WaitCoroutine()
    {
        //This is a coroutine

        yield return new WaitForSeconds(npc1SpeechTime);

		if (nextNpc) {
			anim.Play ("WalkForwardTurnRight_NtrlShort 2");
			GameObject npc2 = GameObject.Find ("GreenSuitMan");
			npc2.GetComponent<NPC2WalkIn> ().WalkIn ();
		}
    }

    public void ExitRoom() // Called when user is done asking questions
    {
        anim.Play("WalkForwardTurnRight_NtrlShort 2");
        GameObject npc2 = GameObject.Find("GreenSuitMan");
        npc2.GetComponent<NPC2WalkIn>().WalkIn();
    }
}