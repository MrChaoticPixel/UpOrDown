using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class WeightedBox : MonoBehaviour {


    public AudioSource Teleport, Gravity;
    public bool OnGravPad, OnRoofGravPad, Grav, NoGrav;
    public Rigidbody BoxRB;
    public Transform BoxTrans;

	// Use this for initialization
	void Start () {

        BoxRB = GetComponent<Rigidbody>();
        BoxTrans = GetComponent<Transform>();
        OnGravPad = false;
        OnRoofGravPad = false;
        Grav = false;
        NoGrav = false;

       // Physics.IgnoreCollision(GameObject.Find("PushableBlock_01 1").GetComponent<Collider>(), GetComponent<Collider>());
       // Physics.IgnoreCollision(GameObject.Find("PushableBlock_01 2").GetComponent<Collider>(), GetComponent<Collider>());


    }
	
	// Update is called once per frame
	void FixedUpdate ()

    {
        HandleBoxGravShift();
        HandleGravityForce();

    }
    private void HandleGravityForce()
    {
        if (Grav == true)
        {
            BoxRB.AddForce(Vector3.down * 5);
        }
        if (NoGrav == true)
        {
            BoxRB.AddForce(Vector3.up * 5);
        }
    }
    private void HandleBoxGravShift()
    {
        if (OnGravPad == true)
        {
            Gravity.Play();
            BoxRB.AddForce(Vector3.up * 3, ForceMode.Impulse);
            BoxRB.useGravity = false;
            NoGrav = true;
            Grav = false;
        }
        if (OnRoofGravPad == true)
        {
            Gravity.Play();
            BoxRB.AddForce(Vector3.down * 3, ForceMode.Impulse);
            BoxRB.useGravity = true;
            NoGrav = false;
            Grav = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GravPad")
        {
            OnGravPad = true;
        }
        if (collision.gameObject.tag == "RoofGravPad")
        {
            OnRoofGravPad = true;
        }
        if (collision.gameObject.name == "TeleportPadFloor_03")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(90, 23, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_03")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(110, 12, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_04")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(160, 7, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_04")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(150, 12, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_05")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(150, 7, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_05")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(160, 12, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_06")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(185, 23, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_06")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(185, -3, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_07")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(215, 23, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_07")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(215, -3, BoxTrans.position.z);
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "GravPad")
        {
            OnGravPad = true;
        }
        if (collision.gameObject.tag == "RoofGravPad")
        {
            OnRoofGravPad = true;
        }
        if (collision.gameObject.name == "TeleportPadFloor_03")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(90, 23, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_03")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(110, 12, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_04")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(160, 7, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_04")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(150, 12, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_05")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(150, 7, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_05")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(160, 12, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_06")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(185, 23, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_06")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(185, -3, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_07")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(215, 23, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_07")
        {
            Teleport.Play();
            BoxTrans.position = new Vector3(215, -3, BoxTrans.position.z);
        }
       /* if (collision.gameObject.name == "TeleportPadFloor_UI1")
        {
            BoxTrans.position = new Vector3(-55, -50, BoxTrans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_UI2")
        {
            BoxTrans.position = new Vector3(55, 100, BoxTrans.position.z);
        }*/
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "GravPad")
        {
            OnGravPad = false;
        }
        if (collision.gameObject.tag == "RoofGravPad")
        {
            OnRoofGravPad = false;
        }
    }
}
