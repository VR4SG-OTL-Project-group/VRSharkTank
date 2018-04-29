using System.Collections;
using UnityEngine;


public class NPC1WalkIn : MonoBehaviour
{

    private Animator anim;
    public int npc1SpeechTime = 10;

    private bool canMove = true;
    private bool doneMoving = false;
    private bool canRotate2 = false;
    //private bool nextNpc = false;

    private int turnAmount = 90;

    public GameObject passVariables;
    private Timer timerScript;

    private AudioSource presentation;

    void Start()
    {
        presentation = GetComponent<AudioSource>();
        timerScript = passVariables.GetComponent<Timer>();
        anim = GetComponent<Animator>();
        StartCoroutine(WaitToStartPitchCoroutine());
        //anim.Play("Walk");
        //StartCoroutine(WaitCoroutine()); // Remove if questions are used

    }

    void Update()
    {

        if (canRotate2 == false)
            transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Destination").transform.position, 0.025f);

        if (canMove == false && canRotate2 == false) {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.AngleAxis(turnAmount, Vector3.up), .05f);
            if (doneMoving == false)
            {
                anim.Play("Idle");
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

        //if (canMove)
        //    transform.Translate(Vector3.forward * Time.deltaTime);
        //if (transform.position.z < GameObject.Find("Destination").transform.z)
    }

    IEnumerator WaitCoroutine()
    {
        //This is a coroutine

        yield return new WaitForSeconds(npc1SpeechTime);
		doneMoving = true;

		/*
		if (nextNpc) {
		anim.Play ("Walk");
        canRotate2 = true;
        transform.Rotate(0, -90, 0);
        GameObject npc2 = GameObject.Find ("Person 2");
		npc2.GetComponent<NPC2WalkIn> ().WalkIn ();
		}	
		*/
    }

    IEnumerator WaitToStartPitchCoroutine() // Start Audio in here
    {
        yield return new WaitForSeconds(8);
        timerScript.startClock();
        presentation.Play();
        // Start speech 1 audio
    }

    public void ExitRoom() // Called when user is done asking questions
    {
        presentation.Stop();
		anim.Play ("Walk");
		canRotate2 = true;
		transform.Rotate(0, -90, 0);

		//transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Destination2").transform.position, 0.025f);
	
		StartCoroutine(WaitCoroutine());

        GameObject npc2 = GameObject.Find ("Person 2");
		npc2.GetComponent<NPC2WalkIn>().WalkIn ();


       // anim.Play("WalkForwardTurnRight_NtrlShort 2");
        //GameObject npc2 = GameObject.Find("Person 2");
       // npc2.GetComponent<NPC2WalkIn>().WalkIn();
    }
}