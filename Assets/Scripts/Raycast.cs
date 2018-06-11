using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

	public float tapRate = 0.25f;
	public float tapRange = 20f;
	public Transform start;
	public Transform cameraObject;

	private Camera vrCam;
	private WaitForSeconds shotDuration = new WaitForSeconds (0.07f);
	private AudioSource moveAudio;
	//private LineRenderer tapLine;
	private float nextFire;

	// Audio Clips
	public AudioClip dialogueClip;

	void Start () {
		//tapLine = GetComponent<LineRenderer> ();
		//moveAudio = GetComponent<AudioSource> ();
		vrCam = GetComponentInParent<Camera> (); 
	}

	void Update () {

		if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + tapRate;
			Vector3 rayOrigin = vrCam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			RaycastHit hit;

			//tapLine.SetPosition (0, start.position);

			// General Clicking 
			if (Physics.Raycast (rayOrigin, vrCam.transform.forward, out hit, tapRange)) {


				float xPosition = hit.point.x;
				float yPosition = hit.point.y + 2.43f;
				float zPosition = hit.point.z;

				// Based on the tag of the object
				if (hit.collider.gameObject.CompareTag ("Cube")) {
					hit.collider.gameObject.GetComponent<ActivateDialogue> ().playDialogueClip ();
				} else if (hit.collider.gameObject.CompareTag ("Cylinder")) {
					hit.collider.gameObject.GetComponent<ActivateDialogue> ().playDialogueClip ();
				} else if (hit.collider.gameObject.CompareTag ("Tablet")) {
					hit.collider.gameObject.GetComponent<MoveTablet> ().moveFront ();
				} else if (hit.collider.gameObject.CompareTag ("Boss_End")) {
					hit.collider.gameObject.GetComponent<branchingLogicDialogue>().PlayAudio();
				} else {
					Debug.Log ("Miss", gameObject);
				}

			}
		}
	}
	private IEnumerator ShotEffect(){
		//moveAudio.Play ();
		//tapLine.enabled = true;
		yield return shotDuration;
		//tapLine.enabled = false;
	}

	//Change scenes
	//private IEnumerator changeScene(){
	//	yield return changeSceneWait;
	//	//Change scene
	//	Application.LoadLevel(levelToLoad);
	//}
}

