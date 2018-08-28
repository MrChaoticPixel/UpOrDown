using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallProgression : MonoBehaviour {

    public ButtonMngr ButtonMan;
    public MeshRenderer WallMesh1, WallMesh2, WallMesh3, WallMesh4;
    public Material WallOn, WallOff;
    public bool Wall1PortalActive, Wall2PortalActive, Wall3PortalActive, Wall4PortalActive;
    public bool Section1Complete, Section2Complete, Section3Complete, Section4Complete;
    public Transform Plyr1, Plyr2, MainCam;
    public GameObject victory, portal1, portal2, portal3, portal4;
    


	// Use this for initialization
	void Start () {

        portal1.SetActive(false);
        portal2.SetActive(false);
        portal3.SetActive(false);
        portal4.SetActive(false);

        Section1Complete = false;
        Section2Complete = false;
        Section3Complete = false;
        Section4Complete = false;

        Wall1PortalActive = false;
        Wall2PortalActive = false;
        Wall3PortalActive = false;
        Wall4PortalActive = false;

        WallMesh1 = GameObject.Find("DestroyWall_01").GetComponent<MeshRenderer>();
        WallMesh2 = GameObject.Find("DestroyWall_02").GetComponent<MeshRenderer>();
        WallMesh3 = GameObject.Find("DestroyWall_03").GetComponent<MeshRenderer>();
        WallMesh4 = GameObject.Find("DestroyWall_04").GetComponent<MeshRenderer>();


    }
	
	// Update is called once per frame
	void FixedUpdate () {

        HandleWallProgression();
    }

    public void HandleWallProgression()
    {
        if (ButtonMan.Wall1 == true)
        {
            //Debug.Log("Hello");
            portal1.SetActive(true);
            WallMesh1.material = WallOn;
            Wall1PortalActive = true;
        }
        else
        {
            portal1.SetActive(false);
            WallMesh1.material = WallOff;
        }
        if (ButtonMan.Wall2 == true)
        {
            //Debug.Log("Hello");
            portal2.SetActive(true);
            WallMesh2.material = WallOn;
            Wall2PortalActive = true;
        }
        else
        {
            portal2.SetActive(false);
            WallMesh2.material = WallOff;
        }
        if (ButtonMan.Wall3 == true)
        {
            //Debug.Log("Hello");
            portal3.SetActive(true);
            WallMesh3.material = WallOn;
            Wall3PortalActive = true;
        }
        else
        {
            portal3.SetActive(false);
            WallMesh3.material = WallOff;
        }
        if (ButtonMan.Wall4 == true)
        {
            //Debug.Log("Hello");
            portal4.SetActive(true);
            WallMesh4.material = WallOn;
            Wall4PortalActive = true;
        }
        else
        {
            portal4.SetActive(false);
            WallMesh4.material = WallOff;
        }

    }
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Wall1PortalActive == true)
            {
                Plyr1.position = new Vector3(30, Plyr1.position.y, Plyr1.position.z);
                Plyr2.position = new Vector3(30, Plyr2.position.y, Plyr2.position.z);
                MainCam.position = new Vector3(50, MainCam.position.y, MainCam.position.z);
                Section1Complete = true;
                Wall1PortalActive = false;
            }
            if (Wall2PortalActive == true)
            {
                Plyr1.position = new Vector3(80, Plyr1.position.y, Plyr1.position.z);
                Plyr2.position = new Vector3(80, Plyr2.position.y, Plyr2.position.z);
                MainCam.position = new Vector3(100, MainCam.position.y, MainCam.position.z);
                Section2Complete = true;
                Wall2PortalActive = false;
            }
            if (Wall3PortalActive == true)
            {

                Plyr1.position = new Vector3(130, Plyr1.position.y, Plyr1.position.z);
                Plyr2.position = new Vector3(130, Plyr2.position.y, Plyr2.position.z);
                MainCam.position = new Vector3(150, MainCam.position.y, MainCam.position.z);
                Section3Complete = true;
                Wall3PortalActive = false;
            }
            if (Wall4PortalActive == true)
            {
                GameUI.Level1Complete = 1;
                PlayerPrefs.SetFloat("Level1Complete", GameUI.Level1Complete);
                SceneManager.LoadScene("Main");
                //victory.SetActive(true);        
                Section4Complete = true;
                Wall4PortalActive = false;


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
