using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Canvas aboutMenu;
    public Button startText;
    public Button aboutText;

    void Start()

    {
        aboutMenu = aboutMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        aboutText = aboutText.GetComponent<Button>();
        aboutMenu.enabled = false;

    }

    public void AboutPress() 

    {
        aboutMenu.enabled = true; //enable the Quit menu when we click the Exit button
        startText.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
        aboutText.enabled = false;

    }

    public void BackPress() //this function will be used for our "NO" button in our Quit Menu

    {
        aboutMenu.enabled = false;
        startText.enabled = true; 
        aboutText.enabled = true;

    }

    public void StartLevel() //this function will be used on our Play button

    {
        SceneManager.LoadScene(1); //this will load our first level from our build settings. "1" is the second scene in our game

    }

}
