using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour {

    public GameObject PauseMenuUI, ControlsUI, QuitToMainUI, MainPauseUI;
    public bool IsPaused;

	// Use this for initialization
	void Start () {
        IsPaused = false;
	}
	
	// Update is called once per frame
	void Update () {

        HandlePause();


    }

    public void HandleBackPause()
    {
        ControlsUI.SetActive(false);
        QuitToMainUI.SetActive(false);
        MainPauseUI.SetActive(true);
    }

    public void HandleControl()
    {
        MainPauseUI.SetActive(false);
        ControlsUI.SetActive(true);
    }

    public void HandleBack()
    {
        Time.timeScale = 1;
        QuitToMainUI.SetActive(false);
        ControlsUI.SetActive(false);
        MainPauseUI.SetActive(true);
        PauseMenuUI.SetActive(false);
        IsPaused = false;
    }

    public void HandlePause()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Joystick1Button7) || Input.GetKeyDown(KeyCode.Joystick2Button7))
        {
            if (IsPaused == false)
            {
                Time.timeScale = 0;
                PauseMenuUI.SetActive(true);
                MainPauseUI.SetActive(true);
                QuitToMainUI.SetActive(false);
                ControlsUI.SetActive(false);
                IsPaused = true;
            }
            else
            {
                Time.timeScale = 1;
                QuitToMainUI.SetActive(false);
                ControlsUI.SetActive(false);
                MainPauseUI.SetActive(true);
                PauseMenuUI.SetActive(false);
                IsPaused = false;
            }
            
        }
            
    }

    public void HandleToMain()
    {
        QuitToMainUI.SetActive(true);
        MainPauseUI.SetActive(false);
    }

    public void HandleYes()
    {
        SceneManager.LoadScene("Main");
    }
}
