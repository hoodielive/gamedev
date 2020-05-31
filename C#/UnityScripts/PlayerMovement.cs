using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody myBody;
    
    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        PlayerMove();        
    }

    void PlayerMove()
    {
        myBody.velocity = new Vector3(movementSpeed, myBody.velocity.y, 0f);
    }
}
