using System;


public BasicMovement : MonoBehaviour
{
  void Update()
  {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    Vector2 pos = transform.position;

    pos.x = h * Time.deltaTime;
    pos.y = v * Time.deltaTime;

    transform.position = pos;
  }
}

