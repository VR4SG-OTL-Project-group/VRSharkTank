using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {

	public void NextScene () {
        DontDestroyOnLoad(GameObject.Find("InvestReport"));
        DontDestroyOnLoad(GameObject.Find("InvestScreen"));
        SceneManager.LoadScene("finalScene");
        //DontDestroyOnLoad''
	}
}
