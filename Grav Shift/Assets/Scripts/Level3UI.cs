using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3UI : MonoBehaviour {

    public GoogleAnalyticsV4 G4;
    public bool Section1, Section2, Section3, Section4, Section5, Section6;
    public Transform Box1, Box2, Box3, Box4, Box5, Box6, Plyr1, Plyr2;
    public WallProgressionLevel3 SectionOne, SectionTwo, SectionThree, SectionFour, SectionFive, SectionSix;
    public float Timer1, Timer2, Timer3, Timer4, Timer5, Timer6;
    public Text Timer;
    public ButtonMngrLevel3 BtnM3;
    public GameObject TimerVis;


    // Use this for initialization
    void Start () {

        Section1 = true;
        Section2 = false;
        Section3 = false;
        Section4 = false;
        Section5 = false;
        Section6 = false;
        Timer1 = 2.2f;
        Timer2 = 1.2f;
        Timer3 = 3.2f;
        Timer4 = 1.2f;
        Timer5 = 2.2f;
        Timer6 = 8.2f;
        TimerVis.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        HandleSections();
        HandleTimers();

        if (BtnM3.TimeOne == 5)
        {
            Timer1 = 2.2f;
        }

        if (BtnM3.TimeTwo == 1)
        {
            Timer2 = 1.2f;
        }

        if (BtnM3.TimeThree == 5)
        {
            Timer3 = 3.2f;
        }
        if (BtnM3.TimeFour == 3)
        {
            Timer4 = 1.2f;
        }
        if (BtnM3.TimeFive == 2)
        {
            Timer5 = 2.2f;
        }
        if (BtnM3.TimeSix == 1)
        {
            Timer6 = 8.2f;
        }

    }
    public void HandleTimers()
    {
        if (BtnM3.Button1 == true & BtnM3.Button2 == true)
        {
            G4.LogEvent("PressButton", "Section1Timer", "TimeStart", 1);

            // Builder Hit with all Event parameters.
            G4.LogEvent(new EventHitBuilder()
                .SetEventCategory("PressButton")
                .SetEventAction("Section1Timer")
                .SetEventLabel("TimeStart")
                .SetEventValue(1));

            Debug.Log("Sent");
            TimerVis.SetActive(true);
            Timer.text = "" + Timer1.ToString ("f2");
            Timer1 = Timer1 - Time.deltaTime;
            if (Timer1 <= 0.2f)
            {
                TimerVis.SetActive(false);
                Timer1 = 2.2f;
            }
        }
        if (BtnM3.Button3 == true & BtnM3.Button4 == true)
        {
            G4.LogEvent("PressButton", "Section2Timer", "TimeStart", 1);

            // Builder Hit with all Event parameters.
            G4.LogEvent(new EventHitBuilder()
                .SetEventCategory("PressButton")
                .SetEventAction("Section2Timer")
                .SetEventLabel("TimeStart")
                .SetEventValue(1));

            Debug.Log("Sent");
            TimerVis.SetActive(true);
            Timer.text = "" + Timer2.ToString("f2");
            Timer2 = Timer2 - Time.deltaTime;
            if (Timer2 <= 0.2f)
            {
                TimerVis.SetActive(false);
                Timer2 = 1.2f;
            }
        }
        if (BtnM3.Button5 == true & BtnM3.Button6 == true & BtnM3.Button7 == true)
        {
            G4.LogEvent("PressButton", "Section3Timer", "TimeStart", 1);

            // Builder Hit with all Event parameters.
            G4.LogEvent(new EventHitBuilder()
                .SetEventCategory("PressButton")
                .SetEventAction("Section3Timer")
                .SetEventLabel("TimeStart")
                .SetEventValue(1));

            Debug.Log("Sent");
            TimerVis.SetActive(true);
            Timer.text = "" + Timer3.ToString("f2");
            Timer3 = Timer3 - Time.deltaTime;
            if (Timer3 <= 0.2f)
            {
                TimerVis.SetActive(false);
                Timer3 = 3.2f;
            }
        }
        if (BtnM3.Button8 == true & BtnM3.Button9 == true & BtnM3.Button10 == true & BtnM3.Button11 == true)
        {
            G4.LogEvent("PressButton", "Section4Timer", "TimeStart", 1);

            // Builder Hit with all Event parameters.
            G4.LogEvent(new EventHitBuilder()
                .SetEventCategory("PressButton")
                .SetEventAction("Section4Timer")
                .SetEventLabel("TimeStart")
                .SetEventValue(1));

            Debug.Log("Sent");
            TimerVis.SetActive(true);
            Timer.text = "" + Timer4.ToString("f2");
            Timer4 = Timer4 - Time.deltaTime;
            if (Timer4 <= 0.2f)
            {
                TimerVis.SetActive(false);
                Timer4 = 1.2f;
            }
        }
        if (BtnM3.Button12 == true & BtnM3.Button13 == true & BtnM3.Button14 == true & BtnM3.Button15 == true)
        {
            G4.LogEvent("PressButton", "Section5Timer", "TimeStart", 1);

            // Builder Hit with all Event parameters.
            G4.LogEvent(new EventHitBuilder()
                .SetEventCategory("PressButton")
                .SetEventAction("Section5Timer")
                .SetEventLabel("TimeStart")
                .SetEventValue(1));

            Debug.Log("Sent");
            TimerVis.SetActive(true);
            Timer.text = "" + Timer5.ToString("f2");
            Timer5 = Timer5 - Time.deltaTime;
            if (Timer5 <= 0.2f)
            {
                TimerVis.SetActive(false);
                Timer5 = 2.2f;
            }
        }
        if (BtnM3.Button16 == true & BtnM3.Button17 == true)
        {
            G4.LogEvent("PressButton", "Section6Timer", "TimeStart", 1);

            // Builder Hit with all Event parameters.
            G4.LogEvent(new EventHitBuilder()
                .SetEventCategory("PressButton")
                .SetEventAction("Section6Timer")
                .SetEventLabel("TimeStart")
                .SetEventValue(1));

            Debug.Log("Sent");
            TimerVis.SetActive(true);
            Timer.text = "" + Timer6.ToString("f2");
            Timer6 = Timer6 - Time.deltaTime;
            if (Timer6 <= 0.2f)
            {
                TimerVis.SetActive(false);
                Timer6 = 8.2f;
            }
        }
    }
    public void HandleSections()
    {
        if (SectionOne.Section1Complete == false)
        {
            Section1 = true;
            Section2 = false;
            Section3 = false;
            Section4 = false;
            Section5 = false;
            Section6 = false;
        }
      else
        {
            Section1 = false;
            Section2 = true;
            Section3 = false;
            Section4 = false;
            Section5 = false;
            Section6 = false;
        }
        if (SectionTwo.Section2Complete == true)
        {
            Section1 = false;
            Section2 = false;
            Section3 = true;
            Section4 = false;
            Section5 = false;
            Section6 = false;
        }
        if (SectionThree.Section3Complete == true)
        {
            Section1 = false;
            Section2 = false;
            Section3 = false;
            Section4 = true;
            Section5 = false;
            Section6 = false;
        }
        if (SectionFour.Section4Complete == true)
        {
            Section1 = false;
            Section2 = false;
            Section3 = false;
            Section4 = false;
            Section5 = true;
            Section6 = false;
        }
        if (SectionFive.Section5Complete == true)
        {
            Section1 = false;
            Section2 = false;
            Section3 = false;
            Section4 = false;
            Section5 = false;
            Section6 = true;
        }
        if (SectionSix.Section6Complete == true)
        {
            Section1 = false;
            Section2 = false;
            Section3 = false;
            Section4 = false;
            Section5 = false;
            Section6 = false;
        }
    }
    public void HandleResetButton()
    {
        G4.LogEvent("PressButton", "ResetButtonButton", "HasPressed", 1);

        // Builder Hit with all Event parameters.
        G4.LogEvent(new EventHitBuilder()
            .SetEventCategory("PressButton")
            .SetEventAction("ResetButtonButton")
            .SetEventLabel("HasPressed")
            .SetEventValue(1));

        Debug.Log("Sent");
        if (Section1 == true)
        {
            Plyr1.position = new Vector3(-20, Plyr1.position.y, Plyr1.position.z);
            Plyr2.position = new Vector3(-20, Plyr2.position.y, Plyr2.position.z);
        }
        if (Section2 == true)
        {
            Plyr1.position = new Vector3(30, Plyr1.position.y, Plyr1.position.z);
            Plyr2.position = new Vector3(30, Plyr2.position.y, Plyr2.position.z);
        }
        if (Section3 == true)
        {
            Plyr1.position = new Vector3(80, Plyr1.position.y, Plyr1.position.z);
            Plyr2.position = new Vector3(80, Plyr2.position.y, Plyr2.position.z);
            Box1.position = new Vector3(115, -3, Box1.position.z);
        }
        if (Section4 == true)
        {
            Plyr1.position = new Vector3(130, Plyr1.position.y, Plyr1.position.z);
            Plyr2.position = new Vector3(130, Plyr2.position.y, Plyr2.position.z);
            Box2.position = new Vector3(145, 11.5f, Box2.position.z);
            Box3.position = new Vector3(135, 11.5f, Box3.position.z);
            Box4.position = new Vector3(170, 11.5f, Box3.position.z);
        }
        if (Section5 == true)
        {
            Plyr1.position = new Vector3(180, Plyr1.position.y, Plyr1.position.z);
            Plyr2.position = new Vector3(180, Plyr2.position.y, Plyr2.position.z);
            Box5.position = new Vector3(195, -3, Box3.position.z);
            Box6.position = new Vector3(205, -3, Box3.position.z);
        }
        if (Section6 == true)
        {
            Plyr1.position = new Vector3(230, Plyr1.position.y, Plyr1.position.z);
            Plyr2.position = new Vector3(230, Plyr2.position.y, Plyr2.position.z);
        }
    }
}
