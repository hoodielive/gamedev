using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFading : MonoBehaviour
{
    void Awake()
    {
        var meshRenderer = GetComponent<MeshRenderer>();
        
        // Check to make sure that its valid before we use it.

        if (meshRenderer == null)
        {
            return;
        }

        var sineTime = Mathf.Sin(Time.time) + 1 / 2f;
        var color = new Color(sineTime, 0.5f, 0.5f);
        meshRenderer.material.color = color;
    }
}
