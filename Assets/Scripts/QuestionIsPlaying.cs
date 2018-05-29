using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//provides a global variable so audioclips do not overlap.
public class QuestionIsPlaying : MonoBehaviour {

    public bool questionPlaying;

	// Use this for initialization
	void Start () {
        questionPlaying = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
