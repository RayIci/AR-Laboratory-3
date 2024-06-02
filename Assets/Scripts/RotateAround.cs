using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    public GameObject ObjectToRotateAround;
    public float RotationSpeed = 0.1f;
    public Vector3 RotationAxis = new Vector3(0.0f, 1.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        if (ObjectToRotateAround == null)
        {
            Console.Error.WriteLine("The script cannot find an object to rotate around. Please link an object!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(this.ObjectToRotateAround.transform.position, this.RotationAxis, Time.deltaTime * RotationSpeed);   
    }
}
