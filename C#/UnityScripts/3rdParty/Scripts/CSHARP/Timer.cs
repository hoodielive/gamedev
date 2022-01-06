using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour 
{
    public float TotalTime = 60f;

	// Use this for initialization
	void Start () 
    {
        Invoke("RestartLevel", TotalTime);
	}

    public void RestartLevel()
    {
        print("Restart Level");
    }
}
