using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {

    public static float Level1Complete, Level2Complete, Level3Complete;
    public GameObject StartMenu, ControlsMenu, LevelSelect;
    public Image Level1, Level2, Level3;
    public Material Locked;

	// Use this for initialization
	void Start () {

        Time.timeScale = 1;

        Level1Complete = PlayerPrefs.GetFloat("Level1Complete", Level1Complete);
        Level2Complete = PlayerPrefs.GetFloat("Level2Complete", Level2Complete);
        Level3Complete = PlayerPrefs.GetFloat("Level3Complete", Level3Complete);

    }
	
	// Update is called once per frame
	void Update ()

    {
        

        HandleLevelUnlock();

    }
    public void HandleUnlock()
    {
        Level1Complete = 1;
        Level2Complete = 1;
        Level3Complete = 1;
    }
    public void HandleReset()
    {
        Level1Complete = 0;
        Level2Complete = 0;
        Level3Complete = 0;
        PlayerPrefs.SetFloat("Level1Complete", Level1Complete);
        PlayerPrefs.SetFloat("Level2Complete", Level2Complete);
        PlayerPrefs.SetFloat("Level3Complete", Level3Complete);
        Level1Complete = PlayerPrefs.GetFloat("Level1Complete", Level1Complete);
        Level2Complete = PlayerPrefs.GetFloat("Level2Complete", Level2Complete);
        Level3Complete = PlayerPrefs.GetFloat("Level3Complete", Level3Complete);
    }

    public void HandleLevelUnlock()
    {
        if (Level1Complete == 0)
        {
            Level2.material = Locked;
        }
        else
        {
            Level2.material = null;
        }
        if (Level2Complete == 0)
        {
            Level3.material = Locked;
        }
        else
        {
            Level3.material = null;
        }
    }

    public void HandleLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void HandleLevel2()
    {
        if (Level1Complete == 1)
        {
            SceneManager.LoadScene("Level 2");
        }
    }
    public void HandleLevel3()
    {
        if (Level2Complete == 1)
        {
            SceneManager.LoadScene("Level 3");
        }
    }

    public void BackToMenu()
    {
        ControlsMenu.SetActive(false);
        LevelSelect.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void HandleStart()
    {
        LevelSelect.SetActive(true);
        StartMenu.SetActive(false);
    }

    public void HandleControls()
    {
        ControlsMenu.SetActive(true);
        StartMenu.SetActive(false);
    }

    public void HandleQuit()
    {
        Application.Quit();
    }

}
