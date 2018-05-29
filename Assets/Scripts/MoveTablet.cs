using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTablet : MonoBehaviour {
	public GameObject tablet;
	public bool moveUp = false;	
	private Vector3 originalPosition;

	private Vector3 upPosition;
	//private Vector3 downPosition;
	Quaternion upRotation;
	Quaternion downRotation;

	GameObject[] buttonObjects;
	// Use this for initialization
	void Start () {
		originalPosition = transform.position;
		upPosition = GameObject.Find ("TabletUpMarker").transform.position;
		upRotation = Quaternion.AngleAxis(90, Vector3.back);
		downRotation = Quaternion.AngleAxis (0, Vector3.forward);
		buttonObjects = GameObject.FindGameObjectsWithTag("Buttons");
	}

	// Update is called once per frame
	void Update () {
		if (moveUp) {
			Debug.Log ("Moving Up");
			transform.position = Vector3 .MoveTowards(transform.position, upPosition, 0.01f);
			transform.rotation= Quaternion.Slerp(transform.rotation, upRotation, .10f);     
			foreach(GameObject buttonObj in buttonObjects){
				buttonObj.GetComponent<Button> ().interactable = true;
			}
		}else{
			Debug.Log ("Moving Down");
			//tablet.transform.position = originalPosition;
			transform.position = Vector3 .MoveTowards(transform.position, originalPosition, 0.01f);
			transform.rotation= Quaternion.Slerp(transform.rotation, downRotation, .10f);

			foreach(GameObject buttonObj in buttonObjects){
				buttonObj.GetComponent<Button> ().interactable = false;
			}
		}
	}

	public void moveFront(){
		/* Debug.Log ("Clicked!");

		if (moveUp)
			moveUp = false;
	else
		moveUp = true;  */
	}
}
