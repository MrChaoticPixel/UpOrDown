using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour {

    private Rigidbody P1RB;
    private GameObject Ground;
    private Transform P1Trans;
    public bool IsMoving, IsJumping, OnPad, OnRoofPad, OnFloor, OnRoof;
    public float MovSpd, JmpSpd, RoofGrav;
    public bool facingright, facingleft;


	// Use this for initialization
	void Start ()

    {
        facingright = true;
        facingleft = false;
        P1RB = GetComponent<Rigidbody>();
        P1Trans = GetComponent<Transform>();
        OnPad = false;
        OnRoofPad = false;
        OnFloor = true;
        OnRoof = false;
        IsMoving = false;
        IsJumping = false;
        RoofGrav = 9;
        JmpSpd = 3;
        MovSpd = 10;

        Physics.IgnoreCollision(GameObject.Find("Player_02").GetComponent<Collider>(), GetComponent<Collider>());

    }
	
	// Update is called once per frame
	void FixedUpdate()

    {
        HandleChangeDirection();
        HandleMovement();
        HandleJumping();
        HandleChangeGrav();

        if (OnRoof == true)
        {

        }
        if (OnFloor == true)
        {

        }


    }

    public void HandleChangeDirection()
    {
        if (facingright == true)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        if (facingleft == true)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetAxis("C1Horizontal") > 0)
        {
            facingright = false;
            facingleft = true;
            
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetAxis("C1Horizontal") < 0)
        {
            facingright = true;
            facingleft = false;
        }

        }
    public void HandleChangeGrav()
    {
        if (OnPad == true)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Joystick1Button0))
            {
               OnFloor = false;
               OnRoof = true;
               P1RB.useGravity = false;
            }
        }
        if (OnRoofPad == true)
        {
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Joystick1Button0))
            {
                OnFloor = true;
                OnRoof = false;
                P1RB.useGravity = true;
            }
        }
    }

    public void HandleJumping()
    {
        if (OnFloor == true)
        {
            
            if (IsJumping == false)
            {
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Joystick1Button0))
                {
                    transform.Rotate(180, 0, 0);
                    IsJumping = true;
                    P1RB.AddForce(Vector3.up * JmpSpd, ForceMode.Impulse);
                }
            }
        }
        if (OnRoof == true)
        {

            P1RB.AddForce(Vector3.up * RoofGrav);

            if (IsJumping == false)
            {
                if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Joystick1Button0))
                {
                    transform.Rotate(180, 0, 0);
                    IsJumping = true;
                    P1RB.AddForce(Vector3.down * JmpSpd, ForceMode.Impulse);
                }
            }
        }




    }

    public void HandleMovement()

    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        float JoyHaxis = Input.GetAxis("C1Horizontal");
        float JoyVaxis = Input.GetAxis("C1Vertical");
        Vector3 movement = new Vector3(hAxis, 0, vAxis) * MovSpd * Time.deltaTime;
        Vector3 JoyMov = new Vector3(JoyHaxis, 0, JoyVaxis) * MovSpd * Time.deltaTime;
        if (Input.GetAxis("C1Horizontal") == 0)
        {
                IsMoving = true;
                P1RB.MovePosition(transform.position + movement);
        }
        else
        {
            P1RB.MovePosition(transform.position + -JoyMov);
        }
     
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsJumping = false;
            OnFloor = true;
            OnRoof = false;
        }
        if (collision.gameObject.tag == "Roof")
        {
            IsJumping = false;
            OnFloor = false;
            OnRoof = true;
        }
        if (collision.gameObject.tag == "GravPad")
        {
            IsJumping = false;
            OnPad = true;
        }
        if (collision.gameObject.tag == "RoofGravPad")
        {
            IsJumping = false;
            OnRoofPad = true;
        }
        if (collision.gameObject.tag == "Button")
        {
            IsJumping = false;

        }
        if (collision.gameObject.tag == "ExtraBlock")
        {
            IsJumping = false;
        }
        if (collision.gameObject.name == "TeleportPadFloor_01")
        {
                P1Trans.position = new Vector3(15, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_01")
        {
            P1Trans.position = new Vector3(0, -3, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_02")
        {
                P1Trans.position = new Vector3(60, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_02")
        {
                P1Trans.position = new Vector3(35, -3, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_03")
        {
            P1Trans.position = new Vector3(90, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_03")
        {
            P1Trans.position = new Vector3(110, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_04")
        {
            P1Trans.position = new Vector3(160, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_04")
        {
            P1Trans.position = new Vector3(150, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_05")
        {
            P1Trans.position = new Vector3(150, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_05")
        {
            P1Trans.position = new Vector3(160, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_06")
        {
            P1Trans.position = new Vector3(185, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_06")
        {
            P1Trans.position = new Vector3(185, -3, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_07")
        {
            P1Trans.position = new Vector3(215, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_07")
        {
            P1Trans.position = new Vector3(215, -3, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_08")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_08")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_09")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_10")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_11")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_12")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_09")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_10")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_11")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_12")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsJumping = false;
            OnFloor = true;
            OnRoof = false;
        }
        if (collision.gameObject.tag == "GravPad")
        {
            IsJumping = false;
            OnPad = true;
        }
        if (collision.gameObject.tag == "RoofGravPad")
        {
            IsJumping = false;
            OnRoofPad = true;
        }
        if (collision.gameObject.tag == "Roof")
        {
            IsJumping = false;
            OnFloor = false;
            OnRoof = true;
        }
        if (collision.gameObject.tag == "Button")
        {
            IsJumping = false;
          
        }
        if (collision.gameObject.tag == "ExtraBlock")
        {
            IsJumping = false;
        }
        if (collision.gameObject.name == "TeleportPadFloor_01")
        {
                P1Trans.position = new Vector3(15, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_01")
        {
            P1Trans.position = new Vector3(0, -3, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_02")
        {
                P1Trans.position = new Vector3(60, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_02")
        {
                P1Trans.position = new Vector3(35, -3, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_03")
        {
            P1Trans.position = new Vector3(90, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_03")
        {
            P1Trans.position = new Vector3(110, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_04")
        {
            P1Trans.position = new Vector3(160, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_04")
        {
            P1Trans.position = new Vector3(150, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_05")
        {
            P1Trans.position = new Vector3(150, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_05")
        {
            P1Trans.position = new Vector3(160, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_06")
        {
            P1Trans.position = new Vector3(185, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_06")
        {
            P1Trans.position = new Vector3(185, -3, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_07")
        {
            P1Trans.position = new Vector3(215, 23, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_07")
        {
            P1Trans.position = new Vector3(215, -3, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_08")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_08")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_09")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_10")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_11")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_12")
        {
            P1Trans.position = new Vector3(235, 7, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_09")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_10")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_11")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
         if (collision.gameObject.name == "TeleportPadRoof_12")
        {
            P1Trans.position = new Vector3(235, 12, P1Trans.position.z);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "GravPad")
        {
            OnPad = false;
        }
        if (collision.gameObject.tag == "RoofGravPad")
        {
            OnRoofPad = false;
        }
    }

}
