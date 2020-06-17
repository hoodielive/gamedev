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
        var colorFade = FindObjectOfType<ColorFading>();
        Debug.Log("I am running from Start");
        Debug.Log(colorFade);
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
        // Ensure processes take place over a fixed period of time,
        // regardless of how many frames per second the game is
        // is running at (known as the game's frame rate).
        
        var movement = direction * speed;
        
        // We use the Time class deltaTime property to to access the
        // amount of time needed to render the last frame and incorporate
        // this into our calculations.
        
        movement *= Time.deltaTime;
        
        this.transform.Translate(movement);
    }
}
