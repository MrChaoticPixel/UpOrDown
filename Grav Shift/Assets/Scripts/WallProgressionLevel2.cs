using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallProgressionLevel2 : MonoBehaviour {


    public AudioSource Portal;
    public ButtonMngrLevel2 ButtonMan;
    public MeshRenderer WallMesh1, WallMesh2, WallMesh3, WallMesh4, WallMesh5, WallMesh6;
    public Material WallOn, WallOff;
    public bool Wall1PortalActive, Wall2PortalActive, Wall3PortalActive, Wall4PortalActive, Wall5PortalActive, Wall6PortalActive;
    public bool Section1Complete, Section2Complete, Section3Complete, Section4Complete, Section5Complete, Section6Complete;
    public Transform Plyr1, Plyr2, MainCam;
    public GameObject victory, portal1, portal2, portal3, portal4, portal5, portal6;
    
    


	// Use this for initialization
	void Start () {

        Portal = GetComponent<AudioSource>();

        portal1.SetActive(false);
        portal2.SetActive(false);
        portal3.SetActive(false);
        portal4.SetActive(false);
        portal5.SetActive(false);
        portal6.SetActive(false);

        Section1Complete = false;
        Section2Complete = false;
        Section3Complete = false;
        Section4Complete = false;
        Section5Complete = false;
        Section6Complete = false;

        Wall1PortalActive = false;
        Wall2PortalActive = false;
        Wall3PortalActive = false;
        Wall4PortalActive = false;
        Wall5PortalActive = false;
        Wall6PortalActive = false;

        WallMesh1 = GameObject.Find("DestroyWall_01").GetComponent<MeshRenderer>();
        WallMesh2 = GameObject.Find("DestroyWall_02").GetComponent<MeshRenderer>();
        WallMesh3 = GameObject.Find("DestroyWall_03").GetComponent<MeshRenderer>();
        WallMesh4 = GameObject.Find("DestroyWall_04").GetComponent<MeshRenderer>();
        WallMesh5 = GameObject.Find("DestroyWall_05").GetComponent<MeshRenderer>();
        WallMesh6 = GameObject.Find("DestroyWall_06").GetComponent<MeshRenderer>();


    }
	
	// Update is called once per frame
	void FixedUpdate () {

        HandleWallProgression();
    }

    public void HandleWallProgression()
    {
        if (ButtonMan.Wall1 == true)
        {
           // Portal.Play();
            //Debug.Log("Hello");
            portal1.SetActive(true);
            WallMesh1.material = WallOn;
            Wall1PortalActive = true;
        }
        else
        {
            portal1.SetActive(false);
            WallMesh1.material = WallOff;
            Wall1PortalActive = false;
        }
        if (ButtonMan.Wall2 == true)
        {
           // Portal.Play();
            //Debug.Log("Hello");
            portal2.SetActive(true);
            WallMesh2.material = WallOn;
            Wall2PortalActive = true;
        }
        else
        {
            portal2.SetActive(false);
            WallMesh2.material = WallOff;
            Wall2PortalActive = false;
        }
        if (ButtonMan.Wall3 == true)
        {
           // Portal.Play();
            //Debug.Log("Hello");
            portal3.SetActive(true);
            WallMesh3.material = WallOn;
            Wall3PortalActive = true;
        }
        else
        {
            portal3.SetActive(false);
            WallMesh3.material = WallOff;
            Wall3PortalActive = false;
        }
        if (ButtonMan.Wall4 == true)
        {
           // Portal.Play();
            //Debug.Log("Hello");
            portal4.SetActive(true);
            WallMesh4.material = WallOn;
            Wall4PortalActive = true;
        }
        else
        {
            portal4.SetActive(false);
            WallMesh4.material = WallOff;
            Wall4PortalActive = false;
        }
        if (ButtonMan.Wall5 == true)
        {
          //  Portal.Play();
            //Debug.Log("Hello");
            portal5.SetActive(true);
            WallMesh5.material = WallOn;
            Wall5PortalActive = true;
        }
        else
        {
            portal5.SetActive(false);
            WallMesh5.material = WallOff;
            Wall5PortalActive = false;
        }
        if (ButtonMan.Wall6 == true)
        {
           // Portal.Play();
            //Debug.Log("Hello");
            portal6.SetActive(true);
            WallMesh6.material = WallOn;
            Wall6PortalActive = true;
        }
        else
        {
            portal6.SetActive(false);
            WallMesh6.material = WallOff;
            Wall6PortalActive = false;
        }

    }
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Wall1PortalActive == true)
            {
                Portal.Play();
                Plyr1.position = new Vector3(30, Plyr1.position.y, Plyr1.position.z);
                Plyr2.position = new Vector3(30, Plyr2.position.y, Plyr2.position.z);
                MainCam.position = new Vector3(50, MainCam.position.y, MainCam.position.z);
                Section1Complete = true;
                Section2Complete = false;
                Section3Complete = false;
                Section4Complete = false;
                Section5Complete = false;
                Section6Complete = false;
                Wall1PortalActive = false;
            }
            if (Wall2PortalActive == true)
            {
                Portal.Play();
                Plyr1.position = new Vector3(80, Plyr1.position.y, Plyr1.position.z);
                Plyr2.position = new Vector3(80, Plyr2.position.y, Plyr2.position.z);
                MainCam.position = new Vector3(100, MainCam.position.y, MainCam.position.z);
                Section1Complete = true;
                Section2Complete = true;
                Section3Complete = false;
                Section4Complete = false;
                Section5Complete = false;
                Section6Complete = false;
                Wall2PortalActive = false;
            }
            if (Wall3PortalActive == true)
            {
                Portal.Play();
                Plyr1.position = new Vector3(130, Plyr1.position.y, Plyr1.position.z);
                Plyr2.position = new Vector3(130, Plyr2.position.y, Plyr2.position.z);
                MainCam.position = new Vector3(150, MainCam.position.y, MainCam.position.z);
                Section1Complete = true;
                Section2Complete = true;
                Section3Complete = true;
                Section4Complete = false;
                Section5Complete = false;
                Section6Complete = false;
                Wall3PortalActive = false;
            }
            if (Wall4PortalActive == true)
            {
                Portal.Play();
                Plyr1.position = new Vector3(180, Plyr1.position.y, Plyr1.position.z);
                Plyr2.position = new Vector3(180, Plyr2.position.y, Plyr2.position.z);
                MainCam.position = new Vector3(200, MainCam.position.y, MainCam.position.z);
                Section1Complete = true;
                Section2Complete = true;
                Section3Complete = true;
                Section4Complete = true;
                Section5Complete = false;
                Section6Complete = false;
                Wall4PortalActive = false;

            }
            if (Wall5PortalActive == true)
            {
                Portal.Play();
                Plyr1.position = new Vector3(230, Plyr1.position.y, Plyr1.position.z);
                Plyr2.position = new Vector3(230, Plyr2.position.y, Plyr2.position.z);
                MainCam.position = new Vector3(250, MainCam.position.y, MainCam.position.z);
                Section1Complete = true;
                Section2Complete = true;
                Section3Complete = true;
                Section4Complete = true;
                Section5Complete = true;
                Section6Complete = false;
                Wall5PortalActive = false;
            }
            if (Wall6PortalActive == true)
            {
                Portal.Play();
                GameUI.Level2Complete = 1;
                PlayerPrefs.SetFloat("Level2Complete", GameUI.Level2Complete);
                SceneManager.LoadScene("Main");
                //victory.SetActive(true);
                Section1Complete = true;
                Section2Complete = true;
                Section3Complete = true;
                Section4Complete = true;
                Section5Complete = true;
                Section6Complete = true;
                Wall6PortalActive = false;
            }
        }

    }
    private void OnCollisionStay(Collision collision)
    {

    }
    private void OnCollisionExit(Collision collision)
    {

    }
}
