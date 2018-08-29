using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {

    public GoogleAnalyticsV4 G4;
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
        G4.LogEvent("PressButton", "UnlockButton", "HasPressed", 1);

        // Builder Hit with all Event parameters.
        G4.LogEvent(new EventHitBuilder()
            .SetEventCategory("PressButton")
            .SetEventAction("UnlockButton")
            .SetEventLabel("HasPressed")
            .SetEventValue(1));

        Debug.Log("Sent");
        Level1Complete = 1;
        Level2Complete = 1;
        Level3Complete = 1;
    }
    public void HandleReset()
    {
        G4.LogEvent("PressButton", "ResetButton", "HasPressed", 1);

        // Builder Hit with all Event parameters.
        G4.LogEvent(new EventHitBuilder()
            .SetEventCategory("PressButton")
            .SetEventAction("ResetButton")
            .SetEventLabel("HasPressed")
            .SetEventValue(1));

        Debug.Log("Sent");
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
        G4.LogEvent("PressButton", "Level1Button", "HasPressed", 1);

        // Builder Hit with all Event parameters.
        G4.LogEvent(new EventHitBuilder()
            .SetEventCategory("PressButton")
            .SetEventAction("Level1Button")
            .SetEventLabel("HasPressed")
            .SetEventValue(1));

        Debug.Log("Sent");
        SceneManager.LoadScene("Level 1");
    }
    public void HandleLevel2()
    {
        if (Level1Complete == 1)
        {
            G4.LogEvent("PressButton", "Level2Button", "HasPressed", 1);

            // Builder Hit with all Event parameters.
            G4.LogEvent(new EventHitBuilder()
                .SetEventCategory("PressButton")
                .SetEventAction("Level2Button")
                .SetEventLabel("HasPressed")
                .SetEventValue(1));

            Debug.Log("Sent");
            SceneManager.LoadScene("Level 2");
        }
    }
    public void HandleLevel3()
    {
        if (Level2Complete == 1)
        {
            G4.LogEvent("PressButton", "Level3Button", "HasPressed", 1);

            // Builder Hit with all Event parameters.
            G4.LogEvent(new EventHitBuilder()
                .SetEventCategory("PressButton")
                .SetEventAction("Level3Button")
                .SetEventLabel("HasPressed")
                .SetEventValue(1));

            Debug.Log("Sent");
            SceneManager.LoadScene("Level 3");
        }
    }

    public void BackToMenu()
    {
        G4.LogEvent("PressButton", "BackButton", "HasPressed", 1);

        // Builder Hit with all Event parameters.
        G4.LogEvent(new EventHitBuilder()
            .SetEventCategory("PressButton")
            .SetEventAction("BackButton")
            .SetEventLabel("HasPressed")
            .SetEventValue(1));

        Debug.Log("Sent");
        ControlsMenu.SetActive(false);
        LevelSelect.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void HandleStart()
    {
        G4.LogEvent("PressButton", "StartButton", "HasPressed", 1);

        // Builder Hit with all Event parameters.
        G4.LogEvent(new EventHitBuilder()
            .SetEventCategory("PressButton")
            .SetEventAction("StartButton")
            .SetEventLabel("HasPressed")
            .SetEventValue(1));

        Debug.Log("Sent");
        LevelSelect.SetActive(true);
        StartMenu.SetActive(false);
    }

    public void HandleControls()
    {
        G4.LogEvent("PressButton", "ControlButton", "HasPressed", 1);

        // Builder Hit with all Event parameters.
        G4.LogEvent(new EventHitBuilder()
            .SetEventCategory("PressButton")
            .SetEventAction("ControlButton")
            .SetEventLabel("HasPressed")
            .SetEventValue(1));

        Debug.Log("Sent");
        ControlsMenu.SetActive(true);
        StartMenu.SetActive(false);
    }

    public void HandleQuit()
    {
        G4.LogEvent("PressButton", "QuitButton", "HasPressed", 1);

        // Builder Hit with all Event parameters.
        G4.LogEvent(new EventHitBuilder()
            .SetEventCategory("PressButton")
            .SetEventAction("QuitButton")
            .SetEventLabel("HasPressed")
            .SetEventValue(1));

        Debug.Log("Sent");
        Application.Quit();
    }

}
