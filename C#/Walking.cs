using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    public float moveForce = 10f;
    public Rigidbody myBody;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GetComponent<Rigidbody>().drag = 3;
    }

    private void Start()
    {
    }

    private void FixedUpdate()
    {
        MovePumpkin();
    }

    private void MovePumpkin()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

         myBody.AddForce(new Vector3(h * moveForce, 0f, v * moveForce));
    }
}
