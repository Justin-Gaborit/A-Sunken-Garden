using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentFollow : MonoBehaviour
{
    public Transform Parent;
    public Transform Child;

    // Start is called before the first frame update
    void Start()
    {
        Child.position = Parent.position;
    }

    // Update is called once per frame
    void Update()
    {
        Child.position = Parent.position;
    }
}
