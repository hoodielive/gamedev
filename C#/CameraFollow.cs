using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform pumpkinPos;
    private float zDistance = 7f;
    private float yDistance = 4f;

    private void Awake()
    {
        pumpkinPos = GameObject.Find("Pumpkin").transform;
    }

    void Update()
    {
        Vector3 temp = transform.position;
        temp.x = pumpkinPos.position.y + yDistance;
        temp.z = pumpkinPos.position.x - zDistance;
        transform.position = temp;

    }
}
