using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgroRadius : MonoBehaviour
{
    public bool followingPlayer;

    void Start()
    {
        followingPlayer = false;
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Entered");
            transform.localScale = new Vector3(20f, 20f, 20f);
            followingPlayer = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Exited");
            transform.localScale = new Vector3(5f, 5f, 5f);
            followingPlayer = false;
        }
    }
}
