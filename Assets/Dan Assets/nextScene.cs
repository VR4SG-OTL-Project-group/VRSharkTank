﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {

	public void NextScene () {
		SceneManager.LoadScene("testscene2");
	}
}
