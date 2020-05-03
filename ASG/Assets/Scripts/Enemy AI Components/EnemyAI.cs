using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   //for navmesh agent

public class EnemyAI : MonoBehaviour
{
    public GameObject player;           //Establishes publicly accesable game object representing the player
    private GameObject AgroSphere;      //Establishes private game object representing the enemy agro zone
    private NavMeshAgent NMA = null;    //Establishes private navmesh object representing the navmesh the enemy uses
    public Vector3 CenterWaypoint;      //Establishes the center naviagtion waypoint that the enemy AI uses to travel around the map
    public bool MT_CenterWaypoint;      //Establishes variable that dictates whether or not the enemy AI is moving towards the centerwaypoint

    public Vector3[] Waypoints;         //Establishes a Vector3 array the stores the location of AI naviagtion waypoints

    void Start()
    {
        AgroSphere = GameObject.Find("Agro Sphere");    //Finds an object in the scene with the name "Agro Sphere" and stores it in AgroSphere
        player = GameObject.Find("Player");             //Finds an object in the scene with the name "Player" and stores it in Player
        NMA = this.GetComponent<NavMeshAgent>();        //Gets navmesh agent from object that this script is attached to and stores it in NMA
        MT_CenterWaypoint = true;                       //Sets "MT_CenterWaypoint" to true by default
    }

    // Update is called once per frame
    void Update()
    {
        if (MT_CenterWaypoint == true)             //Moves enemy AI to "CenterWaypoint" if "MT_CenterPoint" is true
        {
            NMA.SetDestination(CenterWaypoint);
        }

        /*if (MT_CenterWaypoint == false)            //Moves enemy AI to "Waypoints[0]" if "MT_CenterPoint" is false 
        {
            NMA.SetDestination(Waypoints[]);
        }*/

        if (AgroSphere.GetComponent<AgroRadius>().followingPlayer == true)  //if bool "followingPlayer" from script "AgroSphere" is equal to true
        {
            NMA.SetDestination(player.transform.position);                  //then NavMeshAgents destiantion is set to "players" position
        }
    }
    void OnTriggerEnter(Collider colides)
    {
        if (colides.gameObject.tag == "Waypoint_Center")    //If enemy collides with an object of tag "Waypoint_Center"
        {
            int RandomWaypoint = Random.Range(0, 4);
            MT_CenterWaypoint = false;                      //"MT_CenterPoint" is then set to false;
            NMA.SetDestination(Waypoints[RandomWaypoint]);
        }

        if (colides.gameObject.tag == "Waypoint")    //If enemy collides with an object of tag "Waypoint"
        {
            MT_CenterWaypoint = true;                      //"MT_CenterPoint" is then set to true;
        }
    }
}
