using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statuses : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    private float speed = 0.1f;
    void Start()
    {
       Debug.Log("I am running from Start"); 
    }
    private void Awake()
    {
        Debug.Log("I am running from Awake");
    }
    void LateUpdate()
    {
        Debug.Log("I am running for LateUpdate");
    }
    void Update()
    {
        var movement = direction * speed;
        movement *= Time.deltaTime;
        this.transform.Translate(movement);
    }

}
