using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject PlayerCamera;             //gets an object (Should be the camera on the player controller. Object is set in the inspector)
    public Text Pickup_Notification_Text;       //gets a UI textbox (Should be set to the text box you want item pickup text to display to. Object is set via .Find("  ") parameter)

    private bool Obj_1_Aquired;     //Bool for object 1
    private bool Obj_2_Aquired;     //Bool for object 2
    private bool Obj_3_Aquired;     //Bool for object 3
    private bool Obj_4_Aquired;     //Bool for object 4

    void Start()
    {
        Cursor.visible = false;     //Hides the players cursor from view on game start

        Pickup_Notification_Text = GameObject.Find("UI_TextBox").GetComponent<Text>();      //Sets "Pickup_Notification_Text" to UI game object called "UI_TextBox"

        Obj_1_Aquired = false;     //Sets object 1 aquired to false
        Obj_2_Aquired = false;     //Sets object 2 aquired to false
        Obj_3_Aquired = false;     //Sets object 3 aquired to false
        Obj_4_Aquired = false;     //Sets object 4 aquired to false
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit HitInfo;     //The raycasts hit info

        Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out HitInfo, 3);       //Shoots a raycast outwards from the center of the camera 3 units long
      
        Debug.DrawRay(PlayerCamera.transform.position, PlayerCamera.transform.forward * 3, Color.red);          //Debug that shows what the raycast looks like in the color red

        if (HitInfo.collider)
        {
            if (HitInfo.collider.tag == "Item_1")                                     //If the "HitInfo" variable is colliding with an item that has the tag "Item"
            {
                Pickup_Notification_Text.text = "E to pick up item 1";                //Sets the string of text inside "UI_TextBox" to "Pick Up"
            }

            if (HitInfo.collider.tag == "Item_1" && Input.GetKeyDown(KeyCode.E))      //If player picks up Item 1
            {
                Destroy(HitInfo.collider.gameObject);                                 //Destroys the game object
                Obj_1_Aquired = true;                                                 //Sets Object 1 aquired to true
            }



            if (HitInfo.collider.tag == "Item_2")
            {
                Pickup_Notification_Text.text = "E to pick up item 2";
            }

            if (HitInfo.collider.tag == "Item_2" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(HitInfo.collider.gameObject);
                Obj_1_Aquired = true;
            }



            if (HitInfo.collider.tag == "Item_3")
            {
                Pickup_Notification_Text.text = "E to pick up item 3";
            }

            if (HitInfo.collider.tag == "Item_3" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(HitInfo.collider.gameObject);
                Obj_1_Aquired = true;
            }



            if (HitInfo.collider.tag == "Item_4")
            {
                Pickup_Notification_Text.text = "E to pick up item 4";
            }

            if (HitInfo.collider.tag == "Item_4" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(HitInfo.collider.gameObject);
                Obj_1_Aquired = true;
            }
        }

        if (HitInfo.collider == false)                          //If the "HitInfo" variable is not hitting an item that has the tag "Item"
        {
            Pickup_Notification_Text.text = string.Empty;       //Sets the string of text inside "UI_TextBox" to be empty
        }
    }
}
