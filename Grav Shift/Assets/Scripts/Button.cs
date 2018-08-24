using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public GameObject ThisButton;
    public Material On, Off;
    public bool ButtonIsOn, TimedOn;
    public MeshRenderer ThisMesh;

	// Use this for initialization
	void Start () {

        TimedOn = false;
        ThisMesh = GetComponent<MeshRenderer>();
        ButtonIsOn = false;
        ThisMesh.material = Off;

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (ButtonIsOn == false)
        {
            if (TimedOn == false)
            {
                ThisMesh.material = Off;
            }
        }
        else
        {
            if (TimedOn == false)
            {
                ButtonIsOn = false;
            }
        }

		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            if (ButtonIsOn == false)
            {
                ThisMesh.material = On;
                ButtonIsOn = true;
            }
        }
        if (collision.gameObject.tag == "WeightBox")

        {
            if (ButtonIsOn == false)
            {
                ThisMesh.material = On;
                ButtonIsOn = true;
            }
        }
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            if (ButtonIsOn == false)
            {
                ThisMesh.material = On;
                ButtonIsOn = true;
            }
      
        }
        if (collision.gameObject.tag == "WeightBox")

        {
            if (ButtonIsOn == false)
            {
                ThisMesh.material = On;
                ButtonIsOn = true;
            }
        }

    }
    private void OnTriggerExit(Collider collision)

    {
        if (collision.gameObject.tag == "Player")

        {
            if (TimedOn == false)
            {
                ThisMesh.material = Off;
                ButtonIsOn = false;
            }
         
        }
        if (collision.gameObject.tag == "WeightBox")

        {
            if (TimedOn == false)
            {
                ThisMesh.material = Off;
                ButtonIsOn = false;
            }

        }
    }



    }
