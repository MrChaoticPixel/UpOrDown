using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1UI : MonoBehaviour {

    public bool Section1, Section2, Section3, Section4;
    public Transform Box1, Box2, Box3, Plyr1, Plyr2;
    public WallProgression SectionOne, SectionTwo, SectionThree, SectionFour;

    // Use this for initialization
    void Start () {

        Section1 = true;
        Section2 = false;
        Section3 = false;
        Section4 = false;

    }
	
	// Update is called once per frame
	void Update () {

        HandleSections();
		
	}
    public void HandleSections()
    {
        if (SectionOne.Section1Complete == false)
        {
            Section1 = true;
            Section2 = false;
            Section3 = false;
            Section4 = false;
        }
      else
        {
            Section1 = false;
            Section2 = true;
            Section3 = false;
            Section4 = false;
        }
        if (SectionTwo.Section2Complete == true)
        {
            Section1 = false;
            Section2 = false;
            Section3 = true;
            Section4 = false;
        }
        if (SectionThree.Section3Complete == true)
        {
            Section1 = false;
            Section2 = false;
            Section3 = false;
            Section4 = true;
        }
    }
    public void HandleResetButton()
    {
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
            Box1.position = new Vector3(110, -3, Box1.position.z);
        }
        if (Section4 == true)
        {
            Plyr1.position = new Vector3(130, Plyr1.position.y, Plyr1.position.z);
            Plyr2.position = new Vector3(130, Plyr2.position.y, Plyr2.position.z);
            Box2.position = new Vector3(135, -3, Box2.position.z);
            Box3.position = new Vector3(140, -3, Box3.position.z);
        }
    }
}
