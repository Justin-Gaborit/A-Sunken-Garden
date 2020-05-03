using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Camera Looking ")]
    [SerializeField] private float lookSensitivity = 10; //Used to adjust the sensitivity of mouse movement
    private float mouseX;
    private float mouseY;

    [SerializeField] private Camera cam;

    [Header("Movement")]
    private Rigidbody rigi;
    [SerializeField] private float normalMovementSpeed = 5.0f;
    [SerializeField] private float speedModifier = 1.0f;
    [SerializeField] private float currentMovementSpeed;
    [SerializeField] private float backMovementPenalty = 0.8f;
    [SerializeField] private float sideMovementPenalty = 0.9f;
    private Vector3 horizontalMove = Vector3.zero;
    private Vector3 verticalMove = Vector3.zero;
    private float zMovement = 0;
    private float xMovement = 0;

    private void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    void Update()
    {
        #region Camera Looking Direction
        mouseX = Input.GetAxis("Mouse X") * lookSensitivity;
        mouseY = Input.GetAxis("Mouse Y") * lookSensitivity;

        //Prevents the player from fliiping the camera into an upsidedown state
        Mathf.Clamp(mouseY, mouseY, mouseY);

        //Rotates the player transform by the x input on the y axis and the cam transform by the inverse y input on the x axis
        transform.eulerAngles += new Vector3(0f, mouseX, 0f);
        cam.transform.eulerAngles += new Vector3(-mouseY, 0f, 0f);
        #endregion

        #region Movement Input

        //Sprinting
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedModifier = 1.5f;
        }
        else
        {
            speedModifier = 1;
        }

        currentMovementSpeed = normalMovementSpeed * speedModifier;

        //Checks for forward/backwarf movement 
        if(Input.GetAxisRaw("Vertical") > 0)
        {
            zMovement = currentMovementSpeed;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            zMovement = -currentMovementSpeed * backMovementPenalty;
        }
        else
        {
            zMovement = 0;
        }

        //Checks form sideways movement
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            xMovement = currentMovementSpeed * sideMovementPenalty;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            xMovement = -currentMovementSpeed * sideMovementPenalty;
        }
        else
        {
            xMovement = 0;
        }

        //Creates vectors to be used to set velocity
        horizontalMove = transform.right * xMovement;
        verticalMove = transform.forward * zMovement;

        //Vector3.ClampMagnitude is used to prevent the player from going faster than the intended max speed
        rigi.velocity = Vector3.ClampMagnitude(horizontalMove + verticalMove, currentMovementSpeed);
        #endregion
    }
}
