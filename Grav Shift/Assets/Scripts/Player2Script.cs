using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour {

    private Rigidbody P2RB;
    private GameObject Ground;
    private Transform P2Trans;
    public bool IsMoving, IsJumping, OnPad, OnRoofPad, OnFloor, OnRoof;
    public float MovSpd, JmpSpd, RoofGrav;
    public bool facingright, facingleft;


    // Use this for initialization
    void Start ()

    {
        facingright = true;
        facingleft = false;
        P2RB = GetComponent<Rigidbody>();
        P2Trans = GetComponent<Transform>();
        OnPad = false;
        OnRoofPad = false;
        OnFloor = true;
        OnRoof = false;
        IsMoving = false;
        IsJumping = false;
        RoofGrav = 9;
        JmpSpd = 3;
        MovSpd = 10;

        Physics.IgnoreCollision(GameObject.Find("Player_01").GetComponent<Collider>(), GetComponent<Collider>());

    }
	
	// Update is called once per frame
	void FixedUpdate()

    {

        HandleChangeDirection();
        HandleMovement();
        HandleJumping();
        HandleChangeGrav();


    }
    public void HandleChangeDirection()
    {
        if (facingright == true)
        {
            if (OnFloor == true)
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1);
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, -1);
            }

        }
        if (facingleft == true)
        {
            if (OnFloor == true)
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, -1);
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetAxis("C2Horizontal") > 0)
        {
            facingright = false;
            facingleft = true;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetAxis("C2Horizontal") < 0)
        {
            facingright = true;
            facingleft = false;
        }

    }
    public void HandleChangeGrav()
    {
        if (OnPad == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Joystick2Button0))
            {
                transform.Rotate(180, 0, 0);
                OnFloor = false;
                OnRoof = true;
                P2RB.useGravity = false;
            }
        }
        if (OnRoofPad == true)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.Joystick2Button0))
            {
                transform.Rotate(180, 0, 0);
                OnFloor = true;
                OnRoof = false;
                P2RB.useGravity = true;
            }
        }
    }

    public void HandleJumping()
    {
        if (OnFloor == true)
        {
            if (IsJumping == false)
            {
                if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Joystick2Button0))
                {
                    IsJumping = true;
                    P2RB.AddForce(Vector3.up * JmpSpd, ForceMode.Impulse);
                }
            }
        }
        if (OnRoof == true)
        {
            P2RB.AddForce(Vector3.up * RoofGrav);

            if (IsJumping == false)
            {
                if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.Joystick2Button0))
                {
                    IsJumping = true;
                    P2RB.AddForce(Vector3.down * JmpSpd, ForceMode.Impulse);
                }
            }
        }




    }

    public void HandleMovement()

    {
        float hAxis = Input.GetAxis("HorizontalTwo");
        float vAxis = Input.GetAxis("Vertical");
        float JoyHaxis = Input.GetAxis("C2Horizontal");
        float JoyVaxis = Input.GetAxis("C2Vertical");
        Vector3 movement = new Vector3(hAxis, 0, vAxis) * MovSpd * Time.deltaTime;
        Vector3 JoyMov = new Vector3(JoyHaxis, 0, JoyVaxis) * MovSpd * Time.deltaTime;

        if (Input.GetAxis("C2Horizontal") == 0)
        {
                IsMoving = true;
                P2RB.MovePosition(transform.position + movement);
        }
        else
        {
            P2RB.MovePosition(transform.position + JoyMov);
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
                P2Trans.position = new Vector3(15, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_01")
        {
            P2Trans.position = new Vector3(0, -1, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_02")
        {
                P2Trans.position = new Vector3(60, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_02")
        {
                P2Trans.position = new Vector3(35, -1, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_03")
        {
            P2Trans.position = new Vector3(90, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_03")
        {
            P2Trans.position = new Vector3(110, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_04")
        {
            P2Trans.position = new Vector3(160, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_04")
        {
            P2Trans.position = new Vector3(150, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_05")
        {
            P2Trans.position = new Vector3(150, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_05")
        {
            P2Trans.position = new Vector3(160, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_06")
        {
            P2Trans.position = new Vector3(185, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_06")
        {
            P2Trans.position = new Vector3(185, -1, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_07")
        {
            P2Trans.position = new Vector3(215, 23, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_07")
        {
            P2Trans.position = new Vector3(215, -1, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_08")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_08")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_09")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_10")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_11")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_12")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_09")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_10")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_11")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_12")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
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
                P2Trans.position = new Vector3(15, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_01")
        {
            P2Trans.position = new Vector3(0, -1, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_02")
        {
                P2Trans.position = new Vector3(60, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_02")
        {
                P2Trans.position = new Vector3(35, -1, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_03")
        {
            P2Trans.position = new Vector3(90, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_03")
        {
            P2Trans.position = new Vector3(110, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_04")
        {
            P2Trans.position = new Vector3(160, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_04")
        {
            P2Trans.position = new Vector3(150, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_05")
        {
            P2Trans.position = new Vector3(150, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_05")
        {
            P2Trans.position = new Vector3(160, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_06")
        {
            P2Trans.position = new Vector3(185, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_06")
        {
            P2Trans.position = new Vector3(185, -1, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_07")
        {
            P2Trans.position = new Vector3(215, 21, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_07")
        {
            P2Trans.position = new Vector3(215, -1, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_08")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_08")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_09")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_10")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_11")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadFloor_12")
        {
            P2Trans.position = new Vector3(235, 5, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_09")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_10")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_11")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
        }
        if (collision.gameObject.name == "TeleportPadRoof_12")
        {
            P2Trans.position = new Vector3(235, 14, P2Trans.position.z);
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
