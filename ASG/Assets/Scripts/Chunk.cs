using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CardinalDirections {north, east, south, west }

[CreateAssetMenu(fileName = "New Chunk", menuName = "Maze/Chunk")]
public class Chunk : ScriptableObject
{
    public GameObject floor;
    public GameObject[] borders = new GameObject[4];



}
