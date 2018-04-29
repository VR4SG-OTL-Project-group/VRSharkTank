using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2WalkIn : MonoBehaviour {

    private Animator anim;
    public int npc2SpeechTime = 10;

    private bool canEnter = false;
    private bool canMove = true;
    private bool doneMoving = false;
    private bool canRotate2 = false;

    private int turnAmount = 90;

    void Update()
    {

        if (canEnter)
        {
            if (canRotate2 == false)
                transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Destination").transform.position, 0.025f);

            if (canMove == false && canRotate2 == false)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.AngleAxis(turnAmount, Vector3.up), .05f);
                if (doneMoving == false)
                {
                    //anim.Play("Idle");
                    //StartCoroutine(WaitCoroutine());
                    //doneMoving = true;
                }
            }

            if (transform.position.z <= GameObject.Find("Destination").transform.position.z)
                canMove = false;

            if (canRotate2)
            {
                //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.AngleAxis(180, Vector3.down), .05f);
                transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Destination2").transform.position, 0.025f);
            }
        }
    }

    public void WalkIn()
    {
        canEnter = true;
        anim = GetComponent<Animator>();
        anim.Play("UNWalkF");
        StartCoroutine(WaitToEnterCoroutine());
    }

    IEnumerator WaitToEnterCoroutine()
    {
        //This is a coroutine
        yield return new WaitForSeconds(6);
        anim.Play("UNIdle");
        //StartCoroutine(WaitToExitCoroutine()); // Remove if questions are used
        yield return new WaitForSeconds(5);
        doneMoving = true;
    }

    /*
    IEnumerator WaitToExitCoroutine()
    {
        //This is a coroutine

        yield return new WaitForSeconds(npc2SpeechTime);
        doneMoving = true;

        anim.Play("UNWalkF");
        //anim.Play("WalkForwardTurnRight_NtrlShort 2"); // NPC 2 exits

        GameObject npc3 = GameObject.Find("Person 3");
        npc3.GetComponent<NPC2WalkIn>().WalkIn();
    }*/

    public void ExitRoom() // Called when user is done asking questions
    {
        canRotate2 = true;
        transform.Rotate(0, -90, 0);
        anim.Play("UNWalkF");
        //anim.Play("WalkForwardTurnRight_NtrlShort 2");
        GameObject npc3 = GameObject.Find("Person 3");
        npc3.GetComponent<NPC3WalkIn>().WalkIn();
    }
}
