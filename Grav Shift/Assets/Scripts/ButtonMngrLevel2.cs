using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMngrLevel2 : MonoBehaviour {

    public bool Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16, Button17;
    public bool Wall1, Wall2, Wall3, Wall4, Wall5, Wall6;
    public Button ButtonOne, ButtonTwo, ButtonThree, ButtonFour, ButtonFive, ButtonSix, ButtonSeven, ButtonEight, ButtonNine, ButtonTen, ButtonEleven;
    public Button ButtonTwelve, ButtonThirteen, ButtonFourteen, ButtonFifteen, ButtonSixteen, ButtonSeventeen;
    public bool InvokeTimer;
    public float TimeOne, TimeTwo, TimeThree, TimeFour, TimeFive, TimeSix;
   


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
        ButtonTwelve = GameObject.Find("Button_12").GetComponent<Button>();
        ButtonThirteen = GameObject.Find("Button_13").GetComponent<Button>();
        ButtonFourteen = GameObject.Find("Button_14").GetComponent<Button>();
        ButtonFifteen = GameObject.Find("Button_15").GetComponent<Button>();
        ButtonSixteen = GameObject.Find("Button_16").GetComponent<Button>();
        ButtonSeventeen = GameObject.Find("Button_17").GetComponent<Button>();
        Wall1 = false;
        Wall2 = false;
        Wall3 = false;
        Wall4 = false;
        Wall5 = false;
        Wall6 = false;
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
        Button12 = false;
        Button13 = false;
        Button14 = false;
        Button15 = false;
        Button16 = false;
        Button17 = false;
        InvokeTimer = false;
        TimeOne = 5;
        TimeTwo = 1;
        TimeThree = 5;
        TimeFour = 3;
        TimeFive = 2;
        TimeSix = 1;


    }
	
	// Update is called once per frame
	void Update ()

    {
        HandleButtons();
        HandleProgression();
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
        if (ButtonTwelve.ButtonIsOn == true)
        {
            Button12 = true;
        }
        else
        {
            Button12 = false;
        }
        if (ButtonThirteen.ButtonIsOn == true)
        {
            Button13 = true;
        }
        else
        {
            Button13 = false;
        }
        if (ButtonFourteen.ButtonIsOn == true)
        {
            Button14 = true;
        }
        else
        {
            Button14 = false;
        }
        if (ButtonFifteen.ButtonIsOn == true)
        {
            Button15 = true;
        }
        else
        {
            Button15 = false;
        }
        if (ButtonSixteen.ButtonIsOn == true)
        {
            Button16 = true;
        }
        else
        {
            Button16 = false;
        }
        if (ButtonSeventeen.ButtonIsOn == true)
        {
            Button17 = true;
        }
        else
        {
            Button17 = false;
        }

    }

    public void HandleProgression()
    {
        if(Button1 == true & Button2 == true)
        {
           Wall1 = true;
           ButtonOne.TimedOn = true;
           ButtonTwo.TimedOn = true;
            TimeOne = TimeOne - Time.deltaTime;
            if (TimeOne <= 0)
            {
                Invoke("ButtonTimerOne", 0);
              
            }
           

        }
        if (Button3 == true & Button4 == true)
        {
            Wall2 = true;
            ButtonThree.TimedOn = true;
            ButtonFour.TimedOn = true;
            TimeTwo = TimeTwo - Time.deltaTime;
            if (TimeTwo <= 0)
            {
                Invoke("ButtonTimerTwo", 0);

            }
        }
        if (Button5 == true & Button6 == true & Button7 == true)
        {
            Wall3 = true;
            ButtonFive.TimedOn = true;
            ButtonSix.TimedOn = true;
            ButtonSeven.TimedOn = true;
            TimeThree = TimeThree - Time.deltaTime;
            if (TimeThree <= 0)
            {
                Invoke("ButtonTimerThree", 0);

            }
        }
        if (Button8 == true & Button9 == true & Button10 == true & Button11 == true)
        {
            Wall4 = true;
            ButtonEight.TimedOn = true;
            ButtonNine.TimedOn = true;
            ButtonTen.TimedOn = true;
            ButtonEleven.TimedOn = true;
            TimeFour = TimeFour - Time.deltaTime;
            if (TimeFour <= 0)
            {
                Invoke("ButtonTimerFour", 0);

            }
        }
        if (Button12 == true & Button13 == true & Button14 == true & Button15 == true)
        {
            Wall5 = true;
            ButtonTwelve.TimedOn = true;
            ButtonThirteen.TimedOn = true;
            ButtonFourteen.TimedOn = true;
            ButtonFifteen.TimedOn = true;
            TimeFive = TimeFive - Time.deltaTime;
            if (TimeFive <= 0)
            {
                Invoke("ButtonTimerFive", 0);

            }
        }
        if (Button16 == true & Button17 == true)
        {
            Wall6 = true;
            ButtonSixteen.TimedOn = true;
            ButtonSeventeen.TimedOn = true;
            TimeSix = TimeSix - Time.deltaTime;
            if (TimeSix <= 0)
            {
                Invoke("ButtonTimerSix", 0);

            }
        }
    }

    public void ButtonTimerOne()
    {

        ButtonOne.ButtonIsOn = false;
        ButtonTwo.ButtonIsOn = false;
        ButtonOne.TimedOn = false;
        ButtonTwo.TimedOn = false;
        Wall1 = false;
        TimeOne = 5;
    }
    public void ButtonTimerTwo()
    {

        ButtonThree.ButtonIsOn = false;
        ButtonFour.ButtonIsOn = false;
        ButtonThree.TimedOn = false;
        ButtonFour.TimedOn = false;
        Wall2 = false;
        TimeTwo = 1;
    }
    public void ButtonTimerThree()
    {

        ButtonFive.ButtonIsOn = false;
        ButtonSix.ButtonIsOn = false;
        ButtonSeven.ButtonIsOn = false;
        ButtonFive.TimedOn = false;
        ButtonSix.TimedOn = false;
        ButtonSeven.TimedOn = false;
        Wall3 = false;
        TimeThree = 5;
    }
    public void ButtonTimerFour()
    {

        ButtonEight.ButtonIsOn = false;
        ButtonNine.ButtonIsOn = false;
        ButtonTen.ButtonIsOn = false;
        ButtonEleven.ButtonIsOn = false;
        ButtonEight.TimedOn = false;
        ButtonNine.TimedOn = false;
        ButtonTen.TimedOn = false;
        ButtonEleven.TimedOn = false;
        Wall4 = false;
        TimeFour = 3;
    }
    public void ButtonTimerFive()
    {

        ButtonTwelve.ButtonIsOn = false;
        ButtonThirteen.ButtonIsOn = false;
        ButtonFourteen.ButtonIsOn = false;
        ButtonFifteen.ButtonIsOn = false;
        ButtonTwelve.TimedOn = false;
        ButtonThirteen.TimedOn = false;
        ButtonFourteen.TimedOn = false;
        ButtonFifteen.TimedOn = false;
        Wall5 = false;
        TimeFive = 3;
    }
    public void ButtonTimerSix()
    {

        ButtonSixteen.ButtonIsOn = false;
        ButtonSeventeen.ButtonIsOn = false;
        ButtonSixteen.TimedOn = false;
        ButtonSeventeen.TimedOn = false;
        Wall6 = false;
        TimeSix = 1;
    }
}
