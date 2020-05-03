using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerationRight : MonoBehaviour
{
    public GameObject SpawnLoc;

    public GameObject set1;

    void Start()
    {
        set1 = Resources.Load("Cell_1") as GameObject;
    }


    private void OnTriggerEnter(Collider collision)
    {
        SpawnLoc = GameObject.Find("SpawnLoc");
        float SpawnLocYRot = SpawnLoc.transform.eulerAngles.y;

        Vector3 SpawnLocation = new Vector3();
        SpawnLocation = GameObject.Find("SpawnLoc").transform.position;


        if (collision.gameObject.name == "PlayerObject")
        {
            int random = Random.Range(1, 1);
            switch (random)
            {
                case 1:
                    Instantiate(set1, SpawnLocation, Quaternion.Euler(0, SpawnLocYRot, 0));
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }

        }
    }

}