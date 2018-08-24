using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMngr : MonoBehaviour {

    public bool Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11;
    public bool Wall1, Wall2, Wall3, Wall4;
    public Button ButtonOne, ButtonTwo, ButtonThree, ButtonFour, ButtonFive, ButtonSix, ButtonSeven, ButtonEight, ButtonNine, ButtonTen, ButtonEleven;
    public WallProgression sec1, sec2, sec3, sec4;



    // Use this for initialization
    void Start ()

    {
        ButtonOne = GameObject.Find("Button_01").GetComponent<Button>();
        ButtonTwo = GameObject.Find("Button_02").GetComponent<Button>();
        ButtonThree = GameObject.Find("Button_03").GetComponent<Button>();
        ButtonFour = GameObject.Find("Button_04").GetComponent<Button>();
        ButtonFive = GameObject.Find("Button_05").GetComponent<Button>();
        ButtonSix = GameObject.Find("Button_06").GetComponent<Button>();
        ButtonSeven = GameObject.Find("Button_07").GetComponent<Button>();
        ButtonEight = GameObject.Find("Button_08").GetComponent<Button>();
        ButtonNine = GameObject.Find("Button_09").GetComponent<Button>();
        ButtonTen = GameObject.Find("Button_10").GetComponent<Button>();
        ButtonEleven = GameObject.Find("Button_11").GetComponent<Button>();
        Wall1 = false;
        Wall2 = false;
        Wall3 = false;
        Wall4 = false;
        Button1 = false;
        Button2 = false;
        Button3 = false;
        Button4 = false;
        Button5 = false;
        Button6 = false;
        Button7 = false;
        Button8 = false;
        Button9 = false;
        Button10 = false;
        Button11 = false;

    }
	
	// Update is called once per frame
	void Update ()

    {
        HandleButtons();
        HandleProgression();

        if (sec1.Section1Complete == true)
        {
            sec2.Wall1PortalActive = false;
            sec3.Wall1PortalActive = false;
            sec4.Wall1PortalActive = false;
            Wall1 = false;
            ButtonOne.TimedOn = false;
            ButtonTwo.TimedOn = false;
        }

        if (sec2.Section2Complete == true)
        {
            sec3.Wall2PortalActive = false;
            sec4.Wall2PortalActive = false;
            Wall2 = false;
            ButtonThree.TimedOn = false;
            ButtonFour.TimedOn = false;
        }

        if (sec3.Section3Complete == true)
        {

            sec4.Wall3PortalActive = false;
            Wall3 = false;
            ButtonFive.TimedOn = false;
            ButtonSix.TimedOn = false;
            ButtonSeven.TimedOn = false;
        }
    }

    public void HandleButtons()

    {
       if (ButtonOne.ButtonIsOn == true)
        {
            Button1 = true;
        }
        else
        {
            Button1 = false;
        }
        if (ButtonTwo.ButtonIsOn == true)
        {
            Button2 = true;
        }
        else
        {
            Button2 = false;
        }
        if (ButtonThree.ButtonIsOn == true)
        {
            Button3 = true;
        }
        else
        {
            Button3 = false;
        }
        if (ButtonFour.ButtonIsOn == true)
        {
            Button4 = true;
        }
        else
        {
            Button4 = false;
        }
        if (ButtonFive.ButtonIsOn == true)
        {
            Button5 = true;
        }
        else
        {
            Button5 = false;
        }
        if (ButtonSix.ButtonIsOn == true)
        {
            Button6 = true;
        }
        else
        {
            Button6 = false;
        }
        if (ButtonSeven.ButtonIsOn == true)
        {
            Button7 = true;
        }
        else
        {
            Button7 = false;
        }
        if (ButtonEight.ButtonIsOn == true)
        {
            Button8 = true;
        }
        else
        {
            Button8 = false;
        }
        if (ButtonNine.ButtonIsOn == true)
        {
            Button9 = true;
        }
        else
        {
            Button9 = false;
        }
        if (ButtonTen.ButtonIsOn == true)
        {
            Button10 = true;
        }
        else
        {
            Button10 = false;
        }
        if (ButtonEleven.ButtonIsOn == true)
        {
            Button11 = true;
        }
        else
        {
            Button11 = false;
        }

    }

    public void HandleProgression()
    {
        if(Button1 == true & Button2 == true)
        {
           Wall1 = true;
           ButtonOne.TimedOn = true;
           ButtonTwo.TimedOn = true;
        }
        if (Button3 == true & Button4 == true)
        {
            Wall2 = true;
            ButtonThree.TimedOn = true;
            ButtonFour.TimedOn = true;
        }
        if (Button5 == true & Button6 == true & Button7 == true)
        {
            Wall3 = true;
            ButtonFive.TimedOn = true;
            ButtonSix.TimedOn = true;
            ButtonSeven.TimedOn = true;
        }
        if (Button8 == true & Button9 == true & Button10 == true & Button11 == true)
        {
            Wall4 = true;
            ButtonEight.TimedOn = true;
            ButtonNine.TimedOn = true;
            ButtonTen.TimedOn = true;
            ButtonEleven.TimedOn = true;
        }
    }
}
