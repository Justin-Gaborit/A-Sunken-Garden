using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration3Way : MonoBehaviour
{
    public GameObject SpawnLoc_1;
    public GameObject SpawnLoc_2;
    public GameObject SpawnLoc_3;

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;

    void Start()
    {
        set1 = Resources.Load("Cell_1") as GameObject;
        set2 = Resources.Load("Cell_TurnRight") as GameObject;
        set3 = Resources.Load("Cell_TurnLeft") as GameObject;
    }

    private void OnTriggerEnter(Collider collision)
    {
        SpawnLoc_1 = GameObject.Find("SpawnLoc_1");
        float SpawnLoc_1YRot = SpawnLoc_1.transform.eulerAngles.y;

        SpawnLoc_2 = GameObject.Find("SpawnLoc_2");
        float SpawnLoc_2YRot = SpawnLoc_2.transform.eulerAngles.y;

        SpawnLoc_3 = GameObject.Find("SpawnLoc_3");
        float SpawnLoc_3YRot = SpawnLoc_3.transform.eulerAngles.y;

        Vector3 SpawnLocation1 = new Vector3();
        SpawnLocation1 = GameObject.Find("SpawnLoc_1").transform.position;

        Vector3 SpawnLocation2 = new Vector3();
        SpawnLocation2 = GameObject.Find("SpawnLoc_2").transform.position;

        Vector3 SpawnLocation3 = new Vector3();
        SpawnLocation3 = GameObject.Find("SpawnLoc_3").transform.position;

        //For SpawnLoc 1
        if (collision.gameObject.name == "PlayerObject")
        {
            int random = Random.Range(1, 4);
            switch (random)
            {
                case 1:
                    Instantiate(set1, SpawnLocation1, Quaternion.Euler(0, SpawnLoc_1YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

            switch (random)
            {
                case 2:
                    Instantiate(set2, SpawnLocation1, Quaternion.Euler(0, SpawnLoc_1YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

            switch (random)
            {
                case 3:
                    Instantiate(set3, SpawnLocation1, Quaternion.Euler(0, SpawnLoc_1YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }
        }

        //For SpawnLoc 2
        if (collision.gameObject.name == "PlayerObject")
        {
            int random = Random.Range(1, 4);
            switch (random)
            {
                case 1:
                    Instantiate(set1, SpawnLocation2, Quaternion.Euler(0, SpawnLoc_2YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

            switch (random)
            {
                case 2:
                    Instantiate(set2, SpawnLocation2, Quaternion.Euler(0, SpawnLoc_2YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

            switch (random)
            {
                case 3:
                    Instantiate(set3, SpawnLocation2, Quaternion.Euler(0, SpawnLoc_2YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }
        }

        //For SpawnLoc 3
        if (collision.gameObject.name == "PlayerObject")
        {
            int random = Random.Range(1, 4);
            switch (random)
            {
                case 1:
                    Instantiate(set1, SpawnLocation3, Quaternion.Euler(0, SpawnLoc_3YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

            switch (random)
            {
                case 2:
                    Instantiate(set2, SpawnLocation3, Quaternion.Euler(0, SpawnLoc_3YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

            switch (random)
            {
                case 3:
                    Instantiate(set3, SpawnLocation3, Quaternion.Euler(0, SpawnLoc_3YRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }
        }
    }
}