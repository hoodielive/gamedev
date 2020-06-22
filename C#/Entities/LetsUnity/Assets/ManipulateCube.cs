using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulateCube : MonoBehaviour
{
   void Start()
   {
      foreach (Transform child in transform)
      {
         child.position += Vector3.up * 10.0f;
         Debug.Log("Tell me what is happening.");
      }
   }
}
