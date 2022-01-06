using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    private Transform ThisTransform = null;
    public float RotSpeed = 45f;

    private void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        ThisTransform.Rotate(0,0, RotSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        //Get a list of all coins
        GameObject[] Coins = GameObject.FindGameObjectsWithTag("Coin");

        Destroy(gameObject);

        if(Coins.Length-1 <= 0)
        {
            print("Game Completed!");
        }
    }
}
