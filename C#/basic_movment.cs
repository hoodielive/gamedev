using System;


public BasicMovement : MonoBehaviour
{
  private float _speed = 10f;

  void Update()
  {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    Vector2 pos = transform.position;

    pos.x = h * _speed * Time.deltaTime;
    pos.y = v * _speed * Time.deltaTime;

    transform.position = pos;
  }
}

