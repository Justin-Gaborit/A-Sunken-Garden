using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    public GameObject SpawnLoc;

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;
    public GameObject set4;

    void Start()
    {  
        set1 = Resources.Load("Cell_1") as GameObject;
        set2 = Resources.Load("Cell_TurnRight") as GameObject;
        set3 = Resources.Load("Cell_TurnLeft") as GameObject;
        set4 = Resources.Load("Cell_2") as GameObject;
    }

    private void OnTriggerEnter(Collider collision)
    {
        SpawnLoc = GameObject.Find("SpawnLoc");
        float SpawnLocYRot = SpawnLoc.transform.eulerAngles.y;

        Vector3 SpawnLocation = new Vector3();
        SpawnLocation = GameObject.Find("SpawnLoc").transform.position;

        if (collision.gameObject.name == "PlayerObject")
        {
            int random = Random.Range(1, 4);
            switch (random)
            {
                case 1:
                    Instantiate(set1, SpawnLocation, Quaternion.Euler(0, SpawnLocYRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

            switch (random)
            {
                case 2:
                    Instantiate(set2, SpawnLocation, Quaternion.Euler(0, SpawnLocYRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

            switch (random)
            {
                case 3:
                    Instantiate(set3, SpawnLocation, Quaternion.Euler(0, SpawnLocYRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }
        }
    }

}