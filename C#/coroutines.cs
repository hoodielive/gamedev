using System.Collections.Generic;
using UnityEngine;

public class Lear : MonoBehaviour
{
  private Start()
  {
    StartCoroutine(ExecuteSomethign());
  }

  IEnumerator ExecuteSomething() 
  {
    // Will wait for 2 seconds and then run (coroutine.)
    yield return new WaitForSeconds(2f);
    Debug.Log("Something is executed.");
  }
}
